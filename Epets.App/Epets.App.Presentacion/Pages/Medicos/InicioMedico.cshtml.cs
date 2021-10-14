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
    public class InicioMedicoModel : PageModel
    {
        private readonly IRepositorioMedico repositorio;

        //METODO DE INICIALIZACION DE LA PAGINA
        public void OnGet()
        {
            List<medico>=repositorio.GetAllMedicos();
        }

        public InicioMedicoModel(IRepositorioMedico repositorio){

            this.repositorio=repositorio;

        }
    }
}
