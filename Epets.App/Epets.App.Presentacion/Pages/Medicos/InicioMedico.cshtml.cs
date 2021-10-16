using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Epets.App.Persistencia.AppRepositorios;
using Epets.App.Dominio.Entidades;

namespace Epets.App.Presentacion.Pages
//Pagina que Muestra la lista de todos los medicos
{    public class InicioMedicoModel : PageModel
    {
        //Variable de tipo Interface
        private readonly IRepositorioMedico repositorioMedico;
        //Variable que contiene la asignacion del metodo brascar medicos
        public IEnumerable<Epets.App.Dominio.Entidades.Medico> Medicos = new List<Epets.App.Dominio.Entidades.Medico>();
        //METODO DE INICIALIZACION DE LA PAGINA
        public void OnGet()
        {
            Medicos=repositorioMedico.GetAllMedicos().ToList(); 
                       
        }
        

        //constructor
        public InicioMedicoModel(IRepositorioMedico repositorioMedico)
        {
            this.repositorioMedico=repositorioMedico;
        }
    }
}
