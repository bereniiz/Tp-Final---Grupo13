using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;

namespace Grupo13
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            ArrayList electrodomesticos = new ArrayList();

            //cargarElectrodomestico(ref electrodomesticos, ref total);
            //mostrarElectrodomestico(electrodomesticos);

            Console.WriteLine();
            Console.WriteLine("*********** **** TOTAL PRECIOS FINALES: $" + total + " **** ***********");/*
            Cocina electro = new Cocina();
            electro.PrecioBase = 10;
            electro.Color = (Electrodomestico.Colores)10;
            electro.ConsumoEnergetico = (Electrodomestico.Consumos)99;
            electro.Peso = 920;

            Console.WriteLine(electro.PrecioBase);
            Console.WriteLine(electro.Color);
            Console.WriteLine(electro.ConsumoEnergetico);
            Console.WriteLine(electro.Peso);*/

            Console.ReadKey();
        }

        
    }
}
