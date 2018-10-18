using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo13
{
    class Electrodomestico
    {
        public enum Colores { Blanco, Negro, Rojo, Azul, Gris };
        public enum Consumos { A, B, C, D, E, F };

        private double precioBase;
        private Colores color;
        private Consumos consumoEnergetico;
        private float peso;

        public Electrodomestico()
        {
            this.color = (Colores)0;
            this.consumoEnergetico = (Consumos)5;
            this.peso = 5;
        }

        public Electrodomestico(float precio, Colores color, Consumos consumoEnergetico, float peso)
        {
            this.precioBase = precio;
            this.color = color;
            this.consumoEnergetico = consumoEnergetico;
            this.peso = peso;
        }

        public double PrecioBase
        {
            get { return precioBase; }
            set 
            {
                if (value > 0)
                {
                    precioBase = value;
                }
                else
                {
                    throw new Exception("El Precio Base debe ser mayor a 0...");
                }
            }
        }
        public Colores Color
        {
            get { return color; }
            set 
            { 
                if (((int)value >= 0) && ((int)value <= 4))
                {
                    color = value;
                }
            }
        }
        public Consumos ConsumoEnergetico
        {
            get { return consumoEnergetico; }
            set 
            {
                if (((int)value >= 0) && ((int)value <= 5))
                {
                    consumoEnergetico = value;
                }
            }
        }
        public float Peso
        {
            get { return peso; }
            set 
            {
                if (value > 0)
                {
                    peso = value;
                }
            }
        }
        //PRECIO FINAL
        public virtual double PrecioFinal
        {
            get { return this.precioBase + this.ValorConsumo() + this.ValorPeso(); }
        }

        public double ValorConsumo()
        {
            double res = 0;
            switch (this.consumoEnergetico)
            {
                case (Consumos)0: res = 100;
                    break;
                case (Consumos)1: res = 80;
                    break;
                case (Consumos)2: res = 60;
                    break;
                case (Consumos)3: res = 50;
                    break;
                case (Consumos)4: res = 30;
                    break;
                case (Consumos)5: res = 10;
                    break;
            }
            return res;
        }

        public int ValorPeso()
        {
            int res = 0;
            if ((this.peso >= 0) && (this.peso <= 19))
            { 
                res = 10;
            }
            else
            {
                if ((this.peso >= 20) && (this.peso <= 49))
                {
                    res = 50;
                }
                else
                {
                    if ((this.peso >= 50) && (this.peso <= 79))
                    {
                        res = 80;
                    }
                    else
                    {
                        res = 100;
                    }
                }
            }
            return res;
        }
        //Carga Aleatoria
        public virtual void AtributoBase()
        {
            Random rnd = new Random();
            this.precioBase = (Math.Round(rnd.NextDouble(),6) * 10000);
            this.color = ((Colores)(rnd.Next(0,5)));
            this.consumoEnergetico = ((Consumos)(rnd.Next(0,6)));
            this.peso = rnd.Next(1,120);
        }
        //Mostrar
        public virtual void Mostrar()
        {
            Console.Write(" Precio Base:$" + this.precioBase);
            Console.Write("  Color:" + this.color);
            Console.Write("  Tipo de Consumo:" + this.consumoEnergetico);
            Console.WriteLine("  Peso:" + this.peso + "kg");
        }
    }
}
