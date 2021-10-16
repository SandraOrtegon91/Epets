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
    public class AgregarEmpresaModel : PageModel
    { 
        
        //Variable de tipo Interface
         //CONSTRUCTOR para inicializar IRepositorio
        
        
        private readonly IRepositorioEmpresa repositorioEmpresa;        
        
        //Variable que contiene la asignacion del metodo brascar medicos
        public Epets.App.Dominio.Entidades.Empresa Empresas{get;set;}
        public AgregarEmpresaModel(IRepositorioEmpresa repositorioEmpresa ){
            
            this.repositorioEmpresa=repositorioEmpresa;
            
        }

        
       
   
        //METODO DE INICIALIZACION DE LA PAGINA
        public async Task OnGet()
        {
            
                                  
        }
         
        public void OnPost(){

             Empresa empresa= new Empresa();
             
             empresa.NombreEmpresa=Empresas.NombreEmpresa;
             empresa.Nit=Empresas.Nit;
             empresa.DireccionEmpresa=Empresas.DireccionEmpresa;
             

             Empresas=repositorioEmpresa.AddEmpresa(empresa);

        }

        
    }
}
