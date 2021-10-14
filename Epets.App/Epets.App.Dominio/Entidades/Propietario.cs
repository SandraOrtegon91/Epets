using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Epets.App.Dominio.Entidades
{
    /// <summary>Class <c>Propietario</c>
    /// Modela al propietario de la Mascota
    /// </summary>   

    [Table("PropietariosDb")]
    public class Propietario : Persona
    {
        [Required]
        [Column("Direccion")]
        [StringLength(50,MinimumLength=5)]
        //Direccion unica del Propietario
        public string Direccion{get;set;}
    }
}
