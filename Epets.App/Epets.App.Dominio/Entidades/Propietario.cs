using System;
using System.Collections.Generic;
namespace Epets.App.Dominio.Entidades
{
     /// <summary>Class <c>Propietario</c>
    /// Modela al propietario de la Mascota
    /// </summary>   
  
    public class Propietario : Persona
    {
        //Datos del Propietario de la mascota
      //  public int IdPropietario{get;set;}
      //Direccion del Propietario
        public string Direccion{get;set;}
        ///  Referencia a la lista de Solicitud de visita  
        public System.Collections.Generic.List<SolicitudVisita> SolicitudVisita{get;set;}
        ///  Referencia a la lista de Mascotas que puede tener un propietario  
        public System.Collections.Generic.List<Mascota> MascotasPropietario { get; set; }
    }
}