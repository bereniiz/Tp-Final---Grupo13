using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo13
{
    class Heladera : Electrodomestico
    {
        public enum Tipos { Congelador, Frigorifico };

        private Tipos tipo;
        private float capacidad;
        
        public Heladera ()
        {
            this.tipo = (Tipos)0;
            this.capacidad = 40;
        }

        public Heladera (Tipos tipo, float capacidad)
        {
            this.tipo = tipo;
            this.capacidad = capacidad;
        }

        public Tipos Tipo
        {
            get { return tipo; }
            set 
            {
                if (((int)value == 0) || ((int)value == 1))
                {
                    tipo = value;
                }
            }
        }
        public float Capacidad
        {
            get { return capacidad; }
            set 
            { 
                if (value > 0)
                {
                    capacidad = value;
                }
            }
        }
        //PRECIO FINAL
        public override double PrecioFinal
        {
            get 
            {
                if (this.capacidad > 50)
                {
                    if (this.tipo == (Tipos)0)
                    {
                         return base.PrecioFinal + 100;
                    }
                    else
                    {
                        return base.PrecioFinal + 60;
                    }
                }
                return base.PrecioFinal; 
            }
        }

        //Carga Aleatoria
        public override void AtributoBase()
        {
            Random rnd = new Random();
            base.AtributoBase();
			this.tipo = ((Tipos)(rnd.Next(0,2)));
			this.capacidad = rnd.Next(20,400); ;
		
        }
        //Mostrar
        public override void Mostrar()
        {
            Console.WriteLine("\n HELADERA");
            base.Mostrar();
            Console.Write(" Tipo de Refrigerador:" + this.tipo);
            Console.WriteLine("  Capacidad del Refrigerador:" + this.capacidad + " litros");
            Console.WriteLine("--- PRECIO FINAL: $" + PrecioFinal + " ---");
        }
    }
}
