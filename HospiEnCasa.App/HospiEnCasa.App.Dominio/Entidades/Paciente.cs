using System;
using System.Collections.Generic;   //se trajo de historia

namespace HospiEnCasa.App.Dominio
{
    public class Paciente : Persona     //hereda de la clase persona
    {
        public string Direccion {get; set;}
        public float Latitud {get; set;}
        public float Longitud {get; set;}
        public string Ciudad {get; set;}
        public DateTime FechaNacimiento {get; set;}
        public FamiliarDesignado Familiar {get; set;}
        public Enfermera Enfermera {get; set;}
        public Medico Medico {get; set;}
        public Historia Historia {get; set;}
        public List<SignoVital> SignosVitales {get; set;} 
        // clase y propiedad con s y sin s
        // A la propiedad se le puede poner el nombre que quiera        
    }
}
