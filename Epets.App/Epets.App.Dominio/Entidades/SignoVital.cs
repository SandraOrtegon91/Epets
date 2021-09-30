using System;
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
        public int Id{ get; set; }
        
        [Required]
        [Column("Fecha")]
        [StringLength(12,MinimumLength=5)]
        /// Fecha y hora en que se realizó la toma del signo vital 
        public DateTime FechaHora  { get; set; }
        
        [ForeignKey("EspecialidadVeterinario")]
        /// Valor numérico del signo vital  
        public float Valor_signo {get;set;}
        
        [ForeignKey("EspecialidadVeterinario")]
        /// Tipo de Signo vital medido
        public TipoSigno Signo { get; set; }
    }
}