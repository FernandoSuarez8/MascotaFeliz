using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticaVeterinaria.App.Dominio;
using PracticaVeterinaria.App.Persistencia;
using PracticaVeterinaria.App.Persistencia.AppRepositorios;

namespace PracticaVeterinaria.App.Presentacion.Pages
{
    public class LisModel : PageModel
    {

        private readonly IRepositorioPropietario repositorioPropietario;
        public IEnumerable<Propietario> propietarios {get; set;}

        public LisModel ()
        {

            this.repositorioPropietario = new RepositorioPropietario(new PracticaVeterinaria.App.Persistencia.AppRepositorios.AppContext());
        }


        public void OnGet()
        {
            propietarios = repositorioPropietario.GetAllPropietarios();
        }
    }
}
