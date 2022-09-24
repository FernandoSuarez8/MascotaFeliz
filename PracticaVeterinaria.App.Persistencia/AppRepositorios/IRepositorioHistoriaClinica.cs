using System;
using System.Collections.Generic;
using System.Linq;
using PracticaVeterinaria.App.Dominio;
using PracticaVeterinaria.App.Persistencia;

namespace PracticaVeterinaria.App.Persistencia.AppRepositorios
{
    public interface IRepositorioHistoriaClinica
    {
        HistoriaClinica AddHistoriaClinica(HistoriaClinica historiaClinica);
        void DeleteHistoriaClinica(int idHistoriaClinica);

        HistoriaClinica GetHistoriaClinica(int idHistoriaClinica);

        HistoriaClinica UpdateHistoriaClinica(HistoriaClinica historiaClinica);

        IEnumerable<HistoriaClinica> GetAllHistoriaClinica();

    }

}