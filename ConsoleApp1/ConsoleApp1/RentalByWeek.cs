using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class RentalByWeek : Rents
    {
        public RentalByWeek()
        {
        }

        public RentalByWeek(int time)
        {
            this.time = time;
            this.price = Calcular(time);
            rentalType = 2;
        }

        public override double Calcular(int time)
        {
            this.price = time * 60;
            return this.price;
        }
    }
}
