using System;

namespace ExpedienteMedico.Entidades
{
    public class Medicina
    {
        public DateTime FechaEmision { get; set; }
        public string Nombre { get; set; }
        public int Id { get; set; }
        public string dosis { get; set; }
    }
}