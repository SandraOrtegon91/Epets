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
    public class AgregarMedicoModel : PageModel
    {
         //Variable de tipo Interface
         //CONSTRUCTOR para inicializar IRepositorio

        
        private readonly IRepositorioMedico repositorioMedico;
        //Variable que contiene la asignacion del metodo brascar medicos
        public Epets.App.Dominio.Entidades.Medico Medicos{get;set;}

        public AgregarMedicoModel(IRepositorioMedico repositorioMedico){
            
            this.repositorioMedico=repositorioMedico;
        }
       
   
        //METODO DE INICIALIZACION DE LA PAGINA
        public void OnGet()
        {
                                  
        }
         
        public void OnPost(){

             Medico medico= new Medico();
             medico.Cedula=Medicos.Cedula;
             medico.Nombre=Medicos.Nombre;
             medico.Apellido=Medicos.Apellido;
             medico.Telefono=Medicos.Telefono;
             medico.TarjetaProfesional=Medicos.TarjetaProfesional;

             Medicos=repositorioMedico.AddMedico(medico);

        }

        
    }
}
