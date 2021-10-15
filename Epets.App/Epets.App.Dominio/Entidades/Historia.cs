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
        
        [Required]
        [Column("DateTime")]
        [StringLength(12,MinimumLength=6)]
        public DateTime FechaVisita{get;set;} //DateTime
        
        [Required]
        [Column("Recomendaciones")]
        [StringLength(50,MinimumLength=5)]
        public string Recomendaciones{get;set;}
        
        [Required]
        [Column("Medicamento")]
        [StringLength(20,MinimumLength=5)]
        public string Medicamento{get;set;}

         [ForeignKey("IdMascota")]
        // Relacion entre Mascota y su Historia clínica
        public virtual Mascota Mascota { get; set; }
                
        [ForeignKey("IdTipoSigno")]
        //Referencia a la lista de signos vitales de una mascota
        public virtual System.Collections.Generic.List<TipoSigno> TipoSigno { get; set; }
    }
}
