using System;
using System.Collections.Generic;
using System.Linq;
using PracticaVeterinaria.App.Dominio;
using PracticaVeterinaria.App.Persistencia;

namespace PracticaVeterinaria.App.Persistencia.AppRepositorios
{
    public interface IRepositorioHistoriaClinica
    {
        HistoriaClinica AddHistoriaCLinica(HistoriaClinica historiaclinica);
        void DeleteHistoriaClinica(int idHistoriaClinica);

        HistoriaClinica GetHistoriaClinica(int idHistoriaClinica);

        HistoriaClinica UpdateHistoriaClinica(HistoriaClinica historiaclinica);

        IEnumerable<HistoriaClinica> GetAllHistoriaClinica();

    }

}