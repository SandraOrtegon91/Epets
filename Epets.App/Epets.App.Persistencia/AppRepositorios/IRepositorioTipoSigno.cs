using System.Collections.Generic;
using Epets.App.Dominio.Entidades;
using System;

namespace Epets.App.Persistencia.AppRepositorios
{
    public interface IRepositorioTipoSigno
    {
         //firma de los metodos

        //Metodo para retornar todas los Tipo de Signos
        IEnumerable<TipoSigno> GetAllTipoSignos();

        //metodo para adicionar los Tipos de Signos
        TipoSigno AddTipoSigno(TipoSigno tipoSigno);

        //Metodo para Actualizar TipoSigno
        TipoSigno UpdateTipoSigno(TipoSigno tipoSigno);

        //Metodo para Eliminar TipoSigno
        void DeleteTipoSigno (int IdTipoSigno);

        //Metodo para retornar un TipoSigno segun su Id
        TipoSigno GetTipoSigno(int IdTipoSigno);
    }
}