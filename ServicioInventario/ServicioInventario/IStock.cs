using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ServicioInventario.Modelo;
using ServicioInventario.ViewModel;

namespace ServicioInventario
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStock" in both code and config file together.
    [ServiceContract]
    public interface IStock
    {
        //OperationContracts Productos
        [OperationContract]
        List<Productos> MostrarProductos();
        [OperationContract]
        bool CrearProducto(Productos productos);
        [OperationContract]
        bool EditarProducto(Productos productos);
        [OperationContract]
        Productos DetalleProducto(int identificador);
        [OperationContract]
        bool EliminarProducto(int identificador);

        //OperationContracts Categorias
        [OperationContract]
        List<Categoria> MostrarCategoria();
        [OperationContract]
        bool CrearCategoria(Categoria categoria);
        [OperationContract]
        bool EditarCategoria(Categoria categoria);
        [OperationContract]
        Categoria DetalleCategoria(int identificador);
        [OperationContract]
        bool EliminarCategoria(int identificador);

        ////Filtro
        //[OperationContract]

        [OperationContract]
        List<Inventario> MostrarInventario();
        List<Inventario> Filtro(string busqueda);
    }
}
