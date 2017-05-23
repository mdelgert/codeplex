using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ServiceModel;

namespace DoorTime
{

    class Program
    {

        static SerialPort _serialPort;
        public static string message;

        static void Main(string[] args)
        {
            Console.WriteLine("BEGIN:");

            _serialPort = new SerialPort();
            _serialPort.PortName = "/dev/ttyACM0";
            _serialPort.BaudRate = 9600;
            _serialPort.Parity = Parity.None;
            _serialPort.DataBits = 8;
            _serialPort.StopBits = StopBits.One;
            _serialPort.Handshake = Handshake.XOnXOff;
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;
            _serialPort.Open();

            Console.WriteLine("Connecting to port");
            Thread.Sleep(15000);

            while (true)
            {
                
                //For example, to check if it's between 9:30 PM AND 5 AM

                if (IsTimeOfDayBetween(System.DateTime.Now, new TimeSpan(21, 30, 0), new TimeSpan(5, 0, 0)))
                {
                    Console.WriteLine("lock door");
                    message = "050\r\n";
                    _serialPort.Write(message);
                    Console.WriteLine(message);
                    _takePic();
                    _sendPic();

                    while (IsTimeOfDayBetween(System.DateTime.Now, new TimeSpan(21, 30, 0), new TimeSpan(5, 0, 0)))
                    {
                        Thread.Sleep(5000);
                        Console.WriteLine("sleep until true");
                    }
                }
                else
                {
                    Console.WriteLine("unlock door");
                    message = "120\r\n";
                    _serialPort.Write(message);
                    Console.WriteLine(message);
                    _takePic();
                    _sendPic();
                    while (!IsTimeOfDayBetween(System.DateTime.Now, new TimeSpan(21, 30, 0), new TimeSpan(5, 0, 0)))
                    {
                        Thread.Sleep(5000);
                        Console.WriteLine("sleep until false");
                    }
                }

            }



            //Console.WriteLine("END:");

            //Console.ReadKey();

        }

        static public bool IsTimeOfDayBetween(DateTime time,
                                      TimeSpan startTime, TimeSpan endTime)
        {
            if (endTime == startTime)
            {
                return true;
            }
            else if (endTime < startTime)
            {
                return time.TimeOfDay <= endTime ||
                    time.TimeOfDay >= startTime;
            }
            else
            {
                return time.TimeOfDay >= startTime &&
                    time.TimeOfDay <= endTime;
            }

        }

        public static void MoveDoor(bool _close)
        {

            Console.WriteLine(System.DateTime.Now.ToShortTimeString());

            _serialPort = new SerialPort();
            _serialPort.PortName = "/dev/ttyACM0";
            _serialPort.BaudRate = 9600;
            _serialPort.Parity = Parity.None;
            _serialPort.DataBits = 8;
            _serialPort.StopBits = StopBits.One;
            _serialPort.Handshake = Handshake.XOnXOff;
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;
            _serialPort.Open();

            string message = "";

            if (_close == true)
            {
                message = "130\r\n";
                Console.WriteLine(message);
                _serialPort.Write(message);
            }

            if (_close == false)
            {
                message = "050\r\n";
                Console.WriteLine(message);
                _serialPort.Write(message);
            }

            _serialPort.Close();

        }

        static void _takePic()
        {
            var info = new ProcessStartInfo();
            info.FileName = "raspistill";
            //info.Arguments = "-o image.jpg -q 20";
            info.Arguments = "-o image.jpg";
            info.UseShellExecute = false;
            info.CreateNoWindow = true;
            info.RedirectStandardOutput = true;
            info.RedirectStandardError = true;
            var p = Process.Start(info);
            p.WaitForExit();
            Console.WriteLine("_takePic() complete");
        }

        static void _sendPic()
        {
            var info = new ProcessStartInfo();
            info.FileName = "python";
            info.Arguments = " email_att.py image.jpg";
            info.UseShellExecute = false;
            info.CreateNoWindow = true;
            info.RedirectStandardOutput = true;
            info.RedirectStandardError = true;
            var p = Process.Start(info);
            p.WaitForExit();
            Console.WriteLine("_sendPic() complete");
        }

    }

}
