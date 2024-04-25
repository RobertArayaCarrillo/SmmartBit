﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Dashboard
    {
        public string Reporte { get; set; } = "";
        public int Enero { get; set; }
        public int Febrero { get; set; }
        public int Marzo { get; set; }
        public int Abril { get; set; }
        public int Mayo { get; set; }
        public int Junio { get; set; }
        public int Julio { get; set; }
        public int Agosto { get; set; }
        public int Septiembre { get; set; }
        public int Octubre { get; set; }
        public int Noviembre { get; set; }
        public int Diciembre { get; set; }
        public int Total { get; set; }
        public int MesActual { get; set; }
        public double IncrementoPorcentual { get; set; }
        public int Incremento { get; set; }
    }
}
