using System;

namespace ExpedienteMedico.Entidades
{
    public class Consulta
    {
        public int Id { get; set; }
        public DateTime FechaConsulta { get; set; }
        public string Descripcion { get; set; }
        public string Doctor { get; set; }

    }
}