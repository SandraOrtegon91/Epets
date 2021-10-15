using System.Collections.Generic;
using Epets.App.Dominio.Entidades;
using System;

namespace Epets.App.Persistencia.AppRepositorios
{
    public interface IRepositorioMedico
    {
        #region  Firma metodos Medicos
         //firma de los metodos

        //Metodo para retornar todos los medicos
        IEnumerable<Medico> GetAllMedicos();

        //Metodo para retornar un medico segun su Id
        Medico GetMedico(int Id);

        //metodo para adicionar un medico
        Medico AddMedico(Medico medico);

        //Metodo para Actualizar medico
        Medico UpdateMedico(Medico medico);

        //Metodo para Eliminar medico
        void DeleteMedico (int Id);

        #endregion

    }
}