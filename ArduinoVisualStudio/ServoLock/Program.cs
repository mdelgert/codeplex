using System;
using System.IO.Ports;
using System.Threading;
using System.Diagnostics;
using ServoLock.ArduinoServiceReference;

namespace ServoLock
{
    class Program
    {


        static bool _continue;
        static SerialPort _serialPort;

        //public static void Main()
        //{
        //    //RecordVid();
        //    //MoveDoor();
        //    //Console.ReadKey();

        //    while (true)
        //    {
        //        // code here

        //        ServiceArduinoSwitchesClient client = new ServiceArduinoSwitchesClient();
        //        bool? _status = client.GetStatus();

        //        //_serialPort = new SerialPort();
        //        //_serialPort.PortName = "/dev/ttyACM0";
        //        //_serialPort.BaudRate = 9600;
        //        //_serialPort.Parity = Parity.None;
        //        //_serialPort.DataBits = 8;
        //        //_serialPort.StopBits = StopBits.One;
        //        //_serialPort.Handshake = Handshake.XOnXOff;
        //        //_serialPort.ReadTimeout = 500;
        //        //_serialPort.WriteTimeout = 500;
        //        //_serialPort.Open();

        //        //if (_status == true)
        //        //{
        //        //    _serialPort.Write("130");
        //        //}
        //        //else
        //        //{
        //        //    _serialPort.Write("050");
        //        //}

        //        //_serialPort.Close();

        //        Console.WriteLine(_status.ToString());


        //        Thread.Sleep(1000);
        //    }

        //}

        //private static void Main(string[] args)
        //{
        //    // Create a IPC wait handle with a unique identifier.
        //    bool createdNew;
        //    var waitHandle = new EventWaitHandle(false, EventResetMode.AutoReset, "CF2D4313-33DE-489D-9721-6AFF69841DEA", out createdNew);
        //    var signaled = false;

        //    // If the handle was already there, inform the other process to exit itself.
        //    // Afterwards we'll also die.
        //    if (!createdNew)
        //    {
        //        Log("Inform other process to stop.");
        //        waitHandle.Set();
        //        Log("Informer exited.");

        //        return;
        //    }

        //    // Start a another thread that does something every 10 seconds.
        //    var timer = new Timer(OnTimerElapsed, null, TimeSpan.Zero, TimeSpan.FromSeconds(1));

        //    // Wait if someone tells us to die or do every five seconds something else.
        //    do
        //    {
        //        signaled = waitHandle.WaitOne(TimeSpan.FromSeconds(2));
        //        // ToDo: Something else if desired.
        //    } while (!signaled);

        //    // The above loop with an interceptor could also be replaced by an endless waiter
        //    //waitHandle.WaitOne();

        //    Log("Got signal to kill myself.");
        //}

        private static void Log(string message)
        {
            //Console.WriteLine(DateTime.Now + ": " + message);
            ServiceArduinoSwitchesClient client = new ServiceArduinoSwitchesClient();
            bool? _status = client.GetStatus();

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

            if (_status == true)
            {
                _serialPort.Write("130");
            }
            else
            {
                _serialPort.Write("050");
            }

            _serialPort.Close();

            Console.WriteLine(_status.ToString());

        }

        private static void OnTimerElapsed(object state)
        {
            Log("Timer elapsed.");
        }

        private static void Main(string[] args)
        {
            //MoveDoor();

            ServiceArduinoSwitchesClient client = new ServiceArduinoSwitchesClient();
            client.InnerChannel.OperationTimeout = TimeSpan.FromMinutes(10);
            bool? _status = client.GetStatus();
            client.Close();
            Console.WriteLine(_status.ToString());
            Console.ReadKey();

        }
        
