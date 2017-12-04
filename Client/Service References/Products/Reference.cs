﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.Products {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Products.IProducts")]
    public interface IProducts {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducts/UpdatePrice", ReplyAction="http://tempuri.org/IProducts/UpdatePriceResponse")]
        bool UpdatePrice(string code, decimal price);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducts/UpdatePrice", ReplyAction="http://tempuri.org/IProducts/UpdatePriceResponse")]
        System.Threading.Tasks.Task<bool> UpdatePriceAsync(string code, decimal price);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductsChannel : Client.Products.IProducts, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductsClient : System.ServiceModel.ClientBase<Client.Products.IProducts>, Client.Products.IProducts {
        
        public ProductsClient() {
        }
        
        public ProductsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool UpdatePrice(string code, decimal price) {
            return base.Channel.UpdatePrice(code, price);
        }
        
        public System.Threading.Tasks.Task<bool> UpdatePriceAsync(string code, decimal price) {
            return base.Channel.UpdatePriceAsync(code, price);
        }
    }
}
