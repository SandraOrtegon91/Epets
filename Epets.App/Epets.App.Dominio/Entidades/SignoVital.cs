using System;
namespace Epets.App.Dominio.Entidades
{
    /// <summary>Class <c>SignoVital</c>
    /// Modela los signos vitales de la mascota
    /// </summary>
    
   // [Table("SignoVitalDb")]
   // 1 reference
    public class SignoVital
    {
     //   [Column("Id")]
     //   [Key]
     //   0 references
        // Identificador único de cada signo vital
        public int Id{ get; set; }
        
     //   [Required]
     //   [Column("Fecha")]
     //   [StringLength(12,MinimumLength=5)]
     //   0 references
        /// Fecha y hora en que se realizó la toma del signo vital 
        public DateTime FechaHora  { get; set; }
        
     //   [ForeignKey("EspecialidadVeterinario")]
     //   0 references
        /// Valor numérico del signo vital  
        public float Valor_signo {get;set;}
        
     //   [ForeignKey("EspecialidadVeterinario")]
     //   0 references
        /// Tipo de Signo vital medido
        public TipoSigno Signo { get; set; }
    }
}