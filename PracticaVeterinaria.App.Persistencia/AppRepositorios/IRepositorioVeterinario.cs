using System;
using System.Collections.Generic;
using System.Linq;
using PracticaVeterinaria.App.Dominio;
using PracticaVeterinaria.App.Persistencia;

namespace PracticaVeterinaria.App.Persistencia.AppRepositorios
{
    public interface IRepositorioVeterinario
    {
        
        Veterinario AddVeterinario(Veterinario veterinario);
        void DeleteVeterinario(int idVeterinario);

        Veterinario GetVeterinario(int idVeterinario);

        Veterinario UpdateVeterinario(Veterinario veterinario);

        IEnumerable<Veterinario> GetAllVeterinarios();


    }



}