using System;
namespace PracticaVeterinaria.App.Dominio
{
    public class HistoriaClinica
    {
        public int idHistoria{get; set;}
        [KEY]
        public int idMascota{get;set;}
        [FOREIGN KEY]
        public int idVeterinario{get;set;}
        public string Temperatura{get;set;}
        public string Peso{get;set;}
        public int frecRespiratoria{get;set;}
        public int frecCardiaca{get;set;}
        public string estadoAnimo{get;set;}
        public string fechaVisita{get; set;}
        public string Recomendaciones{get;set;}
        public string formulaMedica{get;set;}
        public Mascota mascota{get;set;}
        
    }
}
