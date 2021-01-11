using System;
using System.Threading;

namespace Hilos
{
    class Carrera 
    {
        public static void Corredor(object obj) 
        {
            var nombre = (string)obj;
            //var hiloActual = Thread.CurrentThread;
            var pasos = 0;
            var random = new Random();
            while (pasos < 10) 
            {
                pasos += random.Next(0,4);
                for (int i = 0; i <= pasos; i++) 
                {
                    Console.WriteLine("*");
                }
                    Console.WriteLine("Corredor {0} dio {1} pasos", nombre, pasos);
                    Thread.Sleep(10);
            }
            Console.WriteLine("El corredor {0} llego a la meta ", nombre);
        }
    }
    //dibujar columnas simulando que seas corredores  \\\ 
}
