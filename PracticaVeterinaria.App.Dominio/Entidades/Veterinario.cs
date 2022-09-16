using System;

namespace PracticaVeterinaria.App.Dominio
{
 public class Veterinario : Propietario
 {
 [KEY]
    public int idVeterinario {get;set;}
    [FOREIGN_KEY(idMascota)]
    public int idMascota {get;set;}
    public string Nombre {get;set;}
    public string Apellido {get;set;}
    public string Direccion {get;set;}
    public int Telefono {get;set;}
    public string tarjetaProfesional {get; set;}
 }
}
