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

            cargarElectrodomestico(ref electrodomesticos, ref total);
            mostrarElectrodomestico(electrodomesticos);

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

        public static void cargarElectrodomestico(ref ArrayList coleccion, ref double total)
        {
            int num, cant;
            cant = 5;
            Random rnd = new Random();
            for (int i = 0; i < cant; i++)
            {
                num = rnd.Next(1, 4);
                switch (num)
                {
                    case 1:
                        Heladera heladera = new Heladera();
                        Thread.Sleep(14);
                        heladera.AtributoBase();
                        total += heladera.PrecioFinal;
                        coleccion.Add(heladera);
                        break;
                    case 2:
                        Cocina cocina = new Cocina();
                        Thread.Sleep(14);
                        cocina.AtributoBase();
                        total += cocina.PrecioFinal;
                        coleccion.Add(cocina);
                        break;
                    case 3:
                        Lavarropa lavarropa = new Lavarropa();
                        Thread.Sleep(14);
                        lavarropa.AtributoBase();
                        total += lavarropa.PrecioFinal;
                        coleccion.Add(lavarropa);
                        break;
                }
            }
        }

        public static void mostrarElectrodomestico(ArrayList coleccion)
        {
            Console.Clear();
            foreach (Electrodomestico element in coleccion)
            {
                element.Mostrar();
            }
        }
    }
}
