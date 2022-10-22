using System;

namespace LAB_VECTORES_EJEMPLO_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SEGUNDO EJEMPLO VECTORES CON FUNCIONES!");
            pruebaVector pv = new pruebaVector();
            pv.Cargar();
            pv.Cargar1();
            //pv.Imprimir();
            pv.Imprimir1();
        }

        class pruebaVector
        {
            private string[] sueldos;
            public void Cargar()
            {
                sueldos = new string[5];
                for (int f = 0; f < 5; f++)
                {
                    Console.WriteLine("Ingresa nombre " + (f + 1));
                    string linea;
                    linea = Console.ReadLine();
                    sueldos[f] = (linea);
                }
            }
            private int[] edades;
            public void Cargar1()
            {
                edades = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Ingresa edad " + (i + 1));
                    string linea;
                    linea = Console.ReadLine();
                    edades[i] = int.Parse(linea);
                }
            }
            public void Imprimir()
            {
                for (int f = 0; f < 5; f++)
                {
                    Console.WriteLine("");
                    Console.WriteLine("En el nombre " + (f + 1));
                    Console.WriteLine(sueldos[f]);
                }
            }
            public void Imprimir1()
            {
                Console.WriteLine("Personas mayores de 18");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("");
                    
                    
                    if (edades[i] > 18)
                    {
                        Console.WriteLine("posicion " + (i + 1));
                        Console.WriteLine(sueldos[i]);
                        Console.WriteLine(edades[i]);
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
