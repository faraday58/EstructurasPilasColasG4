using System;

namespace EstructurasPilasColasG4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("El factorial de 5: {0} ", Factorial(5));

            string frase = "Anita lava la tina";
            

            for(int i=0; i < frase.Length; i++)
            {
                Console.WriteLine(frase[i]);
            }    

        }
        static ulong Factorial(ushort N )
        {
            if(N==0)
            {
                return 1;
            }
            else
            {
                return N * Factorial(  (ushort)(N - 1) );
            }

        }
    }
}
