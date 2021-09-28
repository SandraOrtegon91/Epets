using System;
namespace Epets.App.Dominio.Entidades
{
    /// <summary>Class <c>RecomendacionesCuidado</c>
    /// Modela las Recomendaciones de cuidado del la mascota
    /// </summary>   
    
    [Table("RecomendacionesDb")]
    1 reference
    public class RecomendacionesCuidado
    {
        [Column("Id")]
        [Key]
        0 references
        // Identificador único de cada SugerenciaCuidado
        public int Id { get; set; }
        
        [Required]
        [Column("Fecha")]
        [StringLength(12,MinimumLength=5)]
        0 references
        /// Fecha y hora en que se escribe la sugerencia
        public DateTime FechaHora  { get; set; }
        
        [ForeignKey("Sugerencias")]
        0 references
        /// Texto con la sugerencia
        public string Descripcion {get;set;}
        
    }
}