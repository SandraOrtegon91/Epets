using System.Collections.Generic;
using Epets.App.Dominio.Entidades;
using System;

namespace Epets.App.Persistencia.AppRepositorios
{
    public interface IRepositorioEmpresa
    {
        //firma de los metodos

        //Metodo para retornar todas las empresas
        IEnumerable<Empresa> GetAllEmpresas();

        //metodo para adicionar una empresa
        Empresa AddEmpresa(Empresa empresa);

        //Metodo para Actualizar Empresa
        Empresa UpdateEmpresa(Empresa empresa);

        //Metodo para Eliminar Empresa
        void DeleteEmpresa (int IdEmpresa);

        //Metodo para retornar una Empresa segun su Id
        Empresa GetEmpresa(int IdEmpresa);        
    }
}