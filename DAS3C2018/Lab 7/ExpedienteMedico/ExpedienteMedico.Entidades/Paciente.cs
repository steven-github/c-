using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpedienteMedico.Entidades
{
    public class Paciente
    {//propiedad del paciente
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad
        {
            get
            {
                return (DateTime.Now.Year - FechaNacimiento.Year);
            }
        }
        public string TipoSangre { get; set; }
        public List<Consulta> Consultas { get; set; }
        public List<Prueba> Pruebas { get; set; }
        public List<Medicina> Medicinas { get; set; }
    }
}
