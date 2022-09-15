using System;

namespace PracticaVeterinaria.App.Dominio
{
    public class Propietario : Mascota
    {
        public string cedula { get; set; }
        public string direccion { get; set; }
        public string correo { get; set; }
   

    }
}