using ExpedienteMedico.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public interface ILogicaPacientes
    {//Logica funcionalidad de los Pacientes
        List<Paciente> GetPacientes(Usuario usuario);
        List<Paciente> GetPacientePorNombre(string nombre, Usuario usuario);
        Paciente GetPorId(int id);
        Paciente EditarPaciente(Paciente entidad);
    }
}
