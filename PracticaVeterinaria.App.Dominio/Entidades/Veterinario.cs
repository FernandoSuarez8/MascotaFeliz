using System;

namespace PracticaVeterinaria.App.Dominio
{
 public class Veterinario : Propietario
 {
 [KEY]
    public int idVeterinario {get;set;}
    [FOREIGN_KEY(idMascota)]
    public int idMascota {get;set;}
    public string nombre {get;set;}
    public string apellido {get;set;}
    public string direccion {get;set;}
    public int telefono {get;set;}
    public string tarjetaProfesional {get; set;}
 }
}
