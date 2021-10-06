using System.Collections.Generic;
using Epets.App.Dominio.Entidades;
using System;

namespace Epets.App.Persistencia.AppRepositorios
{
    public interface IRepositorioPropietario
    {
        //firma de los metodos

        //Metodo para retornar todas las propietarios
        IEnumerable<Propietario> GetAllPropietarios();

        //metodo para adicionar un propietario
        Propietario AddPropietario(Propietario propietario);

        //Metodo para Actualizar propietario
        Propietario UpdatePropietario(Propietario propietario);

        //Metodo para Eliminar propietario
        void DeletePropietario (int IdPropietario);

        //Metodo para retornar un propietario segun su Id
        Propietario GetPropietario(int IdPropietario);
    }
}