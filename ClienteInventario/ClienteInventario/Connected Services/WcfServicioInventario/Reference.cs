﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteInventario.WcfServicioInventario {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Productos", Namespace="http://schemas.datacontract.org/2004/07/ServicioInventario.Modelo")]
    [System.SerializableAttribute()]
    public partial class Productos : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Id_CategoriaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Id_ProductoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PrecioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StockField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id_Categoria {
            get {
                return this.Id_CategoriaField;
            }
            set {
                if ((this.Id_CategoriaField.Equals(value) != true)) {
                    this.Id_CategoriaField = value;
                    this.RaisePropertyChanged("Id_Categoria");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id_Producto {
            get {
                return this.Id_ProductoField;
            }
            set {
                if ((this.Id_ProductoField.Equals(value) != true)) {
                    this.Id_ProductoField = value;
                    this.RaisePropertyChanged("Id_Producto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Precio {
            get {
                return this.PrecioField;
            }
            set {
                if ((this.PrecioField.Equals(value) != true)) {
                    this.PrecioField = value;
                    this.RaisePropertyChanged("Precio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Stock {
            get {
                return this.StockField;
            }
            set {
                if ((this.StockField.Equals(value) != true)) {
                    this.StockField = value;
                    this.RaisePropertyChanged("Stock");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Categoria", Namespace="http://schemas.datacontract.org/2004/07/ServicioInventario.Modelo")]
    [System.SerializableAttribute()]
    public partial class Categoria : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Id_CategoriaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id_Categoria {
            get {
                return this.Id_CategoriaField;
            }
            set {
                if ((this.Id_CategoriaField.Equals(value) != true)) {
                    this.Id_CategoriaField = value;
                    this.RaisePropertyChanged("Id_Categoria");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Inventario", Namespace="http://schemas.datacontract.org/2004/07/ServicioInventario.ViewModel")]
    [System.SerializableAttribute()]
    public partial class Inventario : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Id_CategoriaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Id_ProductoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreCategoriaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PrecioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StockInventarioField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id_Categoria {
            get {
                return this.Id_CategoriaField;
            }
            set {
                if ((this.Id_CategoriaField.Equals(value) != true)) {
                    this.Id_CategoriaField = value;
                    this.RaisePropertyChanged("Id_Categoria");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id_Producto {
            get {
                return this.Id_ProductoField;
            }
            set {
                if ((this.Id_ProductoField.Equals(value) != true)) {
                    this.Id_ProductoField = value;
                    this.RaisePropertyChanged("Id_Producto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreCategoria {
            get {
                return this.NombreCategoriaField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreCategoriaField, value) != true)) {
                    this.NombreCategoriaField = value;
                    this.RaisePropertyChanged("NombreCategoria");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Precio {
            get {
                return this.PrecioField;
            }
            set {
                if ((this.PrecioField.Equals(value) != true)) {
                    this.PrecioField = value;
                    this.RaisePropertyChanged("Precio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int StockInventario {
            get {
                return this.StockInventarioField;
            }
            set {
                if ((this.StockInventarioField.Equals(value) != true)) {
                    this.StockInventarioField = value;
                    this.RaisePropertyChanged("StockInventario");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WcfServicioInventario.IStock")]
    public interface IStock {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStock/MostrarProductos", ReplyAction="http://tempuri.org/IStock/MostrarProductosResponse")]
        ClienteInventario.WcfServicioInventario.Productos[] MostrarProductos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStock/MostrarProductos", ReplyAction="http://tempuri.org/IStock/MostrarProductosResponse")]
        System.Threading.Tasks.Task<ClienteInventario.WcfServicioInventario.Productos[]> MostrarProductosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStock/CrearProducto", ReplyAction="http://tempuri.org/IStock/CrearProductoResponse")]
        bool CrearProducto(ClienteInventario.WcfServicioInventario.Productos productos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStock/CrearProducto", ReplyAction="http://tempuri.org/IStock/CrearProductoResponse")]
        System.Threading.Tasks.Task<bool> CrearProductoAsync(ClienteInventario.WcfServicioInventario.Productos productos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStock/EditarProducto", ReplyAction="http://tempuri.org/IStock/EditarProductoResponse")]
        bool EditarProducto(ClienteInventario.WcfServicioInventario.Productos productos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStock/EditarProducto", ReplyAction="http://tempuri.org/IStock/EditarProductoResponse")]
        System.Threading.Tasks.Task<bool> EditarProductoAsync(ClienteInventario.WcfServicioInventario.Productos productos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStock/DetalleProducto", ReplyAction="http://tempuri.org/IStock/DetalleProductoResponse")]
        ClienteInventario.WcfServicioInventario.Productos DetalleProducto(int identificador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStock/DetalleProducto", ReplyAction="http://tempuri.org/IStock/DetalleProductoResponse")]
        System.Threading.Tasks.Task<ClienteInventario.WcfServicioInventario.Productos> DetalleProductoAsync(int identificador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStock/EliminarProducto", ReplyAction="http://tempuri.org/IStock/EliminarProductoResponse")]
        bool EliminarProducto(int identificador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStock/EliminarProducto", ReplyAction="http://tempuri.org/IStock/EliminarProductoResponse")]
        System.Threading.Tasks.Task<bool> EliminarProductoAsync(int identificador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStock/MostrarCategoria", ReplyAction="http://tempuri.org/IStock/MostrarCategoriaResponse")]
        ClienteInventario.WcfServicioInventario.Categoria[] MostrarCategoria();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStock/MostrarCategoria", ReplyAction="http://tempuri.org/IStock/MostrarCategoriaResponse")]
        System.Threading.Tasks.Task<ClienteInventario.WcfServicioInventario.Categoria[]> MostrarCategoriaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStock/CrearCategoria", ReplyAction="http://tempuri.org/IStock/CrearCategoriaResponse")]
        bool CrearCategoria(ClienteInventario.WcfServicioInventario.Categoria categoria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStock/CrearCategoria", ReplyAction="http://tempuri.org/IStock/CrearCategoriaResponse")]
        System.Threading.Tasks.Task<bool> CrearCategoriaAsync(ClienteInventario.WcfServicioInventario.Categoria categoria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStock/EditarCategoria", ReplyAction="http://tempuri.org/IStock/EditarCategoriaResponse")]
        bool EditarCategoria(ClienteInventario.WcfServicioInventario.Categoria categoria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStock/EditarCategoria", ReplyAction="http://tempuri.org/IStock/EditarCategoriaResponse")]
        System.Threading.Tasks.Task<bool> EditarCategoriaAsync(ClienteInventario.WcfServicioInventario.Categoria categoria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStock/DetalleCategoria", ReplyAction="http://tempuri.org/IStock/DetalleCategoriaResponse")]
        ClienteInventario.WcfServicioInventario.Categoria DetalleCategoria(int identificador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStock/DetalleCategoria", ReplyAction="http://tempuri.org/IStock/DetalleCategoriaResponse")]
        System.Threading.Tasks.Task<ClienteInventario.WcfServicioInventario.Categoria> DetalleCategoriaAsync(int identificador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStock/EliminarCategoria", ReplyAction="http://tempuri.org/IStock/EliminarCategoriaResponse")]
        bool EliminarCategoria(int identificador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStock/EliminarCategoria", ReplyAction="http://tempuri.org/IStock/EliminarCategoriaResponse")]
        System.Threading.Tasks.Task<bool> EliminarCategoriaAsync(int identificador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStock/MostrarInventario", ReplyAction="http://tempuri.org/IStock/MostrarInventarioResponse")]
        ClienteInventario.WcfServicioInventario.Inventario[] MostrarInventario();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStock/MostrarInventario", ReplyAction="http://tempuri.org/IStock/MostrarInventarioResponse")]
        System.Threading.Tasks.Task<ClienteInventario.WcfServicioInventario.Inventario[]> MostrarInventarioAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStockChannel : ClienteInventario.WcfServicioInventario.IStock, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StockClient : System.ServiceModel.ClientBase<ClienteInventario.WcfServicioInventario.IStock>, ClienteInventario.WcfServicioInventario.IStock {
        
        public StockClient() {
        }
        
        public StockClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StockClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StockClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StockClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ClienteInventario.WcfServicioInventario.Productos[] MostrarProductos() {
            return base.Channel.MostrarProductos();
        }
        
        public System.Threading.Tasks.Task<ClienteInventario.WcfServicioInventario.Productos[]> MostrarProductosAsync() {
            return base.Channel.MostrarProductosAsync();
        }
        
        public bool CrearProducto(ClienteInventario.WcfServicioInventario.Productos productos) {
            return base.Channel.CrearProducto(productos);
        }
        
        public System.Threading.Tasks.Task<bool> CrearProductoAsync(ClienteInventario.WcfServicioInventario.Productos productos) {
            return base.Channel.CrearProductoAsync(productos);
        }
        
        public bool EditarProducto(ClienteInventario.WcfServicioInventario.Productos productos) {
            return base.Channel.EditarProducto(productos);
        }
        
        public System.Threading.Tasks.Task<bool> EditarProductoAsync(ClienteInventario.WcfServicioInventario.Productos productos) {
            return base.Channel.EditarProductoAsync(productos);
        }
        
        public ClienteInventario.WcfServicioInventario.Productos DetalleProducto(int identificador) {
            return base.Channel.DetalleProducto(identificador);
        }
        
        public System.Threading.Tasks.Task<ClienteInventario.WcfServicioInventario.Productos> DetalleProductoAsync(int identificador) {
            return base.Channel.DetalleProductoAsync(identificador);
        }
        
        public bool EliminarProducto(int identificador) {
            return base.Channel.EliminarProducto(identificador);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarProductoAsync(int identificador) {
            return base.Channel.EliminarProductoAsync(identificador);
        }
        
        public ClienteInventario.WcfServicioInventario.Categoria[] MostrarCategoria() {
            return base.Channel.MostrarCategoria();
        }
        
        public System.Threading.Tasks.Task<ClienteInventario.WcfServicioInventario.Categoria[]> MostrarCategoriaAsync() {
            return base.Channel.MostrarCategoriaAsync();
        }
        
        public bool CrearCategoria(ClienteInventario.WcfServicioInventario.Categoria categoria) {
            return base.Channel.CrearCategoria(categoria);
        }
        
        public System.Threading.Tasks.Task<bool> CrearCategoriaAsync(ClienteInventario.WcfServicioInventario.Categoria categoria) {
            return base.Channel.CrearCategoriaAsync(categoria);
        }
        
        public bool EditarCategoria(ClienteInventario.WcfServicioInventario.Categoria categoria) {
            return base.Channel.EditarCategoria(categoria);
        }
        
        public System.Threading.Tasks.Task<bool> EditarCategoriaAsync(ClienteInventario.WcfServicioInventario.Categoria categoria) {
            return base.Channel.EditarCategoriaAsync(categoria);
        }
        
        public ClienteInventario.WcfServicioInventario.Categoria DetalleCategoria(int identificador) {
            return base.Channel.DetalleCategoria(identificador);
        }
        
        public System.Threading.Tasks.Task<ClienteInventario.WcfServicioInventario.Categoria> DetalleCategoriaAsync(int identificador) {
            return base.Channel.DetalleCategoriaAsync(identificador);
        }
        
        public bool EliminarCategoria(int identificador) {
            return base.Channel.EliminarCategoria(identificador);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarCategoriaAsync(int identificador) {
            return base.Channel.EliminarCategoriaAsync(identificador);
        }
        
        public ClienteInventario.WcfServicioInventario.Inventario[] MostrarInventario() {
            return base.Channel.MostrarInventario();
        }
        
        public System.Threading.Tasks.Task<ClienteInventario.WcfServicioInventario.Inventario[]> MostrarInventarioAsync() {
            return base.Channel.MostrarInventarioAsync();
        }
    }
}