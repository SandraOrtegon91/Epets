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
        [Required]
        [Column("TarjetaProfesional")]
        //Identificador unico de cada profesional
        public int TarjetaProfesional{get;set;}
        
        [ForeignKey("IdTipoAnimal")]      
        //Identificacion de la especialidad y el Médico  
        public virtual TipoAnimal TipoAnimal { get; set; }
    }
}
