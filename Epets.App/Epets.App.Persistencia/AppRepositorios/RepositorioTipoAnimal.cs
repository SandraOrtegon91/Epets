using System;
using System.Linq;
using System.Collections.Generic;
using Epets.App.Dominio.Entidades;
using Epets.App.Persistencia.AppData;


namespace Epets.App.Persistencia.AppRepositorios
{
    public class RepositorioTipoAnimal:IRepositorioTipoAnimal
    {
         //Implementamos el metodo para IRepositorio
        public IEnumerable<Epets.App.Dominio.Entidades.TipoAnimal> GetAllTipoAnimales()
        {
            //Cuerpo del Metodo
            //conexion
            using(AppData.MfAppContext Contexto= new AppData.MfAppContext()){

                //Consulta Linq
                var GetAllTipoAnimales=(from p in Contexto.TipoAnimales select p).ToList();
                return GetAllTipoAnimales;

            }


        }

        //Implementacion del metodo de esa interfaz

        public  TipoAnimal GetTipoAnimal(int IdAnimal){
            //conexion
             using(AppData.MfAppContext Contexto= new AppData.MfAppContext()){

                 //linq
                 //var Empresa=(from p in Contexto.empresa where p.IdEmpresa==IdEmpresa select p);
                 //return Empresa;

                 //sintaxis e-f
                 return Contexto.TipoAnimales.SingleOrDefault(s=>s.IdAnimal==IdAnimal);

             }
        } 

        public TipoAnimal AddTipoAnimal(TipoAnimal tipoAnimal){
           using(AppData.MfAppContext Contexto= new AppData.MfAppContext()){

               Contexto.TipoAnimales.Add(tipoAnimal);
               Contexto.SaveChanges();
              
                   return tipoAnimal;              
           }

        }

        public TipoAnimal UpdateTipoAnimal(TipoAnimal tipoAnimal){
            using(AppData.MfAppContext Contexto= new AppData.MfAppContext()){

               var ConsultaTipoAnimal=Contexto.TipoAnimales.SingleOrDefault(s=>s.IdAnimal==tipoAnimal.IdAnimal);

               if (ConsultaTipoAnimal!=null){
                   ConsultaTipoAnimal.T_Animal=tipoAnimal.T_Animal;
                   
                   Contexto.SaveChanges();
                                      
               }
               return ConsultaTipoAnimal;
            }
        }

        public bool DeleteTipoAnimal (int IdAnimal){
            return true;            
        }
      //
    }
}