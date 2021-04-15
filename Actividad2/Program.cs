using System;
using System.Collections.Generic;
using System.Linq;

namespace Actividad2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Equipos = new List<string>();

            Console.WriteLine("Ingresa el nombre del equipo: ");
            string input = Console.ReadLine();

            while (!string.IsNullOrEmpty(input))
            {
                Equipos.Add(input);
                Console.WriteLine("Ingresa el nombre del siguiente equipo. Si es el último deje vacio: ");
                input = Console.ReadLine();
            }
            int i = 0;
            int j = 0;
            List<string> resultadosi = new List<string>();
            List<string> resultadosj = new List<string>();
            foreach (var item in Equipos)
            {
                for (j = i + 1; j < Equipos.Count(); j++)
                {
                    if (Equipos[i] != Equipos[j])
                    {
                        Console.WriteLine(Equipos[i] + " VS " + Equipos[j]);
                        Console.Write("Ingrese los goles de " + Equipos[i]);
                        string resultadoi = Console.ReadLine();
                        resultadosi.Add(resultadoi);
                        Console.Write("Ingrese los goles de " + Equipos[j]);
                        string resultadoj = Console.ReadLine();
                        resultadosj.Add(resultadoj);
                        double total = resultadosi.Sum(str => Convert.ToInt32(str));
                        Console.WriteLine("El puntaje de " + Equipos[i] + " es " + total);
                        double total2 = resultadosj.Sum(str => Convert.ToInt32(str));
                        Console.WriteLine("El puntaje de " + Equipos[j] + " es " + total2);
                    }
                }
                i++;

                
            }
        }
    }
}
