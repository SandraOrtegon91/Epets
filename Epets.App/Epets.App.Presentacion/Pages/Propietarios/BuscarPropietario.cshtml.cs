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
    public class BuscarPropietarioModel : PageModel
    {
        
        
         //Variable de tipo Interface
        private readonly IRepositorioPropietario repositorioPropietario;
        //Variable que contiene la asignacion del metodo brascar medicos
        public Epets.App.Dominio.Entidades.Propietario Propietarios{get;set;}

        //CONSTRUCTOR
        public BuscarPropietarioModel(IRepositorioPropietario repositorioPropietario){
            
            this.repositorioPropietario=repositorioPropietario;
        }
   
        //METODO DE INICIALIZACION DE LA PAGINA
        public IActionResult OnGet(int Id)
        {
            Propietarios=repositorioPropietario.GetPropietario(Id);

            if (Propietarios==null){

                return RedirectToPage("/PaginaNoEncontrada");
            }
            else{
                
                return Page();
            }
                       
        }

        
    }
}
