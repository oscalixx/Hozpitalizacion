using System;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hospital En Casa");
            AddPaciente();
            // BuscarPaciente (1);
            // Asignarmedico();
        }
        private static void AddPaciente()
        {
            var paciente = new Paciente 
                {
                Nombre = "Rosita",
                Apellidos = "Bonita",
                NumeroTelefono = "35022223333",
                Genero = Genero.Masculino,
                Longitud = 8.12345F,
                Latitud = 72.12345F,
                Ciudad = "Bogota",
                FechaNacimiento = new DateTime(1969, 10, 19)                
                };
            _repoPaciente.AddPaciente(paciente);
            System.Console.WriteLine($"El Paciente {paciente.Nombre} {paciente.Apellidos} ha sido agregado con éxito a la BD"); //Sale en pantalla
        }
        private static void BuscarPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine(paciente.Nombre + " " + paciente.Apellidos);
        }
        private static void Asignarmedico()
        {
            var medico = _repoPaciente.AsignarMedico(1,2);
            Console.WriteLine(medico.Nombre + " " + medico.Apellidos);
        }

    }
}
