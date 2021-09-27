using System;
namespace Epets.App.Dominio.Entidades
{
     /// <summary>Class <c>Persona</c>
    /// Modela a la Persona con los atributos que comparten
    ///  en este caso son un Medico o un Propietario
    /// </summary>   
  
    public class Persona
    {
        //Datos de la persona
         // Identificador único de cada Persona
        public int Id{get;set;}
        //Cedula de la persona
        public string Cedula{get; set;}
        //Nombre de la Persona
        public string Nombre{get;set;}
        //Apellido de la Mascota
        public string Apellido{get;set;}
        //Telefono de la Persona
        public string Telefono{get;set;}
    }
}