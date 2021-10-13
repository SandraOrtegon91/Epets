using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        
        [Required(ErrorMessage = "Este dato es requerido")]
        [Column("Nombre")]
        [StringLength(50,MinimumLength=5)]
        //Nombre de la empresa
        public string Nombre { get; set; }
        
        [Required(ErrorMessage = "Este dato es requerido")]
        [Column("Nit")]
        //Nit de la empresa
        public int Nit { get; set; }
        
        [Required(ErrorMessage = "Este dato es requerido")]
        [Column("Direccion")]
        [StringLength(50,MinimumLength=5)]
        //Direccion de la empresa
        public string Direccion { get; set; }

        [ForeignKey("Medico")]
        //Relacion a la lista de Medicos con la empresa
        public System.Collections.Generic.List<Medico> MedicosVinculados{get;set;}
    }
}
