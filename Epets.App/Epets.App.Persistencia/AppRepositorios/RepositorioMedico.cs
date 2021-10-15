using System;
using System.Linq;
using System.Collections.Generic;
using Epets.App.Dominio.Entidades;
using Epets.App.Persistencia.AppData;

namespace Epets.App.Persistencia.AppRepositorios
{
    public class RepositorioMedico :IRepositorioMedico
    
     {
         //Implementamos el metodo para IRepositorio
        public IEnumerable<Medico> GetAllMedicos()
        {
            //Cuerpo del Metodo
            //conexion
            using(AppData.MfAppContext Contexto= new AppData.MfAppContext()){

                //Consulta Linq
                var GetAllMedicos=(from p in Contexto.Medicos select p).ToList();
                return GetAllMedicos;

            }


        }

        //Implementacion del metodo de esa interfaz
//buscar un medico por ID
        public  Medico GetMedico(int Id){
            //conexion
             using(AppData.MfAppContext Contexto= new AppData.MfAppContext()){

                 //linq
                 //var Empresa=(from p in Contexto.empresa where p.IdEmpresa==IdEmpresa select p);
                 //return Empresa;

                 //sintaxis e-f
                 return Contexto.Medicos.SingleOrDefault(s=>s.Id==Id);

             }
        } 

        public Medico AddMedico(Medico medico){
           using(AppData.MfAppContext Contexto= new AppData.MfAppContext()){

               Contexto.Medicos.Add(medico);
               Contexto.SaveChanges();
              
                   return medico;              
           }

        }

        public Medico UpdateMedico(Medico medico){
            using(AppData.MfAppContext Contexto= new AppData.MfAppContext()){

               var ConsultaMedico=Contexto.Medicos.SingleOrDefault(s=>s.Id==medico.Id);

               if (ConsultaMedico!=null){
                   ConsultaMedico.TarjetaProfesional=medico.TarjetaProfesional;
                   
                   Contexto.SaveChanges();
                                      
               }
               return ConsultaMedico;
            }
        }

       void IRepositorioMedico.DeleteMedico(int Id)
        {
            using(AppData.MfAppContext Contexto= new AppData.MfAppContext()){

            var medicoEncontrado=Contexto.Medicos.FirstOrDefault(p => p.Id==Id);

            if (medicoEncontrado==null)
                return ;
            
            Contexto.Medicos.Remove(medicoEncontrado);
            Contexto.SaveChanges();

        }}

      //
    }
}