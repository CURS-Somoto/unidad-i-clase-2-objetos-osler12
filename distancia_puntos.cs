using System;

namespace clase_punto
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto origen = new Punto(2, 2);
            Punto destino = new Punto(8, 5);

            decimal distancia = origen.MedirDistancia(destino);

            Console.WriteLine("La distancia entre los puntos es: " + distancia.ToString("0.##") + " metros");
            Console.ReadKey();
        }
    }

    class Punto
    {
        public decimal x;
        public decimal y;
        public decimal z;

        public Punto(decimal x, decimal y, decimal z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public decimal MedirDistancia(Punto otro)
        {
            decimal dx = this.x - otro.x;
            decimal dy = this.y - otro.y;
            decimal dz = this.z - otro.z;

            decimal distancia = (decimal)Math.Sqrt((double)(dx * dx + dy * dy + dz * dz));

            return distancia;
        }
    }
}
