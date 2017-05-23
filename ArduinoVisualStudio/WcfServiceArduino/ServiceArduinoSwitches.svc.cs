using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Base.Core.BusinessLogic;
using Base.Core.EntityDataModel;

namespace WcfServiceArduino
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceArduinoSwitches" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceArduinoSwitches.svc or ServiceArduinoSwitches.svc.cs at the Solution Explorer and start debugging.
    public class ServiceArduinoSwitches : IServiceArduinoSwitches
    {
        public bool? GetStatus()
        {
            SwitchLayer l = new SwitchLayer();
            return l.SwitchStatus(1);
        }
    }

}
