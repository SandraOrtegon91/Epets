using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
namespace Epets.App.Dominio
{
    [Table("TipoAnimalDb")]
    public class TipoAnimal
    {
        [Key]
        [Column("Id")]
        public int IdAnimal { get; set; }

        [Required]
        [Column("T_Animal")]
        [StringLength(10,MinimumLength=5)]
        //Referencia la especialidad del tipo de animal
        public string T_Animal{ get; set; }
    }
}