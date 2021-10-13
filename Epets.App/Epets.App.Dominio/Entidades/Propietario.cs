using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Epets.App.Dominio.Entidades
{
    /// <summary>Class <c>Propietario</c>
    /// Modela al propietario de la Mascota
    /// </summary>   

    [Table("PropietariosDb")]
    public class Propietario : Persona
    {
        [Column("Id")]
        //[Key]
        //Datos del Propietario de la mascota
        public int IdPropietario{get;set;}
        
        [Required]
        [Column("Direccion")]
        [StringLength(50,MinimumLength=5)]
        //Direccion del Propietario
        public string Direccion{get;set;}
        
        /*[ForeignKey("SolicitudVisita")]
        //Referencia a la lista de Solicitud de visita  
        public System.Collections.Generic.List<SolicitudVisita> SolicitudVisita{get;set;}*/
        
        [ForeignKey("IdMascota")]
        //Referencia a la lista de Mascotas que puede tener un propietario  
        //public System.Collections.Generic.List<Mascota> MascotasPropietario { get; set; }
        public virtual Mascota Mascota { get; set; }
    }
}
