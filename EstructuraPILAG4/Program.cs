using System;
using System.Collections.Generic;

namespace EstructuraPILAG4
{
    class Program
    {
        static void Main()
        {
            Stack<string> pila = new Stack<string>();
            pila.Push("Hola");
            pila.Push("soy");
            pila.Push("Armando");

            int totalElementos = pila.Count;

            for(int i=1; i <= totalElementos ; i++  )
            {
                Console.WriteLine(pila.Pop() );
            }


        }
    }
}
