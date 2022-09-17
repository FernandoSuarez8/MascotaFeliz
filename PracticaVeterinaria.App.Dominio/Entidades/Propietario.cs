using System;

namespace PracticaVeterinaria.App.Dominio
{
    public class Propietario : Mascota
    {
        [KEY]
        public int idPropietario {get;set;}
        public string nombre { get; set; }
        public string apellido {get;set;}
        public string direccion { get; set; }
        public int telefono {get;set;}
        public string correoElectronico { get; set; }
   

    }
}
