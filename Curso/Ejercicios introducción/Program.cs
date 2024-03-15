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
            /*try
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
                Console.WriteLine("Formato no comptible");

            }*/
            //ejercicio 4
            /*
            Console.Write("Escriba el precio de su producto aquí : ");
            int precio = int.Parse(Console.ReadLine());
            while (precio  == 0|| precio <= 90) {
                Console.Write("El precio introducido de su producto no es valido rectifique : ");
                precio = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Elija su forma de pago (1: tarjeta de credito, 2: efectivo");
            int fp = int.Parse(Console.ReadLine());
                while (fp != 1 && fp != 2)
                {
                    Console.WriteLine("Su forma de pago no es valida rectifiquela con las opciones establecidas (1: tarjeta de credito, 2: efectivo)");
                    fp = int.Parse(Console.ReadLine());
                }
            
            //Validacion de contraseña 
            if (fp == 1)
            {
                int nTCLong;
                int intentos = 0;

                do
                {
                    if (intentos ==0) {
                        Console.WriteLine("Ingrese su numero de tarjeta de credito  sin signos ni sepraciones");
                    }
                    else
                    {
                        Console.WriteLine("Rectifique su numero de tarjeta y Escribalo");
                    }
                    string nTC = Console.ReadLine();
                    nTCLong = nTC.Length;
                    if (nTCLong < 11 && nTCLong > 9)
                    {
                        Console.WriteLine("Compra hecha con el numero de tarjeta de credito " + nTC + " muchas gracias por su compra");
                    }
                    intentos++;
                }
                while (nTCLong < 10);
                

            }
            else if (fp == 2)
            {
                Console.WriteLine("Muchas gracias por su compra vuelva pronto");
            }
            */
            //Ejercicio 5
            /*
            for (int i = 0; i <101; i++)
            {
                Console.WriteLine(i);
                
            }
           */
            //Ejercicio 6
            /*
            int num1 = 0;
            while (num1<101)
            {
                Console.WriteLine(num1);
                num1++;
            }
            */
            //ejercicio 7
            /*
            int numPar = 2;
            for (int l=0; l < 101; l++)
            {
                if (l == numPar)
                {
                    Console.WriteLine(l);
                    numPar += 2;
                }
            }
            */
            //ejercicio8
            /*int numPar = 3;
            for (int l = 0; l < 101; l++)
            {
                if (l == numPar)
                {
                    Console.WriteLine(l);
                    numPar += 3;
                }
            }*/
            //ejercicio 9 
            /*
            int[] matriz = new int [50];
            int Contmatriz = 0;
            int numPar = 2;
            for (int u =0; u < 101;u++)
            {
                if (u==numPar)
                { 
                    matriz[Contmatriz] = u;
                    Console.WriteLine(matriz[Contmatriz]);
                    numPar += 2;
                    Contmatriz++;
                }
            }
            */
            //ejercicio 10 

           /*int contador = 1;
            int[] matriz = new int[10];

                for (int u = 0; u < 10; u++)
                {
                    try
                    {
                        Console.WriteLine("escribe tu cifra numero " + contador);
                        matriz[u] = int.Parse(Console.ReadLine());
                        contador++;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Su introducción no es numerica "+e);
                        u--;
                    }
                }
            int suma = 0;
            foreach (int nums in matriz) 
            {
                int numPar = 2;
                int numImpar = 1;
                while (numPar<nums && numImpar < nums)
                {
                    numImpar+=2;
                    numPar += 2;
                }
               if(nums == numImpar )
                {
                    suma = suma - nums;

                }else if (nums == numPar)
                {
                    suma = suma + nums;
                }
                else {
                    suma = suma + nums;
                }
               
            }
            Console.Write("Su suma dio un resultado de "+suma);
            */
            //ejercicicio 11
            /*
            string[] mD = new string[] {"Lunes","Martes","Miercoles","Jueves","Viernes","Sabado","Domingo"};
            Console.Write("Escribe aqui el numero de tu dia para saber su nombre (1-7)");
            int dU=0;
            try
            {
                dU = int.Parse(Console.ReadLine());
            } catch(Exception e) {
                Console.WriteLine("esto no es un dato numerico" );
            }
            while (dU < 1 || dU > 7)
            {
                Console.WriteLine("Este dia no existe, escribalo de nuevo ");
                dU = int.Parse( Console.ReadLine());
            }
            //forma 1
            dU = dU -= 1;
            Console.WriteLine(mD[dU]);
            //forma 2
            switch (dU)
            {
                case 1:
                    dU = dU -= 1;
                    Console.WriteLine(mD[dU]);
                    break;
                case 2:
                    dU = dU -= 1;
                    Console.WriteLine(mD[dU]);
                    break;
                case 3:
                    dU = dU -= 1;
                    Console.WriteLine(mD[dU]);
                    break;
                case 4:
                    dU = dU -= 1;
                    Console.WriteLine(mD[dU]);
                    break;
                case 5:
                    dU = dU -= 1;
                    Console.WriteLine(mD[dU]);
                    break;
                case 6:
                    dU = dU -= 1;
                    Console.WriteLine(mD[dU]);
                    break;
                case 7:
                    dU = dU -= 1;
                    Console.WriteLine(mD[dU]);
                    break;
                default:
                    Console.WriteLine("Ya te dije que este no existe pa");
                    break;
            }
            */
            //ejercicio 12
            /*
            int suma = 0;
            Console.WriteLine("Dame un numero de 1 - 1000");
            int nD = int.Parse(Console.ReadLine());
            while(nD <1||nD >1000){
            Console.WriteLine("tu numero no entra en el rango recomendado");
            }
            for (int d= 1; d<=nD;d++ )
            {
                suma = suma + d;
            }
            Console.WriteLine("Tu resultado es "+suma);
            */
            //ejercicio 13
            /*
                Console.WriteLine("Aqui revisaremos si su numero es primo");
                Console.WriteLine("Escribe tu numero aqui:");
                int num = int.Parse(Console.ReadLine());
                for (int o = 1 ; o <= num;o++)
                {
                     int r = num % o;
                    if (r == 0 && o !=1 && o != num){
                        Console.WriteLine("Este numero no es primo por que es divisible por: " + o);
                    }
                    else
                    {
                        if (o ==num) {
                            Console.WriteLine("Este es primo");
                        }
                    }
                }
            */
            //ejercicio 14
            //forma 1
            
            /*
            string num  = Console.ReadLine();
            int LongNum = num.Length;
            Console.WriteLine("el numero tiene "+LongNum+" digitos");*/
            //forma 2 
            int num = int.Parse(Console.ReadLine());
            
            int divi = 10;
            int intentos=1;
            if (num >9) {
                for (int n = 2; n <= num; n++)
                {
                    num = num / divi;
                    intentos++;
                }
                Console.Write("su numero tiene " + intentos + " digito(s)");
            }
            else
            {
                Console.WriteLine("Su numero tiene 1 digito");
            }   
        }
    }
}