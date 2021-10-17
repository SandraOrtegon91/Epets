using System;
using System.Linq;
using System.Collections.Generic;
using Epets.App.Dominio.Entidades;
using Epets.App.Persistencia.AppData;

namespace Epets.App.Persistencia.AppRepositorios
{
    public class RepositorioPropietario:IRepositorioPropietario
{
        //Implementamos el metodo para IRepositorio
        public IEnumerable<Propietario> GetAllPropietarios()
        {
            //Cuerpo del Metodo
            //conexion
            using(AppData.MfAppContext Contexto= new AppData.MfAppContext()){

                //Consulta Linq
                var GetAllPropietarios=(from p in Contexto.Propietarios select p).ToList();
                return GetAllPropietarios;

            }


        }

        //Implementacion del metodo de esa interfaz
//buscar un medico por ID
        public Propietario GetPropietario(int Id){
            //conexion
             using(AppData.MfAppContext Contexto= new AppData.MfAppContext()){

                 //linq
                 //var Empresa=(from p in Contexto.empresa where p.IdEmpresa==IdEmpresa select p);
                 //return Empresa;

                 //sintaxis e-f
                 return Contexto.Propietarios.SingleOrDefault(s=>s.Id==Id);

             }
        } 

        public Propietario AddPropietario(Propietario propietario){
           using(AppData.MfAppContext Contexto= new AppData.MfAppContext()){

               Contexto.Propietarios.Add(propietario);
               Contexto.SaveChanges();
              
                   return propietario;              
           }

        }

        public Propietario UpdatePropietario (Propietario propietario){
            using(AppData.MfAppContext Contexto= new AppData.MfAppContext()){

               var ConsultaPropietario=Contexto.Propietarios.SingleOrDefault(s=>s.Id==propietario.Id);

               if (ConsultaPropietario!=null){
                   ConsultaPropietario.Direccion=propietario.Direccion;
                   
                   Contexto.SaveChanges();
                                      
               }
               return ConsultaPropietario;
            }
        }

       void IRepositorioPropietario.DeletePropietario(int Id)
        {
            using(AppData.MfAppContext Contexto= new AppData.MfAppContext()){

            var propietarioEncontrado=Contexto.Propietarios.FirstOrDefault(p => p.Id==Id);

            if (propietarioEncontrado==null)
                return ;
            
            Contexto.Propietarios.Remove(propietarioEncontrado);
            Contexto.SaveChanges();

        }}

      //
    }
}