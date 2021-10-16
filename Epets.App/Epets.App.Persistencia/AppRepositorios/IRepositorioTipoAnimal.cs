using System.Collections.Generic;
using Epets.App.Dominio.Entidades;
using System;

namespace Epets.App.Persistencia.AppRepositorios
{
    public interface IRepositorioTipoAnimal
    {
         
          #region  Firma metodos Tipo Animal
        //firma de los metodos

        //Metodo para retornar todas los tipos de Animal
        IEnumerable<TipoAnimal> GetAllTipoAnimales();

              //Metodo para retornar un Tipo Animal segun su Id
        TipoAnimal GetTipoAnimal(int IdAnimal); 

        //metodo para adicionar una empresa
        TipoAnimal AddTipoAnimal(TipoAnimal tipoAnimal);

        //Metodo para Actualizar Empresa
        TipoAnimal UpdateTipoAnimal(TipoAnimal tipoAnimal);

        //Metodo para Eliminar Empresa
        bool DeleteTipoAnimal (int IdAnimal);

        #endregion
    }
}