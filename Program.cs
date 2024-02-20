using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioOperadores__Jose_Mendoza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             CALCULADORA: SUMA, RESTA, MULTIPLICACION Y DIVISION, POTENCIASION E INCLUIDO EN EL MENU DE OPCIONES LA OPCION SALIR. 
            1. SUMA
            2. RESTA
            3. MULTIPLICACION
            4. DIVISION.
            5. SALIR.
             */
            Console.WriteLine("|-----------WELCOME TO MY CALCULATOR----------|");
            Console.WriteLine("|-------UNIVERSIDAD DOCTOR ANDRES BELLO-------|");
            Console.WriteLine("|-----FACULTAD DE TECNOLOGIA E IMNOVACION-----|");
            Console.WriteLine("|--------------PROGRAMACION lll---------------|");
            Console.WriteLine("|---------JOSE RIGOBERTO MENDOZA RIVAS--------|");


            int opcion = 0;
            double Num1;
            double Num2;


            while (opcion != 6)
            {
                
                Console.WriteLine("============FAVOR SELECCIONAR LA OPERACION QUE DESEA REALIZAR==============");
                Console.WriteLine(" 1. SUMA ");
                Console.WriteLine(" 2. RESTA ");
                Console.WriteLine(" 3. MULTIPLICACION");
                Console.WriteLine(" 4. DIVISION. ");
                Console.WriteLine(" 5. POTENCIA. ");
                Console.WriteLine(" 6. SALIR. ");

                opcion = Int32.Parse(Console.ReadLine());

                if (opcion == 1) 
                {
                    Console.Write("Ingrese el primer numero: ");
                    Num1 = Int32.Parse(Console.ReadLine());
                    Console.Write("Ingrese el segundo numero: ");
                    Num2 = Int32.Parse(Console.ReadLine());
                    suma(Num1, Num2);
                   

                }
                else if (opcion == 2) 
                {

                    Console.Write("Ingrese el primer numero: ");
                    Num1 = Int32.Parse(Console.ReadLine());
                    Console.Write("Ingrese el segundo numero: ");
                    Num2 = Int32.Parse(Console.ReadLine());
                    resta(Num1, Num2);
                   
                }
                else if (opcion == 3) 
                {
                    Console.Write("Ingrese el primer numero: ");
                    Num1 = Int32.Parse(Console.ReadLine());
                    Console.Write("Ingrese el segundo numero: ");
                    Num2 = Int32.Parse(Console.ReadLine());
                    multiplicacion(Num1, Num2);
                    
                }
                else if (opcion == 4)
                {
                    Console.Write("Ingrese el primer numero: ");
                    Num1 = Int32.Parse(Console.ReadLine());
                    Console.Write("Ingrese el segundo numero: ");
                    Num2 = Int32.Parse(Console.ReadLine());
                    division(Num1, Num2);
                    
                }
                else if (opcion == 5)
                {
                    Console.Write("Ingrese la base: ");
                    int baseNum = Int32.Parse(Console.ReadLine());
                    Console.Write("Ingrese el exponente: ");
                    int exponente = Int32.Parse(Console.ReadLine());
                    potencia(baseNum, exponente);
                   
                }
                else if (opcion == 6)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("La opción seleccionada no está disponible. Por favor, seleccione una opción válida.");
                    Console.WriteLine("Presione Enter para continuar...");
                    Console.ReadLine();
                }
                Console.WriteLine(" ");
                Console.WriteLine("presione cualquier tecla para continuar");              
                Console.ReadKey();          
                Console.Clear();
             
            }
        }
        static double suma(double pNum1, double pNum2)
        {
            double resultado = pNum1 + pNum2;
            Console.WriteLine("El resultado de la suma es: " + resultado.ToString("#.##"));
            return resultado;
            
        }
        static double resta( double pNum1, double pNum2)
        {
            double resultado = pNum1 - pNum2;
            Console.WriteLine("El resultado de la resta es: " + resultado.ToString("#.##"));
            return resultado;
        }

        static double multiplicacion(double pNum1, double pNum2)
        {
            double resultado = pNum1 * pNum2;
            Console.WriteLine("El resultado de la multiplicacion es: " + resultado.ToString("#.##"));
            return resultado;
        }

        static double division (double pNum1, double pNum2)
        {
            if (pNum2 == 0)
            {
                Console.WriteLine("Error matemático: No se puede dividir entre cero.");
                return 0; // Retorna 0 como valor predeterminado
            }

            double resultado = pNum1 / pNum2;
            Console.WriteLine("El resultado de la division es: " + resultado.ToString("#.##"));
            return resultado;
        }

        static double potencia(double baseNum, double exponente)
        {
            double resultado = (double)Math.Pow(baseNum, exponente);
            Console.WriteLine("El resultado de la potencia es: " + resultado.ToString("#.##"));
            return resultado;
        }
    }
}
