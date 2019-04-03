using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServicioInventario.Modelo
{
    [DataContract]
    public class Categoria
    {
        [DataMember]
        [Key]
        public int Id_Categoria { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
        [DataMember]
        public virtual List<Productos> Productos { get; set; }
    }
}