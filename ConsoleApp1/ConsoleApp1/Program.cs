using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int Rentas = GetRentas();
            IList<Rents> rents = null;
            Boolean aplicaDescuento = false;
            if (Rentas >= 3 && Rentas <= 5)
            {
                int descuento = GetDescuento();
                if (descuento > 0 || descuento < 3)
                {
                    if (descuento == 1)
                    {
                        aplicaDescuento = true;
                    }
                }

            }

            List<Rents> lista = new List<Rents>();
            for (int i = 0; i < Rentas; i++)
            {
                int tipo = GetTipo();
                int tiempo = GetTiempo();
                if (tipo == 0)
                {
                    lista.Add(item: new RentalByHour(time: tiempo));
                }
                if (tipo == 1)
                {
                    lista.Add(item: new RentalByHour(time: tiempo));
                }
                if (tipo == 2)
                {
                    lista.Add(item: new RentalByWeek(time: tiempo));
                }

            }
            var cant = (from l in lista select l.price).ToList().Sum();
            if (aplicaDescuento)
            {
                cant = cant - (cant % 30);
            }
            Console.WriteLine("El saldo a pagar es de:" + cant);
            Console.Read();
        }

        private static int GetDescuento()
        {
            Console.WriteLine("Tenemos una promocion para usted, de 3 a 5 rentas,puede obtener un descuento,¿Desea obtenerlo(1:si,2:no)?");
            var descuento = Console.ReadLine();
            int desc = 0;
            while (!Int32.TryParse(descuento, out desc))
            {
                Console.WriteLine("ingrese nuevamente el tiempo solicitado");
                descuento = Console.ReadLine();
            }
            return desc;
        }

        private static int GetTiempo()
        {
            Console.WriteLine("ingrese el tiempo solicitado");
            var tiempoSolicitado = Console.ReadLine();
            int tiempo = 0;
            while (!Int32.TryParse(tiempoSolicitado, out tiempo))
            {
                Console.WriteLine("ingrese nuevamente el tiempo solicitado");
                tiempoSolicitado = Console.ReadLine();
            }
            return tiempo;
        }
        private static int GetRentas()
        {
            Console.WriteLine("Ingrese la cantidad de rentas que solicita");
            var renta = Console.ReadLine();
            int rentaProp = 0;
            while (!Int32.TryParse(renta, out rentaProp))
            {
                Console.WriteLine("ingrese nuevamente el tiempo solicitado");
                renta = Console.ReadLine();
            }
            return rentaProp;
        }
        private static int GetTipo()
        {
            Console.WriteLine("Que tipo de renta desea solicitar: (0_Hora,1_dia,2_semana)");
            var tipoRenta = Console.ReadLine();
            int tipo = 0;
            while (!Int32.TryParse(tipoRenta, out tipo) && 0 < tipo || tipo > 2)
            {
                Console.WriteLine("ingrese nuevamene que tipo de renta desea solicitar: (0_Hora,1_dia,2_semana)");
                tipoRenta = Console.ReadLine();
            }
            return tipo;
        }

    }
}
