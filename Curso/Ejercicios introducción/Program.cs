using System;
using System.Timers;
namespace intro
{
    class Program{
        static void Main(string[]args)
        {
            //ejercicio 1
            /*int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int numResult = num1 + num2 + num3; 
            Console.WriteLine(numResult);*/
            //ejercicio 2 
            /*
            int numR1 = int.Parse(Console.ReadLine());
            int numR2 = int.Parse(Console.ReadLine());
            if (numR1 > numR2)
            {
                Console.WriteLine("El numero mayor es "+ numR1);
            }
            else 
            {
                Console.WriteLine("El numero mayor es " + numR2);

            }
            */
            //Ejercicio3 
            try
            {
                string dia = Console.ReadLine();
                if (dia == "Lunes" || dia == "Martes" || dia == "Miercoles" || dia == "Jueves" || dia == "viernes")
                {
                    Console.WriteLine($" el dia {dia} es entre semana");
                }
                else if (dia == "Sabado " || dia == "Domingo")
                {
                    Console.WriteLine($" el dia {dia} es un fin de semana");
                }
                else
                {
                    Console.WriteLine("ese dia ni existe pa");                }

            }
            catch(ArgumentOutOfRangeException e){

            }
                
        }
    }
}