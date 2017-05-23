using System;
using System.Threading;
using System.IO.Ports;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Base.MvcAppMobile.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public static SerialPort _serialPort;

        public ActionResult Index()
        {
            _serialPort = new SerialPort();
            _serialPort.PortName = "/dev/ttyACM0";
            //_serialPort.PortName = "/dev/ttyUSB0";
            _serialPort.BaudRate = 9600;
            _serialPort.Parity = Parity.None;
            _serialPort.DataBits = 8;
            _serialPort.StopBits = StopBits.One;
            _serialPort.Handshake = Handshake.XOnXOff;
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;
            _serialPort.Open();
            //Thread.Sleep(5000);
            ViewBag.Message = "Serial port connected.";
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult License()
        {
            return View();
        }

        public ActionResult LightOn()
        {
            _serialPort.Write("1\r\n");
            return View();
        }

        public ActionResult LightOff()
        {
            _serialPort.Write("0\r\n");
            return View();
        }

    }

}
