using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Epets.App.Dominio.Entidades
{
    /// <summary>Class <c>Medico</c>
    /// Modela un medico Veterinario que atiende una Mascota
    /// </summary>   

    [Table("MedicoDb")]
    public class Medico : Persona
    {

        [Column("IdMedico")]
        [Required(ErrorMessage = "Este dato es requerido")]
        public int IdMedico {get;set;}
 
      
       
        [Required(ErrorMessage = "Este dato es requerido")]
        [Column("TarjetaProfesional")]
        [StringLength(20,MinimumLength=5)]
        //Identificador unico de cada profesional
        public int TarjetaProfesional{get;set;}

      
        
        [ForeignKey("IdAnimal")]      
        //Relacion entre la especialidad medica y el Médico  
        public virtual TipoAnimal TipoAnimal { get; set; }
    }
}
