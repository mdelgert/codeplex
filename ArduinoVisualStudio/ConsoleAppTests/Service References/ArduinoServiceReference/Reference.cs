﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleAppTests.ArduinoServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ArduinoServiceReference.IServiceArduinoSwitches")]
    public interface IServiceArduinoSwitches {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceArduinoSwitches/GetStatus", ReplyAction="http://tempuri.org/IServiceArduinoSwitches/GetStatusResponse")]
        System.Nullable<bool> GetStatus();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceArduinoSwitches/GetStatus", ReplyAction="http://tempuri.org/IServiceArduinoSwitches/GetStatusResponse")]
        System.Threading.Tasks.Task<System.Nullable<bool>> GetStatusAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceArduinoSwitchesChannel : ConsoleAppTests.ArduinoServiceReference.IServiceArduinoSwitches, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceArduinoSwitchesClient : System.ServiceModel.ClientBase<ConsoleAppTests.ArduinoServiceReference.IServiceArduinoSwitches>, ConsoleAppTests.ArduinoServiceReference.IServiceArduinoSwitches {
        
        public ServiceArduinoSwitchesClient() {
        }
        
        public ServiceArduinoSwitchesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceArduinoSwitchesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceArduinoSwitchesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceArduinoSwitchesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Nullable<bool> GetStatus() {
            return base.Channel.GetStatus();
        }
        
        public System.Threading.Tasks.Task<System.Nullable<bool>> GetStatusAsync() {
            return base.Channel.GetStatusAsync();
        }
    }
}