        public static void MoveDoor()
        {

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
            _continue = true;

            Console.Write("Type 1 unlock or 2 lock door then enter, QUIT to exit:");
            
            string _userInput = "";
            string message = "";

            _continue = true;

            while (_continue)
            {
                //_userInput = Console.ReadLine();

                Thread.Sleep(5000);

                ServiceArduinoSwitchesClient client = new ServiceArduinoSwitchesClient();
                bool? _status = client.GetStatus();
                client.Close();

                //_userInput = Console.ReadLine();

                if (_status == true)
                {
                    _userInput = "1";
                }
                else
                {
                    _userInput = "2";
                }


                if (_userInput == "1")
                {
                    message = "130";
                    Console.WriteLine("Input [" + _userInput + "]");
                    _serialPort.Write(message);
                    //RecordVid();
                }

                if (_userInput == "2")
                {
                    message = "050";
                    Console.WriteLine("Input [" + _userInput + "]");
                    _serialPort.Write(message);
                    //RecordVid();
                }

                if (_userInput == "QUIT")
                {
                    _continue = false;
                    break;
                }
            }

            _serialPort.Close();

        }

        public static void RecordVid()
        {
            //http://www.raspberrypi-spy.co.uk/2013/05/capturing-hd-video-with-the-pi-camera-module/

            //http://stackoverflow.com/questions/19198351/execute-shell-command-with-mono-on-raspbian
            //http://thepihut.com/pages/how-to-install-the-raspberry-pi-camera

            var info = new ProcessStartInfo();

            info.FileName = "raspistill";
            info.Arguments = "-o test.jpg";

            //info.FileName = "raspivid";
            //info.Arguments = "-o myvid.h264";

            info.UseShellExecute = false;
            info.CreateNoWindow = true;

            info.RedirectStandardOutput = true;
            info.RedirectStandardError = true;

            var p = Process.Start(info);
            
            //p.WaitForExit();
            //ConvertRecordVid();
        }

        public static void ConvertRecordVid()
        {
            var info = new ProcessStartInfo();
            info.FileName = "MP4Box";
            info.Arguments = "-fps 30 -add myvid.h264 myvid.mp4";
            info.UseShellExecute = false;
            info.CreateNoWindow = true;
            info.RedirectStandardOutput = true;
            info.RedirectStandardError = true;
            var p = Process.Start(info);
            //p.WaitForExit();
        }

        //public static void SendCommand2(string _Port, string _Angle)
        //{
        //    Console.WriteLine("PORT=" + _Port);
        //    Console.WriteLine("Angle=" + _Angle);
        //    _serialPort = new SerialPort(_Port, 9600);
        //    _serialPort.ReadTimeout = 400;
        //    _serialPort.Open();
        //    //_serialPort.Write(_Angle);
        //    _serialPort.WriteLine(_Angle);
        //    _serialPort.Close();
        //}

        //public static void SendCommand(string _Port, string _Angle)
        //{
        //    Console.WriteLine("PORT=" + _Port);
        //    Console.WriteLine("Angle=" + _Angle);

        //    string name;
        //    string message;
        //    StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
        //    Thread readThread = new Thread(Read);

        //    _serialPort = new SerialPort();

        //    _serialPort.PortName = _Port;
        //    _serialPort.BaudRate = 9600;
        //    _serialPort.Parity = Parity.None;
        //    _serialPort.DataBits = 8;
        //    _serialPort.StopBits = StopBits.One;
        //    _serialPort.Handshake = Handshake.XOnXOff;

        //    // Set the read/write timeouts
        //    _serialPort.ReadTimeout = 500;
        //    _serialPort.WriteTimeout = 500;

        //    _serialPort.Open();
        //    _continue = true;
        //    readThread.Start();

        //    Console.Write("Name: ");
        //    name = Console.ReadLine();

        //    Console.WriteLine("Type QUIT to exit");

        //    while (_continue)
        //    {
        //        message = Console.ReadLine();

        //        if (stringComparer.Equals("quit", message))
        //        {
        //            _continue = false;
        //        }
        //        else
        //        {
        //            _serialPort.WriteLine(
        //                String.Format(message));
        //        }
        //    }

        //    readThread.Join();
        //    _serialPort.Close();

        //}

        //public static void ListPorts()
        //{
        //    string[] ports = SerialPort.GetPortNames();

        //    Console.WriteLine("The following serial ports were found:");

        //    // Display each port name to the console. 
        //    foreach (string port in ports)
        //    {
        //        Console.WriteLine(port);
        //    }
        //}

        //public static void Read()
        //{
        //    while (_continue)
        //    {
        //        try
        //        {
        //            string message = _serialPort.ReadLine();
        //            Console.WriteLine(message);
        //        }
        //        catch (TimeoutException) { }
        //    }
        //}

    }

}
