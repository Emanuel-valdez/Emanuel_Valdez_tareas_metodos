namespace laboratorio_2
{
    using System;

    class Program
    {
        static double CalcularPromedio(double c1, double c2, double c3, double c4)
        {
            double promedio = (c1 + c2 + c3 + c4) / 4;
            return promedio;
        }

        static void Main(string[] args)
        {
            Console.Write("Ingrese la primera calificación: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la segunda calificación: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la tercera calificación: ");
            double nota3 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la cuarta calificación: ");
            double nota4 = double.Parse(Console.ReadLine());

            double promedio = CalcularPromedio(nota1, nota2, nota3, nota4);

            Console.WriteLine($"El promedio es {promedio}");

            if (promedio >= 70)
            {
                Console.WriteLine("Estado: Aprobado");
            }
            else
            {
                Console.WriteLine("Estado: Reprobado");
            }

            Console.ReadKey();
        }
    }
}
