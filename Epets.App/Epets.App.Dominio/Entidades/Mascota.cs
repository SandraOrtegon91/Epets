using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        
        [Required(ErrorMessage = "Este dato es requerido")]
        [Column("NombreMascota")]
        [StringLength(10,MinimumLength=5)]
        //Nombre de La Mascota
        public string NombreMascota{get;set;}
        
        [Required(ErrorMessage = "Este dato es requerido")]
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
        
        [Required]
        [Column("TipoMascota")]
        [StringLength(15,MinimumLength=5)]
        //Tipo de la mascota
        public string TipoMascota{get;set;}

        [ForeignKey("IdPropietario")]
        // Relacion entre el propietario y la Mascota
        public virtual Propietario Propietario{ get; set; }
        
        [ForeignKey("IdMedico")]
        // Relacion entre el Medico y la Mascota
        public virtual Medico Medico{ get; set; }
        
        [ForeignKey("IdHistoria")]
        // Relacion entre Mascota y su Historia clínica
        
        public virtual Historia Historia{ get; set; }
    }
}
