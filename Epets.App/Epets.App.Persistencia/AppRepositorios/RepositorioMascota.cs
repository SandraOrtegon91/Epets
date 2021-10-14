using System.Linq;
using System.Collections.Generic;
using Epets.App.Dominio.Entidades;
//using Epets.App.Persistencia.AppData;

namespace Epets.App.Persistencia.AppRepositorios
{
    public class RepositorioMascota :IRepositorioMascota
 {
        /// <summary>
        /// Referencia al contexto de la Mascota
        /// </summary>
        private readonly Epets.App.Persistencia.AppData.MfAppContext _appContext;

        /// <summary>Metodo constructor
        /// que utiliza la inyeccion de dependencias
        /// para indicar el contexto a utilizar </summary>
        /// <param name="appContext"></param>
  
        public RepositorioMascota(Epets.App.Persistencia.AppData.MfAppContext appContext)
        {
            _appContext=appContext;
        } 

        //implementacion de los metodos de la interfaz
        //Implementacion metodo Añadir Mascota
        Mascota IRepositorioMascota.AddMascota(Mascota mascota)
        {
            var mascotaAdicionada=_appContext.Mascotas.Add(mascota);
            _appContext.SaveChanges();
            return mascotaAdicionada.Entity;
        }

        //Implementacion metodo Eliminar una Mascota 
        void IRepositorioMascota.DeleteMascota(int IdMascota)
        {
            var mascotaEncontrada=_appContext.Mascotas.FirstOrDefault(p => p.IdMascota==IdMascota);

            if (mascotaEncontrada==null)
                return ;
            
            _appContext.Mascotas.Remove(mascotaEncontrada);
            _appContext.SaveChanges();

        }

        //Implementacion metodo retornar todas las Mascotas
        IEnumerable<Mascota> IRepositorioMascota.GetAllMascotas()
        {
            return _appContext.Mascotas;

        }

        //Implementacion metodo Retornar una Mascota
        Mascota IRepositorioMascota.GetMascota(int IdMascota)
        {
            return _appContext.Mascotas.FirstOrDefault(p => p.IdMascota==IdMascota);

        }

        //Implementacion metodo Actualizar Mascota
        Mascota IRepositorioMascota.UpdateMascota(Mascota mascota)
        {
            var mascotaEncontrada=_appContext.Mascotas.FirstOrDefault(p => p.IdMascota==mascota.IdMascota);

            if (mascotaEncontrada!=null)
                {
                    mascotaEncontrada.NombreMascota=mascota.NombreMascota;
                    mascotaEncontrada.ColorOjos=mascota.ColorOjos;
                    mascotaEncontrada.ColorPiel=mascota.ColorPiel;
                    mascotaEncontrada.Estatura=mascota.Estatura;
                    mascotaEncontrada.Raza=mascota.Raza;
                    _appContext.SaveChanges();                   
                }            
            return mascotaEncontrada;
        }
    }
}
