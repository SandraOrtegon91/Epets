using System.Collections.Generic;
using Epets.App.Dominio.Entidades;
using System;

namespace Epets.App.Persistencia.AppRepositorios
{
    public interface IRepositorioHistoria
    {
         //firma de los metodos

        //Metodo para retornar todas las historias
        IEnumerable<Historia> GetAllHistorias();

        //metodo para adicionar una historia
        Historia AddHistoria(Historia historia);

        //Metodo para Actualizar Historia
        Historia UpdatePersona(Historia historia);

        //Metodo para Eliminar Historia
        void DeleteHistoria (int IdHistoria);

        //Metodo para retornar una historia segun su Id
        Historia GetHistoria(int IdHistoria);
    }
}