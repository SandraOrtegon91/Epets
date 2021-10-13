using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
namespace Epets.App.Dominio.Entidades
{
    /// <summary>Class <c>Empresa</c>
    /// Modela una empresa Veterinaria que tiene medicos veterinarios
    /// </summary>

    [Table("EmpresaDb")]
    public class Empresa
    
    {
        [Column("Id")]
        [Key]
        //Identificador único de la Empresa
        public int Id{ get; set; }
        
        [Required]
        [Column("Nombre")]
        [StringLength(50,MinimumLength=5)]
        //Nombre de la empresa
        public string Nombre { get; set; }
        
        [Required]
        [Column("Nit")]
        //Nit de la empresa
        public int Nit { get; set; }
        
        [Required]
        [Column("Direccion")]
        [StringLength(50,MinimumLength=5)]
        //Direccion de la empresa
        public string Direccion { get; set; }

        [ForeignKey("IdMedico")]
        //Relacion a la lista de Medicos con la empresa
        //public System.Collections.Generic.List<Medico> MedicosVinculados{get;set;}
        public virtual Medico Medico { get; set; }
    }
}
