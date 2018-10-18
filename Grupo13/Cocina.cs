using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo13
{
    class Cocina : Electrodomestico
    {
        public enum Alimentaciones { Eléctrica, Gas };

        private int alto;
        private int ancho;
        private int profundidad;
        private Alimentaciones alimentacion;

        public Cocina ()
        {
            this.alto = 85;
            this.ancho = 65;
            this.profundidad = 65;
            this.alimentacion = (Alimentaciones)1;
        }

        public Cocina (int alto, int ancho, int profundidad, Alimentaciones alimentacion)
        {
            this.alto = alto;
            this.ancho = ancho;
            this.profundidad = profundidad;
            this.alimentacion = alimentacion;
        }

        public int Alto
        {
            get { return alto; }
            set 
            {
                if ((value >= 80) && (value <= 95))
                {
                    alto = value;
                }
            }
        }
        public int Ancho
        {
            get { return ancho; }
            set 
            {
                if ((value >= 50) && (value <= 120))
                {
                    ancho = value;
                }
            }
        }
        public int Profundidad
        {
            get { return profundidad; }
            set
            {
                if ((value >= 60) && (value <= 70))
                {
                    profundidad = value;
                }
            }
        }
        private Alimentaciones Alimentacion
        {
            get { return alimentacion; }
            set
            {
                if (((int)value == 0) && ((int)value == 1))
                {
                    alimentacion = value;
                }
            }
        }
        //PRECIO FINAL
        public override double PrecioFinal
        {
            get { return base.PrecioFinal + this.ValorAncho(); }
        }

        public double ValorAncho()
        {
            double res = 0;
            if ((this.Ancho >= 60) && (this.Ancho <= 79))
            {
                res = base.PrecioFinal * 15 /100;
            }
            else
            {
                if ((this.Ancho >= 80) && (this.Ancho <= 99))
                {
                    res = base.PrecioFinal * 20 /100;
                }
                else
                {
                    if ( this.Ancho >= 100 )
                    {
                        res = base.PrecioFinal * 30 /100;
                    }
                }
            }
            return res;
        }
        //Carga Aleatoria
        public override void AtributoBase()
        {
            Random rnd = new Random();
            base.AtributoBase();
            this.alto = rnd.Next(80, 96);
            this.ancho = rnd.Next(50, 121);
            this.profundidad = rnd.Next(60, 71);
            this.alimentacion = ((Alimentaciones)(rnd.Next(1,3)));
		
        }
        //Mostrar
        public override void Mostrar()
        {
            Console.WriteLine("\n COCINA");
            base.Mostrar();
            Console.Write(" Alto:" + this.alto + "cm");
            Console.Write("  Ancho:" + this.ancho + "cm");
            Console.Write("  Profundidad:" + this.profundidad + "cm");
            Console.WriteLine("  Alimentacion:" + this.alimentacion);
            Console.WriteLine("--- PRECIO FINAL: $" + this.PrecioFinal + " ---");
		
        }
    }
}
