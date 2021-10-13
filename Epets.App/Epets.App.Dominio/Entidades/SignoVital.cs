using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Epets.App.Dominio.Entidades
{
    /// <summary>Class <c>SignoVital</c>
    /// Modela los signos vitales de la mascota
    /// </summary>
    
    [Table("SignoVitalDb")]
    public class SignoVital
    {
        [Column("Id")]
        [Key]
        // Identificador único de cada signo vital
        public int IdSigno{ get; set; }
        
        [Required]
        [Column("Fecha")]
        [StringLength(12,MinimumLength=5)]
        /// Fecha y hora en que se realizó la toma del signo vital 
        public DateTime FechaHora  { get; set; }
        
        [ForeignKey("IdAnimal")]
        /// Valor numérico del signo vital  
        //public float Valor_signo {get;set;}
        public virtual TipoAnimal TipoAnimal { get; set; }
        
        [ForeignKey("IdSigno")]
        /// Tipo de Signo vital medido
        public virtual TipoSigno TipoSigno { get; set; }
    }
}
