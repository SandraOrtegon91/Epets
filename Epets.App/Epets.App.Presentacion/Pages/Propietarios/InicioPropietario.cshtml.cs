using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Epets.App.Persistencia.AppRepositorios;
using Epets.App.Dominio.Entidades;


namespace Epets.App.Presentacion.Pages
{
    public class InicioPropietarioModel : PageModel
    {
         //Variable de tipo Interface
        private readonly IRepositorioPropietario repositorioPropietario;
        //Variable que contiene la asignacion del metodo brascar medicos
        public IEnumerable<Epets.App.Dominio.Entidades.Propietario> Propietarios = new List<Epets.App.Dominio.Entidades.Propietario>();
        //METODO DE INICIALIZACION DE LA PAGINA
        public void OnGet()
        {
            Propietarios=repositorioPropietario.GetAllPropietarios().ToList(); 
                       
        }

        //constructor
        public InicioPropietarioModel(IRepositorioPropietario repositorioPropietario)
        {
            this.repositorioPropietario=repositorioPropietario;
        }
    }
}
