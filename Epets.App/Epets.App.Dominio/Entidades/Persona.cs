using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Epets.App.Dominio.Entidades
{
    /// <summary>Class <c>Persona</c>
    /// Modela a la Persona con los atributos que comparten
    ///  en este caso son un Medico o un Propietario
    /// </summary>   
  
    [Table("PersonaDb")]
    public class Persona
    {
        [Column("Id")]
        [Key]
        // Identificador único de cada Persona
        public int Id{get;set;}
        
        [Required]
        [Column("Cedula")]
        [StringLength(10,MinimumLength=5)]
        //Cedula de la persona
        public string Cedula{get; set;}
        
        [Required]
        [Column("Nombre")]
        [StringLength(10,MinimumLength=5)]
        //Nombre de la Persona
        public string Nombre{get;set;}
        
        [Required]
        [Column("Apellido")]
        [StringLength(10,MinimumLength=5)]
        //Apellido de la Mascota
        public string Apellido{get;set;}
        
        [Required]
        [Column("Telefono")]
        [StringLength(10,MinimumLength=5)]
        //Telefono de la Persona
        public string Telefono{get;set;}
    }
}
