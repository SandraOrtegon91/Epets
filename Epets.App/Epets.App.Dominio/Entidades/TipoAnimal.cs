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


        [Column("Nombre")]
        [Required]
        [StringLength(50,MinimumLength=5)]
        public string Nombre { get; set; }

    }
}