using System.Collections.Generic;
using System.Linq;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioPaciente : IRepositorioPaciente
    { 
        private readonly AppContext _appContext;

        //metodo constructor de RepositorioPaciente
        public RepositorioPaciente(AppContext appContext)
        {
            _appContext = appContext;
        }

        // metodos abstractos herdados de la interffaz IrepositorioPaciente
        // este metodo retorna un objeto de tipo Paciente
        Paciente IRepositorioPaciente.AddPaciente(Paciente paciente) //mismo peciente de contex linea 8
    {
        var pacienteAdicionado = _appContext.Pacientes.Add(paciente);
        _appContex.SaveChanges();
        return pacienteAdicionado.Entity;
    }
    
    void RepositorioPaciente.DeletePaciente(int idPaciente)
    {
        var pacienteEncontrado = _appContext.Pacientes.FirstOrDefalut(p => p.Id == idPaciente);

        if (pacienteEncontrado == null) return;

        _appContext.Pacientes.Remove (PacienteEncontrado);
        _appContext.SaveChanges ();
    }

//retorna todos los pacientes que se encuentren en la BD
    IEnumerable<Paciente> IRepositorioPaciente.GetAllPaciente()
    {
        return _appContext.Pacientes;
    }

    //metodo que retorna un solo paciente
    Paciente Irepositorio.GetPaciente(int idPaciente)
    {
        return _appContex.Pacientes.FirstOrDefalut(p => p.Id == idPaciente);
    }
    
    //metodo que permite actualizar un paciente
    Paciente IRepositorioPaciente.UpdatePaciente(Paciente paciente)
    {
        var pacienteEncontrado = -appContext.Pacientes.FirstOrDefalut(p => p.Id == paciente.Id);

        if (pacienteEncontrado != null)
        {
            pacienteEncontrado.Nombre = paciente.Nombre;
            pacienteEncontrado.Apellidos = paciente.Apellidos;
            pacienteEncontrado.NumeroTelefonico = paciente.NumeroTelefonico;
            pacienteEncontrado.Genero = paciente.Genero;
            pacienteEncontrado.Direccion = paciente.Direccion;
            pacienteEncontrado.Latitud = paciente.Latitud;
            pacienteEncontrado.Longitud = paciente.longitud;
            pacienteEncontrado.Ciudad = paciente.Ciudad;
            pacienteEncontrado.Fechanacimiento = paciente.FechaNacimiento;
            pacienteEncontrado.Familiar = paciente.Familiar;
            pacienteEncontrado.Enfermera = paciente.Enfermera;
            pacienteEncontrado.Medico = paciente.Medico;
            pacienteEncontrado.Historia = paciente.Historia;
            _appContex.SaveChanges();
            
        } 
        else 
        {
            System.Console.WriteLine("Paciente no encontrado");   
        }
        return paciente.PacienteEncontrado;
    }

    Medico IRepositorioPaciente.AsignarMedico(int idPaciente, int idMedico)
    {
         var pacienteEncontrado = -appContext.Pacientes.FirstOrDefalut(p => p.Id == paciente.Id);
        if (pacienteEncontrado != null)
        {
        var medicoEncontrado = _appContext.Medicos.FirstOrDefalut (m => m.id = idMedico);
        if (medicoEncontrado != null)
        {
            pacienteEncontrado.Medico = medicoEncontrado;
            _appContex.SaveChanges();
        }
        return medicoEcontrado;

        }
       return null;
     }
    }

}
