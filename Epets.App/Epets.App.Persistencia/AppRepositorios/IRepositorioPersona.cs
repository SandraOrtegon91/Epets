using System.Collections.Generic;
using Epets.App.Dominio.Entidades;
using System;

namespace Epets.App.Persistencia.AppRepositorios
{
    public interface IRepositorioPersona
    {
        //firma de los metodos

        //Metodo para retornar todas las personas
        IEnumerable<Persona> GetAllPersonas();

        //metodo para adicionar una persona
        Persona AddPersona(Persona persona);

        //Metodo para Actualizar Persona
        Persona UpdatePersona(Persona persona);

        //Metodo para Eliminar Persona
        void DeletePersona (int IdPersona);

        //Metodo para retornar una persona segun su Id
        Persona GetPersona(int IdPersona);


        
    }
}