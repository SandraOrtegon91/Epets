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
    public class BuscarEmpresaModel : PageModel
    {
        
         //Variable de tipo Interface
        private readonly IRepositorioEmpresa repositorioEmpresa;
        //Variable que contiene la asignacion del metodo brascar medicos
        public Epets.App.Dominio.Entidades.Empresa Empresas{get;set;}

        //CONSTRUCTOR
        public BuscarEmpresaModel(IRepositorioEmpresa repositorioEmpresa){
            
            this.repositorioEmpresa=repositorioEmpresa;
        }
   
        //METODO DE INICIALIZACION DE LA PAGINA
        public IActionResult OnGet(int IdEmpresa)
        {
            Empresas=repositorioEmpresa.GetEmpresa(IdEmpresa);

            if (Empresas==null){

                return RedirectToPage("/PaginaNoEncontrada");
            }
            else{
                
                return Page();
            }
                       
        }

        
    }
}

