using System.Collections.Generic;
using Epets.App.Dominio.Entidades;
using System;

namespace Epets.App.Persistencia.AppRepositorios
{
    public interface IRepositorioSolicitudVisita
    {
         //firma de los metodos

        //Metodo para retornar todas las SolicitudVisita
        IEnumerable<SolicitudVisita> GetAllSolicitudVisitas();

        //metodo para adicionar una SolicitudVisita
        SolicitudVisita AddSolicitudVisita(SolicitudVisita SolicitudVisita);

        //Metodo para Actualizar SolicitudVisita
        SolicitudVisita UpdateSolicitudVisita(SolicitudVisita SolicitudVisita);

        //Metodo para Eliminar SolicitudVisita
        void DeleteSolicitudVisita (int IdSolicitudVisita);

        //Metodo para retornar una SolicitudVisita segun su Id
        SolicitudVisita GetSolicitudVisita(int IdSolicitudVisita);
    }
}