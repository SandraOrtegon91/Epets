using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Epets.App.Dominio.Entidades
{
    /// <summary>Class <c>Historia</c>
    /// Modela la Historia clínica relacionada con la atencion de la Mascota
    /// </summary>    
    
    [Table("Historia")]
    public class Historia
    {
        [Column("Id")]
        [Key]
        // Identificador único de la Historia
        public int IdHistoria { get; set; }
        
        [Required(ErrorMessage = "Este dato es requerido")]
        [Column("DateTime")]
        [StringLength(12,MinimumLength=6)]
        public DateTime FechaVisita{get;set;} //DateTime
        
        [Required(ErrorMessage = "Este dato es requerido")]
        [Column("Recomendaciones")]
        [StringLength(50,MinimumLength=5)]
        public string Recomendaciones{get;set;}
        
        [Required(ErrorMessage = "Este dato es requerido")]
        [Column("Medicamento")]
        [StringLength(20,MinimumLength=5)]
        public string Medicamento{get;set;}
        
        
        [ForeignKey("SignoVital")]
        public SignoVital Signos{get;set;}
        
        [ForeignKey("SignoVital")]
        //Referencia a la lista de signos vitales de una mascota
        public System.Collections.Generic.List<SignoVital> SignosVitales { get; set; }

        [ForeignKey("RecomendacionesCuidado")]
        // Referencia la lista de sugerencias registradas en la Historia del Paciente
        public List<RecomendacionesCuidado> RecomendacionesCuidados { get; set; }
    }
}
