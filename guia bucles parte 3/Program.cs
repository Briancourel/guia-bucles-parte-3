using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_bucles_parte_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PUNTO UNO, PARES DEL 1 AL 50 



            /*   for ( int cont1 = 1;cont1 <= 50; cont1++)
               { 
                 if ( cont1 % 2 == 0 )

                Console.WriteLine(cont1);
               }

               // PUNTO DOS, SUMA DE LOS NUMEROS DEL 1 AL 100

               int suma = 0;

               for ( int Cont2 = 1; Cont2 <= 100; Cont2++)
               {
                   suma += Cont2;

               }
               Console.WriteLine(" la suma de los numero del 1 al 100 es " + suma);

              //PUNTO TRES, TABLA DE MULTIPLICAR DE UN NUMERO

              //en este punto vamos a multiplicar el 8

              for (int i = 0; i <= 80; i += 8)   
              {
               Console.WriteLine(i);
              }


              //PUNTO CUATRO, FACTORIAL DE UN NUMERO

              int numero = 0;

              Console.WriteLine(" ingrese un numero");
              numero = Convert.ToInt32(Console.ReadLine());

              int factorial = 1;


              for (int x = 1; x <= numero; x++ ) 
              { 
               factorial *= x ;
              }
              Console.WriteLine(" el factorial de " + numero + " es " + factorial);



            // PUNTO SEIS, NUMEROS PRIMOS DEL 1 AL 100

            string oracion;
            int contVocales = 0;
            Console.WriteLine(" ingrese una oracion");
            oracion = Console.ReadLine(); 

            oracion = oracion.ToLower();

            for (int x= 0; x < oracion.Length; x++) 
            {
                if (oracion[x] == 'a' || oracion[x] == 'e' || oracion[x] == 'i' ||
                    oracion[x] == 'o' || oracion[x] == 'u')
                {  
                    contVocales++; 
                }

            }
            Console.WriteLine(" la oracion ingresada tiene " + contVocales + " vocales");

             for (int i = 2; i <= 100; i++) 
              {
                  bool esPrimo = true;

                  for (int x = 2; x <= i; x++)
                  {
                      if (i % x == 0)
                      {
                          esPrimo = false;
                      }
                      break;
                  }

                  if (esPrimo)
                  {
                      Console.WriteLine(i + "");
                  }


              //PUNTO SIETE, NUMEROS FIBONACCI

              int anterior = 0;
              int actual = 1;

              Console.WriteLine(" secuencia de numeros fibonacci");
              Console.WriteLine(anterior + " " + actual + " ");

              for (int i = 2; i < 10; i++)
              {
                  int siguiente = anterior + actual;

                  Console.WriteLine(siguiente + " ");
                  actual = siguiente;
                  anterior = siguiente;

              }

              int limite = 10; // Cambia esto al número de términos de Fibonacci que se desea calcular

              int anterior = 0;
              int actual = 1;

              Console.WriteLine("Secuencia de Fibonacci:");

              Console.Write(anterior + " " + actual + " ");

              for (int i = 2; i < limite; i++)
              {
                  int siguiente = anterior + actual;
                  Console.Write(siguiente + " ");

                  anterior = actual;
                  actual = siguiente;
              }

            // PUNTO OCHO, DETERMINAR SI UN AÑO ES BISIESTO

            int año = 0;
            int esBisiesto;
            int NoEsBisiesto;

            Console.Write(" ingrese el año para saber si es bisiesto o no: "); 
            año = int.Parse(Console.ReadLine());

            if ( año % 4 == 0 && año % 100 != 0 || año % 400 == 0  )
            {
                Console.WriteLine(" es un año Bisiesto");
            }
            else 
            {
                Console.WriteLine(" No es un año Bisiesto ");
            }

            //PUNTO NUEVE, INVERTIR UNA CADENA

             string palabra = "";
              string palabraInversa = "";

              Console.WriteLine( "ingrese una palabra");
              palabra = Console.ReadLine();

              for (int x = palabra.Length -1; x >= 0; x--)
              {
                  palabraInversa += palabra[x];
              }
              Console.WriteLine(palabraInversa);

              //PUNTO DIEZ, CALCULAR POTENCIA DE UN NUMERO

              int bas = 0;
              int expo = 0;
              int result = 1;

              Console.WriteLine(" ingrese el numero base"); 
              bas = int.Parse(Console.ReadLine());
              Console.WriteLine(" ingrese el exponente"); 
              expo= int.Parse(Console.ReadLine());

              for ( int i = 0; i < expo; i++) 
              {
                result = result * bas;

              }

              Console.WriteLine(result);

              // PUNTO ONCE, CONTAR DIGITOS DE UN NUMERO


              int num = 0;

              int i = 0;

              Console.WriteLine(" ingrese el numero");
              num = int.Parse(Console.ReadLine());

              while ( num >= 1)
              {
                  num = num / 10 ;
                  i++;

              }
              Console.WriteLine(" el numero tiene " + i + " digitos");


              //PUNTO DOCE, SUMA DE DIGITOS DE UN NUMERO


              int num;
              int digits = 0;
              int i = 0;
              int sumaDigitos = 0;

              Console.WriteLine(" ingrese el numero");
              num = int.Parse(Console.ReadLine());
              int aux = num;

              while ( num > 0)
              {
                  sumaDigitos = sumaDigitos + aux % 10;
                  aux = aux / 10;
                  num = num / 10 ;
                  i++;



              }
              Console.WriteLine(" el numero tiene " +  sumaDigitos);

            // PUNTO TRECE, CONVERTIR TEMPERATURAS


            double temp = 0;
            int seleccion = 0;
            int selec = 1;

            while (selec != 0 ) // opte por hacerlo con while porque no encontre forma de hacelo con for
            {

                Console.WriteLine(" ingrese la temperatura");
                temp = double.Parse(Console.ReadLine());

                Console.WriteLine(" seleccione a que temperatura desea convertir ");
                Console.WriteLine("1) celsius ");
                Console.WriteLine("2) fahrenheit ");
                seleccion = int.Parse(Console.ReadLine());


                switch (seleccion)
                {
                    case 1:
                        temp = (temp - 32) * 5 / 9;
                        Console.WriteLine(" la temperatura en Celsius es: " + temp);
                        break;
                    case 2:
                        temp = (temp * 9 / 5) + 32;
                        Console.WriteLine(" la temperatura en Fahrenheit es: " + temp);
                        break;
                    default: Console.WriteLine(" numero invalido "); break;
                }


                Console.WriteLine(" si desea realizar mas conversiones precione 1 para finalizar precione 0 ");
                selec = int.Parse(Console.ReadLine());

            }




            // PUNTO CATORCE, DETERMINAR EL DIA DE LA SEMANA 

            int selec = 1;

            while (selec != 0) // me cuesta mucho lograr hacerlo con for
            {

                Console.WriteLine("ingrese un numero para elegir el dia de la semana");

                Console.WriteLine(" 1 ");
                Console.WriteLine(" 2 ");
                Console.WriteLine(" 3 ");
                Console.WriteLine(" 4 ");
                Console.WriteLine(" 5 ");
                Console.WriteLine(" 6 ");
                Console.WriteLine(" 7 ");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine(" el dia es lunes");
                        break;
                    case 2:
                        Console.WriteLine("el dia es martes");
                        break;
                    case 3:
                        Console.WriteLine("el dia es miercoles");
                        break;
                    case 4:
                        Console.WriteLine("el dia es jueves");
                        break;
                    case 5:
                        Console.WriteLine("el dia es viernes");
                        break;
                    case 6:
                        Console.WriteLine("el dia es sabado");
                        break;
                    case 7:
                        Console.WriteLine("el dia es domingo");
                        break;
                    default:
                        Console.WriteLine(" opcion incorrecta");
                        break;
                }


                Console.WriteLine(" si desea realizar mas conversiones precione 1 para finalizar precione 0 ");
                selec = int.Parse(Console.ReadLine());
            }

            // PUNTO QUINCE, CONTAR PALABRAS EN UNA CADENA 

            int palabras = 1;
            string oracion;

            Console.WriteLine(" ingrese la oracion");
            oracion = Console.ReadLine();

            for (int i = 0; i < oracion.Length; i++)
            {
                if (oracion[i] == ' ' && i++ < oracion.Length &&  oracion[i++] != ' ' )
                {
                    palabras++;
                }
               
            }

            

            Console.WriteLine(" la oracion tiene " + palabras + " palabras");*/























        }
    }
}
