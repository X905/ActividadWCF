using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServicioInventario.Modelo
{
    [DataContract]
    public class Productos
    {
        [DataMember]
        [Key]
        public int Id_Producto { get; set; }
        [DataMember]
        public int Id_Categoria { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public double Precio { get; set; }
        [DataMember]
        public int Stock { get; set; }
        [DataMember]
        public virtual Categoria Categoria { get; set; }
    }
}