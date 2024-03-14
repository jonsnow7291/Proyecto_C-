using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 234 + 232;
            int resta = 432 - 43;
            int division = 423 / 2;
            int multiplicacion = 2312 * 32;
            int residuo = 32 % 23;
            if (suma < resta || suma <= resta) Console.WriteLine("es menor que  ");
            if (suma < resta && suma >= resta) Console.WriteLine("es mayor que  ");
            if (suma == resta || suma != resta) Console.WriteLine("es igual que o no es igual que ");
            if (suma < resta) Console.WriteLine("es menor ");
            while (suma > 2)
            /*operador para sumar da a uno o varios numeros  a una  variable  asi como para restar de una o mas unidades a cada variable */
            {
                suma++;
                resta--;
                suma += 2;
                resta -= 2;
            }

            // tipo de operador para obtener  resultados binarios
            int num1 = ~suma + resta;
            Console.WriteLine(num1);

            int[] matriz = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int? segundoNumero = matriz?[2];
            if (segundoNumero != null)
            {

            }

            int num = 1;
            int numcon = ~num;
            Console.WriteLine(numcon);
            int num2 = 2;
            int num3 = 3;
            num = num2 >>= num3;

            int[][] matrizEsc = new int[3][];
            matrizEsc[1] = new int[] { 2, 2, 2 };
            matrizEsc[2] = new int[]{ 2, 5, 2, 2, 2, 2, 2, 2, 2 };
            matrizEsc[3] = new int[] { 2 };
            matrizEsc[23] = new int[] { 3213, 312, 312312, 123 };

        }
    }  
}