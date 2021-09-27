using System;
using System.Collections.Generic;
namespace Epets.App.Dominio.Entidades
{
   /// <summary>Class <c>Historia</c>
    /// Modela la Historia clínica relacionada con la atencion de la Mascota
    /// </summary>    
  
    public class Historia
    {
        // Identificador único de la Historia
        
        public int Id { get; set; }
       
        public DateTime FechaVisita{get;set;} //DateTime
        //public string Recomendaciones{get;set;}
        public string Medicamento{get;set;}
        //public SignoVital Signos{get;set;}
        
        //  Referencia a la lista de signos vitales de una mascota
        public System.Collections.Generic.List<SignoVital> SignosVitales { get; set; }
        /// Referencia la lista de sugerencias registradas en la Historia del Paciente
        public List<RecomendacionesCuidado> Recomendaciones { get; set; }
    }
}