using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo13
{
    class Lavarropa : Electrodomestico
    {
        private float cargaKilogramo;

        public Lavarropa ()
        {
            this.cargaKilogramo = 10;
        }

        public Lavarropa (float cargaKilogramo)
        {
            this.cargaKilogramo = cargaKilogramo;
        }

        public float CargaKilogramo
        {
            get { return cargaKilogramo; }
            set 
            { 
                if (value > 0)
                {
                    cargaKilogramo = value;
                }
            }
        }

        public override double PrecioFinal
        {
            get { return base.PrecioFinal + Math.Round(this.cargaKilogramo * 0.3333333333, 2); }
        }
        //Carga Aleatoria
        public override void AtributoBase()
        {
            Random rnd = new Random();
            base.AtributoBase();
			this.cargaKilogramo = rnd.Next(1,21);
		
        }
        //Mostrar
        public override void Mostrar()
        {
            Console.WriteLine("\n LAVARROPAS");
            base.Mostrar();
            Console.WriteLine(" Carga del Lavarropas:" + this.cargaKilogramo + "kg");
            Console.WriteLine("--- PRECIO FINAL: $" + this.PrecioFinal + " ---");
        }
    }
}
