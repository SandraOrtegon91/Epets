using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Epets.App.Dominio.Entidades
{
    /// <summary>Class <c>SolicitudVisita</c>
    /// Modela la solicitud que realiza el Propietario de la visita
    /// para la mascota
    /// </summary>   
  
    [Table("SolicitudVisitaDb")]
    public class SolicitudVisita
    {
        [Column("Id")]
        [Key]
        public int Id { get; set; }
        
        [ForeignKey("IdMascota")]
        // Identificacion de la mascota
        public virtual Mascota Mascota { get; set; }
        
        [Column("FechaVisita")]
        /// Fecha y hora en que se agenda la visita       
        public DateTime FechaVisita{ get; set; }
        
        [ForeignKey("IdPropietario")]
        /// Relacion entre el propietario y la solicitud de Visita
        public virtual Propietario Propietario { get; set; }
        
        [Required]
        [Column("NombreMascota")]
        [StringLength(10,MinimumLength=5)]
        /// Relacion entre la Mascota y la solicitud de Visita
        public string NombreMascota{get;set;}
        
        [ForeignKey("IdAnimal")]
        /// Relacion entre el Tipo de Animal y la solicitud de Visita
        public virtual TipoAnimal TipoAnimal { get; set; }
/*        [ForeignKey("Especialidad")]
        /// Relacion entre la Especialidad del Medico y la solicitud de Visita
        public Especialidad Especialidad{get;set;}*/
    }
}
