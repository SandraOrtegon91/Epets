using System.Collections.Generic;
using Epets.App.Dominio.Entidades;
using System;

namespace Epets.App.Persistencia.AppRepositorios
{
    public interface IRepositorioPropietario
    {
        #region  Firma metodos Propietarios
         //firma de los metodos

        //Metodo para retornar todos los medicos
        IEnumerable<Propietario> GetAllPropietarios();

        //Metodo para retornar un medico segun su Id
        Propietario GetPropietario(int Id);

        //metodo para adicionar un medico
        Propietario AddPropietario(Propietario propietario);

        //Metodo para Actualizar medico
        Propietario UpdatePropietario(Propietario propietario);

        //Metodo para Eliminar medico
        void DeletePropietario (int Id);

        #endregion

    }
}