using System.Collections.Generic;
using Epets.App.Dominio.Entidades;
using System;

namespace Epets.App.Persistencia.AppRepositorios
{
    public interface IRepositorioMascota
    {
         //firma de los metodos

        //Metodo para retornar todas las mascotas
        IEnumerable<Mascota> GetAllMascota();

        //metodo para adicionar una mascotas
        Mascota AddMascota(Mascota mascota);

        //Metodo para Actualizar mascota
        Mascota UpdateMascota(Mascota mascota);

        //Metodo para Eliminar mascota
        void DeleteMascota (int IdMascota);

        //Metodo para retornar una mascota segun su Id
        Mascota GetMascota(int IdMascota);
    }
}