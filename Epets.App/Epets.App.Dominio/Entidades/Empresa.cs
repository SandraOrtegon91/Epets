using System;
using System.Collections.Generic;

namespace Epets.App.Dominio.Entidades
{
    public class Empresa
    {
        // Identificador único de la Empresa
        public int Id{ get; set; }
        //Nombre de la empresa
        public string Nombre { get; set; }
        //Nit de la empresa
        public int Nit { get; set; }
        //Direccion de la empresa
        public string Direccion { get; set; }

        ///  Referencia a la lista de Mascotas que puede tener un propietario

        public System.Collections.Generic.List<Medico> MedicosVinculados
        { get; set;
        }
    }
}
