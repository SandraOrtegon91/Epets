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
        [Column("Id")]
        [Key]
        public int IdMedico{get;set;}

        [Required]
        [Column("Nombre")]
        [StringLength(50,MinimumLength=5)]
        public string Nombre{get;set;}
      
        [Required]
        [Column("TarjetaProfesional")]
        //Identificador unico de cada profesional
        public int TarjetaProfesional{get;set;}
        
        [ForeignKey("EspecialidadVeterinario")]      
        ///Relacion entre la especialidad medica y el Médico  
        public virtual EspecialidadVeterinario Especialidad{get;set;}
    }
}