using System;

namespace Epets.App.Dominio.Entidades

{
     /// <summary>Class <c>SolicitudVisita</c>
    /// Modela la solicitud que realiza el Propietario de la visita
    /// para la mascota
    /// </summary>   
  
    [Table("SolicitudVisitaDb")]
    1 reference
    public class SolicitudVisita
    {
        [Column("Id")]
        [Key]
        0 references
        public int Id { get; set; }
        
        [ForeignKey("Mascota")]
        0 references
        // Identificacion de la mascota
        public Mascota Mascota{get;set;}
        
        [ForeignKey("FechaVisita")]
        0 references
        /// Fecha y hora en que se agenda la visita       
        public DateTime FechaVisita{get;set;}
        
        [ForeignKey("Propietario")]
        0 references
        /// Relacion entre el propietario y la solicitud de Visita
        public Propietario Propietario{get;set;}
        
        [ForeignKey("NombreMascota")]
        0 references
        /// Relacion entre la Mascota y la solicitud de Visita
        public Mascota NombreMascota{get;set;}
        
        [ForeignKey("TipoAnimal")]
        0 references
        /// Relacion entre el Tipo de Animal y la solicitud de Visita
        public TipoAnimal TipoAnimal{get;set;}
        
        [ForeignKey("Especialidad")]
        0 references
        /// Relacion entre la Especialidad del Medico y la solicitud de Visita
        public Especialidad Especialidad{get;set;}
    }
}