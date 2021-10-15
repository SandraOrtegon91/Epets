using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Epets.App.Dominio.Entidades
{
    /// <summary>Class <c>Mascota</c>
    /// Modela la Mascota que es atendido por visita domiciliaria 
    /// por un Medico veterinario
    /// </summary>   

    [Table("MascotaDb")]
    public class Mascota
    {
        [Column("Id")]
        [Key]
        // Identificador único de cada Mascota
        public int IdMascota{get;set;}
        
        [Required]
        [Column("NombreMascota")]
        [StringLength(10,MinimumLength=5)]
        //Nombre de La Mascota
        public string NombreMascota{get;set;}
        
        [Required]
        [Column("ColorOjos")]
        [StringLength(10,MinimumLength=5)]
        //Color de Ojos de la Mascota
        public string ColorOjos{get;set;}
        
        [Required]
        [Column("ColorPiel")]
        [StringLength(10,MinimumLength=5)]
        //Color del pelaje o plumaje de la Mascota
        public string ColorPiel{get;set;}
        
        [Required]
        [Column("Estatura")]
        //Estatura de la Mascota
        public float Estatura{get;set;}
        
        [Required]
        [Column("Raza")]
        [StringLength(10,MinimumLength=5)]
        //Raza de la mascota
        public string Raza{get;set;}
        
        [ForeignKey("IdTipoAnimal")]
        [StringLength(15,MinimumLength=5)]
        //Tipo de la mascota
        public virtual TipoAnimal TipoAnimal{get;set;}

        [ForeignKey("IdPropietario")]
        // Relacion entre el propietario y la Mascota
        public virtual Propietario Propietario { get; set; }
        
//        [ForeignKey("IdMedico")]
        // Relacion entre el Medico y la Mascota
  //      public virtual Medico Medico { get; set; }    

       
    }
}
