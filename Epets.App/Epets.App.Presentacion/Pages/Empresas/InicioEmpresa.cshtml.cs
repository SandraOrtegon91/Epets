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
    public class InicioEmpresaModel : PageModel
    {
        
        
        //Variable de tipo Interface
        private readonly IRepositorioEmpresa repositorioEmpresa;
        //Variable que contiene la asignacion del metodo brascar medicos
         public IEnumerable<Epets.App.Dominio.Entidades.Empresa> Empresas = new List<Epets.App.Dominio.Entidades.Empresa>();
        
        //METODO DE INICIALIZACION DE LA PAGINA
        public void OnGet()
        {
            Empresas=repositorioEmpresa.GetAllEmpresas().ToList(); 
                       
        }
        

        //constructor
        public InicioEmpresaModel(IRepositorioEmpresa repositorioEmpresa)
        {
            this.repositorioEmpresa=repositorioEmpresa;
        }
    }
}
