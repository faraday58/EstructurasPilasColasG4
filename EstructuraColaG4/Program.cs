using System;
using System.Collections.Generic;
using System.Threading;

namespace EstructuraColaG4
{
    class Program
    {
        static void Main()
        {
            Queue<string> diasSemana = new Queue<string>();

            diasSemana.Enqueue("Lunes");
            diasSemana.Enqueue("Martes");
            diasSemana.Enqueue("Miércoles");
            diasSemana.Enqueue("Jueves");

            int totaldias = diasSemana.Count;

            for (int i =0; i< totaldias  ;i++  )
            {
                Console.Clear();
                Console.WriteLine("Hoy es: {0}", diasSemana.Dequeue());
                Thread.Sleep(2000);                

            }
        }
    }
}
