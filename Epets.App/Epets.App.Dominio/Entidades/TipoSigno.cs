using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Epets.App.Dominio.Entidades
{
     /// <summary>
    /// Lista de Signos vitales
    /// </summary> 

    public class TipoSigno//clase por enum
    {
        public int Temperatura{get;set;}
        public int Peso{get;set;}
        public int Freuencia_Cardiaca{get;set;}
        public int Frecuencia_Respiratoria{get;set;}
        public string EstadoAnimo{get;set;}
    }
}
