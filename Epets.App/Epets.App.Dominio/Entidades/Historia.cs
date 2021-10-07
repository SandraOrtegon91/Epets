using System;
using System.Collections.Generic;
namespace Epets.App.Dominio.Entidades
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
{
   /// <summary>Class <c>Historia</c>
    /// Modela la Historia clínica relacionada con la atencion de la Mascota
    /// </summary>    
    
  //  [Table("Historia")]
    public class Historia
    {
    //    [Column("Id")]
    //    [Key]
        // Identificador único de la Historia
        public int Id { get; set; }
        
    //    [Required]
    //    [Column("DateTime")]
    //    [StringLength(12,MinimumLength=6)]
        public DateTime FechaVisita{get;set;} //DateTime
        
    //    [Required]
    //    [Column("Recomendaciones")]
    //    [StringLength(50,MinimumLength=5)]
     //   public string Recomendaciones{get;set;}
        
    //    [Required]
    //    [Column("Medicamento")]
    //    [StringLength(20,MinimumLength=5)]
        public string Medicamento{get;set;}
        
    //    [ForeignKey("SignoVital")]
        public SignoVital Signos{get;set;}
        
    //    [ForeignKey("SignoVitale")]
        //Referencia a la lista de signos vitales de una mascota
        public System.Collections.Generic.List<SignoVital> SignosVitales { get; set; }
        
        // Referencia la lista de sugerencias registradas en la Historia del Paciente
        public System.Collections.Generic.List<RecomendacionesCuidado> Recomendaciones { get; set; }
    }
}
