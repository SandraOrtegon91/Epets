using System;
namespace Epets.App.Dominio.Entidades
{
    /// <summary>Class <c>SignoVital</c>
    /// Modela los signos vitales de la mascota
    /// </summary>
    public class SignoVital
    {
         // Identificador único de cada signo vital
        public int Id{ get; set; }
        /// Fecha y hora en que se realizó la toma del signo vital 
        public DateTime FechaHora  { get; set; }
         /// Valor numérico del signo vital  
        public float Valor_signo {get;set;}
        /// Tipo de Signo vital medido
        public TipoSigno Signo { get; set; }
    }
}