﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KMPServer.ServerList {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServerList.IReport")]
    public interface IReport {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReport/Ping", ReplyAction="http://tempuri.org/IReport/PingResponse")]
        void Ping(string PublicIP, string Name, string Description, int Port);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IReportChannel : KMPServer.ServerList.IReport, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ReportClient : System.ServiceModel.ClientBase<KMPServer.ServerList.IReport>, KMPServer.ServerList.IReport {
        
        public ReportClient() {
        }
        
        public ReportClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ReportClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReportClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReportClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Ping(string PublicIP, string Name, string Description, int Port) {
            base.Channel.Ping(PublicIP, Name, Description, Port);
        }
    }
}
