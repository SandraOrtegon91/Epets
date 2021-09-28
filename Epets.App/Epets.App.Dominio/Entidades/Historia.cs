using System;
using System.Collections.Generic;
namespace Epets.App.Dominio.Entidades
{
   /// <summary>Class <c>Historia</c>
    /// Modela la Historia clínica relacionada con la atencion de la Mascota
    /// </summary>    
    
    [Table("Historia")]
    1 reference
    public class Historia
    {
        [Column("Id")]
        [Key]
        0 references
        // Identificador único de la Historia
        public int Id { get; set; }
        
        [Required]
        [Column("DateTime")]
        [StringLength(12,MinimumLength=6)]
        0 references
        public DateTime FechaVisita{get;set;} //DateTime
        
        [Required]
        [Column("Recomendaciones")]
        [StringLength(50,MinimumLength=5)]
        0 references
        public string Recomendaciones{get;set;}
        
        [Required]
        [Column("Medicamento")]
        [StringLength(20,MinimumLength=5)]
        0 references
        public string Medicamento{get;set;}
        
        [ForeignKey("SignoVital")]
        0 references
        public SignoVital Signos{get;set;}
        
        [ForeignKey("SignoVitale")]
        0 references
        //Referencia a la lista de signos vitales de una mascota
        public System.Collections.Generic.List<SignoVital> SignosVitales { get; set; }
        
        // Referencia la lista de sugerencias registradas en la Historia del Paciente
        public List<RecomendacionesCuidado> Recomendaciones { get; set; }
    }
}