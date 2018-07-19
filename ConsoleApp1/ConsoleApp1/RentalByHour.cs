using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class RentalByHour : Rents
    {
        public RentalByHour()
        {
        }

        public RentalByHour(int time)
        {
            this.time = time;
            this.price = Calcular(time);
            rentalType = 0;
        }
        public override double Calcular(int time)
        {
            this.price = time * 5;
            return this.price;
        }

    }
}
