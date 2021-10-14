using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Epets.App.Dominio.Entidades
{
     /// <summary>
    /// Lista de Signos vitales
    /// </summary> 

    [Table("TipoSignoDb")]
    public class TipoSigno//clase por enum
    {
        [Key]
        [Column("Id")]
        public int IdTipoSigno { get; set; }

        [Required]
        [Column("Temperatura")]
        public int Temperatura{ get; set; }

        [Required]
        [Column("Peso")]
        public int Peso{ get; set; }

        [Required]
        [Column("FrecuenciaCardiaca")]
        public int Freuencia_Cardiaca{ get; set; }

        [Required]
        [Column("FrecuenciaRespiratoria")]
        public int Frecuencia_Respiratoria{get;set;}

        [Required]
        [Column("EstadoAnimo")]
        [StringLength(10,MinimumLength=5)]
        public string EstadoAnimo{ get; set; }
    }
}
