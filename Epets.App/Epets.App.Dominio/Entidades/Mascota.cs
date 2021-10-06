using System;

namespace Epets.App.Dominio.Entidades
{
    /// <summary>Class <c>Mascota</c>
    /// Modela la Mascota que es atendido por visita domiciliaria 
    /// por un Medico veterinario
    /// </summary>   

  //  [Table("MascotaDb")]
  //  1 reference
    public class Mascota
    {
  //      [Column("Id")]
  //      [Key]
  //      0 references
        // Identificador único de cada Mascota
        public int Id{get;set;}
        
   //     [Required]
   //     [Column("NombreMascota")]
   //     [StringLength(10,MinimumLength=5)]
   //     0 references
        //Nombre de La Mascota
        public string NombreMascota{get;set;}
        
    //    [Required]
    //    [Column("ColorOjos")]
    //    [StringLength(10,MinimumLength=5)]
    //    0 references
        //Color de Ojos de la Mascota
        public string ColorOjos{get;set;}
        
    //    [Required]
    //    [Column("ColorPiel")]
    //    [StringLength(10,MinimumLength=5)]
    //    0 references
        //Color del pelaje o plumaje de la Mascota
        public string ColorPiel{get;set;}
        
    //    [Required]
    //    [Column("Estatura")]
    //    0 references
        //Estatura de la Mascota
        public float Estatura{get;set;}
        
    //    [Required]
    //    [Column("Raza")]
    //    [StringLength(10,MinimumLength=5)]
    //    0 references
        //Raza de la mascota
        public string Raza{get;set;}
        
    //    [ForeignKey("Propietario")]
    //    0 references
        /// Relacion entre el propietario y la Mascota
        public Propietario Propietario{get;set;}
        
    //    [ForeignKey("Medico")]
    //    0 references
        /// Relacion entre el Medico y la Mascota
        public Medico Medico{get;set;}
        
    //    [ForeignKey("TipoAnimal")]
    //    0 references
        /// Relacion entre el Tipo de Animal y la Mascota
        public TipoAnimal TipoAnimal{get;set;}
        
    //    [ForeignKey("Historia")]
    //    0 references
        /// Relacion entre Mascota y su Historia clínica
        public Historia Historia{get;set;}
    }
}