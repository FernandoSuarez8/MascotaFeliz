using System;

namespace PracticaVeterinaria.App.Dominio
{
    public class Propietario : Persona
    {
        [KEY]
        public int idPropietario {get;set;}
        public string Nombre { get; set; }
        public string Apellido {get;set;}
        public string direccion { get; set; }
        public int telefono {get;set;}
        public string correoElectronico { get; set; }
   

    }
}
