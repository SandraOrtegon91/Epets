using System;
namespace Epets.App.Dominio.Entidades
{
    /// <summary>Class <c>Mascota</c>
    /// Modela la Mascota que es atendido por visita domiciliaria 
    /// por un Medico veterinario
    /// </summary>   
    public class Mascota
    {
        //Datos Mascota
         // Identificador único de cada Mascota
        public int Id{get;set;}
        //Nombre de La Mascota
        public string NombreMascota{get;set;}
        //Color de Ojos de la Mascota
        public string ColorOjos{get;set;}
        //Color del pelaje o plumaje de la Mascota
        public string ColorPiel{get;set;}
        //Estatura de la Mascota
        public float Estatura{get;set;}
        //Raza de la mascota
        public string Raza{get;set;}
        /// Relacion entre el propietario y la Mascota
        public Propietario Propietario{get;set;}
        /// Relacion entre el Medico y la Mascota
        public Medico Medico{get;set;}
        /// Relacion entre el Tipo de Animal y la Mascota
        public TipoAnimal TipoAnimal{get;set;}
         /// Relacion entre Mascota y su Historia clínica
        public Historia Historia{get;set;}
    }
}