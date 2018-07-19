using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class RentalByDay : Rents
    {
        public RentalByDay()
        {
        }

        public RentalByDay(int time)
        {
            this.time = time;
            this.price = Calcular(time);
            rentalType = 1;
        }

        public override double Calcular(int time)
        {
            this.price = time * 5;
            return this.price;
        }
    }
}
