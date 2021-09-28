using System.Collections.Generic;
using Epets.App.Dominio.Entidades;
using System;

namespace Epets.App.Persistencia.AppRepositorios
{
    public interface IRepositorioMedico
    {
<<<<<<< HEAD
         //firma de los metodos

        //Metodo para retornar todos los medicos
        IEnumerable<Medico> GetAllMedicos();

        //metodo para adicionar un medico
        Medico AddMedico(Medico medico);

        //Metodo para Actualizar medico
        Medico UpdateMedico(Medico medico);

        //Metodo para Eliminar medico
        void DeleteMedico (int IdMedico);

        //Metodo para retornar un medico segun su Id
        Medico GetMedico(int IdMedico);
=======
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


        
>>>>>>> 6b888e9a381ca3ce051ea91e26f7b3ca847bed2a
    }
}