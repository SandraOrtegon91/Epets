using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Epets.App.Dominio.Entidades
{
    /// <summary>Class <c>RecomendacionesCuidado</c>
    /// Modela las Recomendaciones de cuidado del la mascota
    /// </summary>   
    
    [Table("RecomendacionesDb")]
    public class RecomendacionesCuidado
    {
        [Column("Id")]
        [Key]
        // Identificador único de cada SugerenciaCuidado
        public int IdRecomendacion { get; set; }
        
        [Required(ErrorMessage = "Este dato es requerido")]
        [Column("Fecha")]
        [StringLength(12,MinimumLength=5)]
        // Fecha y hora en que se escribe la sugerencia
        public DateTime FechaHora  { get; set; }
        
        [Required]
        [Column("Sugerencias")]
        [StringLength(12,MinimumLength=5)]
        /// Texto con la sugerencia
        public string Descripcion {get;set;}
        
    }
}
