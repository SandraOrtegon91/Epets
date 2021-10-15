using System.Collections.Generic;
using Epets.App.Dominio.Entidades;
using System;

namespace Epets.App.Persistencia.AppRepositorios
{
    public interface IRepositorioEmpresa
    {
        #region  Firma metodos Empresa
        //firma de los metodos

        //Metodo para retornar todas las empresas
        IEnumerable<Empresa> GetAllEmpresas();

              //Metodo para retornar una Empresa segun su Id
        Empresa GetEmpresa(int IdEmpresa); 

        //metodo para adicionar una empresa
        Empresa AddEmpresa(Empresa empresa);

        //Metodo para Actualizar Empresa
        Empresa UpdateEmpresa(Empresa empresa);

        //Metodo para Eliminar Empresa
        bool DeleteEmpresa (int IdEmpresa);

        #endregion

         
    }
}