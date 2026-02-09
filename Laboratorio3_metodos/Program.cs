namespace Laboratorio3_metodos
{
    using System;

    class Program
    {
        
        static void MostrarMenu()
        {
            Console.WriteLine("===== MENÚ DE OPCIONES =====");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
        }

        static double Sumar(double a, double b)
        {
            return a + b;
        }

        static double Restar(double a, double b)
        {
            return a - b;
        }

        static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        static double Dividir(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: no se puede dividir entre cero.");
                return 0;
            }
            return a / b;
        }

        static void Main(string[] args)
        {
            int opcion;
            double num1, num2, resultado;

            do
            {
                MostrarMenu();
                opcion = int.Parse(Console.ReadLine());

                if (opcion >= 1 && opcion <= 4)
                {
                    Console.Write("Ingrese el primer número: ");
                    num1 = double.Parse(Console.ReadLine());

                    Console.Write("Ingrese el segundo número: ");
                    num2 = double.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            resultado = Sumar(num1, num2);
                            Console.WriteLine("Resultado: " + resultado);
                            break;

                        case 2:
                            resultado = Restar(num1, num2);
                            Console.WriteLine("Resultado: " + resultado);
                            break;

                        case 3:
                            resultado = Multiplicar(num1, num2);
                            Console.WriteLine("Resultado: " + resultado);
                            break;

                        case 4:
                            resultado = Dividir(num1, num2);
                            Console.WriteLine("Resultado: " + resultado);
                            break;
                    }
                }
                else if (opcion != 5)
                {
                    Console.WriteLine("Opción inválida.");
                }

                Console.WriteLine();
            }
            while (opcion != 5);

            Console.WriteLine("Programa finalizado.");
        }
    }
}
