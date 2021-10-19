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
    public class BuscarMedico2Model : PageModel
    {
         //Variable de tipo Interface
        private readonly IRepositorioMedico repositorioMedico;
        //Variable que contiene la asignacion del metodo brascar medicos
        public Epets.App.Dominio.Entidades.Medico Medicos{get;set;}

        //CONSTRUCTOR
        public BuscarMedico2Model(IRepositorioMedico repositorioMedico){
            
            this.repositorioMedico=repositorioMedico;
        }
   
        //METODO DE INICIALIZACION DE LA PAGINA
        public IActionResult OnGet(int Id)
        {
            Medicos=repositorioMedico.GetMedico(Id);

            if (Medicos==null){

                return RedirectToPage("/PaginaNoEncontrada");
            }
            else{
                
                return Page();
            }
                       
        }

        
    }
}
