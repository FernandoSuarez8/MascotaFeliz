using System;
using System.Collections.Generic;
using System.Linq;
using PracticaVeterinaria.App.Dominio;
using PracticaVeterinaria.App.Persistencia;

namespace PracticaVeterinaria.App.Persistencia.AppRepositorios
{
    public interface IRepositorioVisita
    {
        Visita AddVisita(Visita visita);
        void DeleteVisita(int idVisita);

        Visita GetVisita(int idVisita);

        Visita UpdateVisita(Visita visita);

        IEnumerable<Visita> GetAllVisita();

        
    }



}