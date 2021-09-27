using System;
namespace Epets.App.Dominio.Entidades
{
    /// <summary>Class <c>RecomendacionesCuidado</c>
    /// Modela las Recomendaciones de cuidado del la mascota
    /// </summary>   
    public class RecomendacionesCuidado
    {
        // Identificador único de cada SugerenciaCuidado
        public int Id { get; set; }
        /// Fecha y hora en que se escribe la sugerencia
        public DateTime FechaHora  { get; set; }
         /// Texto con la sugerencia
        public string Descripcion {get;set;}
        
    }
}