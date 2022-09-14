using System;   // se requiere por el tipo de dato fecha

namespace HospiEnCasa.App.Dominio
{ 
    public class SignoVital
    {
        public int Id {get; set;}
        public DateTime FechaHora {get; set;}
        public float Valor {get; set;}
        public TipoSigno Signo {get; set;}
    
    }
}