using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab02_Mvc_Valverde_B.Models
{
    public class ClsDispensador
    {
        public double monto {  get; set; }
        public int b10 { get; set; }

        public int b20 { get; set; }
        public int b50 { get; set; }
        public int b100 { get; set; }
        public int b1 { get; set; }
        public int b2 { get; set; }
        public int b5 { get; set; }

        public double b010 { get; set; }
        public double b020 { get; set; }
        public double b050 { get; set; }

        public int cantidad { get; set; }
    }
}