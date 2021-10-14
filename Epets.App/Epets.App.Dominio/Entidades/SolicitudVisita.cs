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
        public int IdSolicitudVisita { get; set; }

        [Column("FechaVisita")]
        /// Fecha y hora en que se agenda la visita       
        public DateTime FechaVisita{ get; set; }
        
        [ForeignKey("IdMascota")]
        // Relacionada con la identificacion de la mascota
        public virtual Mascota Mascota { get; set; }
                
        [ForeignKey("IdPropietario")]
        // Relacion entre el propietario y la solicitud de Visita
        public virtual Propietario Propietario { get; set; }
        
        [ForeignKey("IdTipoAnimal")]
        // Relacion entre el Tipo de Animal y la solicitud de Visita
        public virtual TipoAnimal TipoAnimal { get; set; }
    }
}
