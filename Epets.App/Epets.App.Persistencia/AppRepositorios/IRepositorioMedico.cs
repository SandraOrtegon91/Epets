using System.Collections.Generic;
using Epets.App.Dominio.Entidades;
using System;

namespace Epets.App.Persistencia.AppRepositorios
{
    public interface IRepositorioMedico
    {
        //firma de los metodos

        //Metodo para retornar todas los Medicos
        IEnumerable<Medico> GetAllMedicos();

        //metodo para adicionar un Medico
        Medico AddMedico(Medico medico);

        //Metodo para Actualizar Medico
        Medico UpdateMedico(Medico medico);

        //Metodo para Eliminar Medico
        void DeleteMedico (int IdMedico);

        //Metodo para retornar un Medico segun su Id
        Medico GetMedico(int IdMedico);


        
    }
}