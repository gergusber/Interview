using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Rents
    {
        protected int rentalType { get; set; }
        public double price { get; set; }
        protected int time { get; set; }
        public abstract double Calcular(int time);
    }
    public enum tipoRenta
    {
        byDay,
        byHour,
        byWeek
    };

}
