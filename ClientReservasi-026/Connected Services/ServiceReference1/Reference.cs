﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientReservasi_026.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/pemesanan", ReplyAction="http://tempuri.org/IService1/pemesananResponse")]
        string pemesanan(string ID_reservasi, string Nama_customer, string No_telpon, int Jumlah_pemesanan, string ID_lokasi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/pemesanan", ReplyAction="http://tempuri.org/IService1/pemesananResponse")]
        System.Threading.Tasks.Task<string> pemesananAsync(string ID_reservasi, string Nama_customer, string No_telpon, int Jumlah_pemesanan, string ID_lokasi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/editpemesanan", ReplyAction="http://tempuri.org/IService1/editpemesananResponse")]
        string editpemesanan(string ID_reservasi, string Nama_customer, string No_telpon);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/editpemesanan", ReplyAction="http://tempuri.org/IService1/editpemesananResponse")]
        System.Threading.Tasks.Task<string> editpemesananAsync(string ID_reservasi, string Nama_customer, string No_telpon);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deletePemesanan", ReplyAction="http://tempuri.org/IService1/deletePemesananResponse")]
        string deletePemesanan(string ID_reservasi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deletePemesanan", ReplyAction="http://tempuri.org/IService1/deletePemesananResponse")]
        System.Threading.Tasks.Task<string> deletePemesananAsync(string ID_reservasi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReviewLokasi", ReplyAction="http://tempuri.org/IService1/ReviewLokasiResponse")]
        ServiceReservasi.CekLokasi[] ReviewLokasi();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReviewLokasi", ReplyAction="http://tempuri.org/IService1/ReviewLokasiResponse")]
        System.Threading.Tasks.Task<ServiceReservasi.CekLokasi[]> ReviewLokasiAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DetailLokasi", ReplyAction="http://tempuri.org/IService1/DetailLokasiResponse")]
        ServiceReservasi.DetailLokasi[] DetailLokasi();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DetailLokasi", ReplyAction="http://tempuri.org/IService1/DetailLokasiResponse")]
        System.Threading.Tasks.Task<ServiceReservasi.DetailLokasi[]> DetailLokasiAsync();
        
        // CODEGEN: Generating message contract since the wrapper name (Pemesanan) of message PemesananRequest does not match the default value (Pemesanan1)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Pemesanan", ReplyAction="http://tempuri.org/IService1/PemesananResponse")]
        ClientReservasi_026.ServiceReference1.PemesananResponse Pemesanan1(ClientReservasi_026.ServiceReference1.PemesananRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Pemesanan", ReplyAction="http://tempuri.org/IService1/PemesananResponse")]
        System.Threading.Tasks.Task<ClientReservasi_026.ServiceReference1.PemesananResponse> Pemesanan1Async(ClientReservasi_026.ServiceReference1.PemesananRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Pemesanan", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class PemesananRequest {
        
        public PemesananRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="PemesananResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class PemesananResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public ServiceReservasi.Pemesanan[] PemesananResult;
        
        public PemesananResponse() {
        }
        
        public PemesananResponse(ServiceReservasi.Pemesanan[] PemesananResult) {
            this.PemesananResult = PemesananResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ClientReservasi_026.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ClientReservasi_026.ServiceReference1.IService1>, ClientReservasi_026.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string pemesanan(string ID_reservasi, string Nama_customer, string No_telpon, int Jumlah_pemesanan, string ID_lokasi) {
            return base.Channel.pemesanan(ID_reservasi, Nama_customer, No_telpon, Jumlah_pemesanan, ID_lokasi);
        }
        
        public System.Threading.Tasks.Task<string> pemesananAsync(string ID_reservasi, string Nama_customer, string No_telpon, int Jumlah_pemesanan, string ID_lokasi) {
            return base.Channel.pemesananAsync(ID_reservasi, Nama_customer, No_telpon, Jumlah_pemesanan, ID_lokasi);
        }
        
        public string editpemesanan(string ID_reservasi, string Nama_customer, string No_telpon) {
            return base.Channel.editpemesanan(ID_reservasi, Nama_customer, No_telpon);
        }
        
        public System.Threading.Tasks.Task<string> editpemesananAsync(string ID_reservasi, string Nama_customer, string No_telpon) {
            return base.Channel.editpemesananAsync(ID_reservasi, Nama_customer, No_telpon);
        }
        
        public string deletePemesanan(string ID_reservasi) {
            return base.Channel.deletePemesanan(ID_reservasi);
        }
        
        public System.Threading.Tasks.Task<string> deletePemesananAsync(string ID_reservasi) {
            return base.Channel.deletePemesananAsync(ID_reservasi);
        }
        
        public ServiceReservasi.CekLokasi[] ReviewLokasi() {
            return base.Channel.ReviewLokasi();
        }
        
        public System.Threading.Tasks.Task<ServiceReservasi.CekLokasi[]> ReviewLokasiAsync() {
            return base.Channel.ReviewLokasiAsync();
        }
        
        public ServiceReservasi.DetailLokasi[] DetailLokasi() {
            return base.Channel.DetailLokasi();
        }
        
        public System.Threading.Tasks.Task<ServiceReservasi.DetailLokasi[]> DetailLokasiAsync() {
            return base.Channel.DetailLokasiAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClientReservasi_026.ServiceReference1.PemesananResponse ClientReservasi_026.ServiceReference1.IService1.Pemesanan1(ClientReservasi_026.ServiceReference1.PemesananRequest request) {
            return base.Channel.Pemesanan1(request);
        }
        
        public ServiceReservasi.Pemesanan[] Pemesanan1() {
            ClientReservasi_026.ServiceReference1.PemesananRequest inValue = new ClientReservasi_026.ServiceReference1.PemesananRequest();
            ClientReservasi_026.ServiceReference1.PemesananResponse retVal = ((ClientReservasi_026.ServiceReference1.IService1)(this)).Pemesanan1(inValue);
            return retVal.PemesananResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClientReservasi_026.ServiceReference1.PemesananResponse> ClientReservasi_026.ServiceReference1.IService1.Pemesanan1Async(ClientReservasi_026.ServiceReference1.PemesananRequest request) {
            return base.Channel.Pemesanan1Async(request);
        }
        
        public System.Threading.Tasks.Task<ClientReservasi_026.ServiceReference1.PemesananResponse> Pemesanan1Async() {
            ClientReservasi_026.ServiceReference1.PemesananRequest inValue = new ClientReservasi_026.ServiceReference1.PemesananRequest();
            return ((ClientReservasi_026.ServiceReference1.IService1)(this)).Pemesanan1Async(inValue);
        }
    }
}