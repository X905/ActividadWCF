using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServicioInventario.ViewModel
{
    [DataContract]
    public class Inventario
    {
        [DataMember]
        public int Id_Producto { get; set; }
        [DataMember]
        public int Id_Categoria { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public double Precio { get; set; }
        [DataMember]
        public int StockInventario { get; set; }
        [DataMember]
        public string NombreCategoria { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
    }
}