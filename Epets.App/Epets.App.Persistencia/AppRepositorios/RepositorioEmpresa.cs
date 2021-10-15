using System;
using System.Linq;
using System.Collections.Generic;
using Epets.App.Dominio.Entidades;
using Epets.App.Persistencia.AppData;

namespace Epets.App.Persistencia.AppRepositorios
{
    public class RepositorioEmpresa : IRepositorioEmpresa
    {
         //Implementamos el metodo para IRepositorio
        public IEnumerable<Empresa> GetAllEmpresas()
        {
            //Cuerpo del Metodo
            //conexion
            using(AppData.MfAppContext Contexto= new AppData.MfAppContext()){

                //Consulta Linq
                var GetAllEmpresas=(from p in Contexto.Empresas select p).ToList();
                return GetAllEmpresas;

            }


        }

        //Implementacion del metodo de esa interfaz

        public  Empresa GetEmpresa(int IdEmpresa){
            //conexion
             using(AppData.MfAppContext Contexto= new AppData.MfAppContext()){

                 //linq
                 //var Empresa=(from p in Contexto.empresa where p.IdEmpresa==IdEmpresa select p);
                 //return Empresa;

                 //sintaxis e-f
                 return Contexto.Empresas.SingleOrDefault(s=>s.IdEmpresa==IdEmpresa);

             }
        } 

        public Empresa AddEmpresa(Empresa empresa){
           using(AppData.MfAppContext Contexto= new AppData.MfAppContext()){

               Contexto.Empresas.Add(empresa);
               Contexto.SaveChanges();
              
                   return empresa;              
           }

        }

        public Empresa UpdateEmpresa(Empresa empresa){
            using(AppData.MfAppContext Contexto= new AppData.MfAppContext()){

               var ConsultaEmpresa=Contexto.Empresas.SingleOrDefault(s=>s.IdEmpresa==empresa.IdEmpresa);

               if (ConsultaEmpresa!=null){
                   ConsultaEmpresa.NombreEmpresa=empresa.NombreEmpresa;
                   ConsultaEmpresa.Nit=empresa.Nit;
                   ConsultaEmpresa.DireccionEmpresa=empresa.DireccionEmpresa;
                   Contexto.SaveChanges();
                                      
               }
               return ConsultaEmpresa;
            }
        }

        public bool DeleteEmpresa (int IdEmpresa){
            return true;            
        }
      //
    }
}