namespace laboratorio_1
{
    using System;

    class Program
    {
        
        static void SaludarEstudiante(string nombre)
        {
            Console.WriteLine($"Hola {nombre}, bienvenido al laboratorio de programación.");
        }

        
        static double CalcularAreaRectangulo(double baseRect, double altura)
        {
            return baseRect * altura;
        }

        static void Main(string[] args)
        {
            
            Console.Write("Ingrese el nombre del estudiante: ");
            string nombre = Console.ReadLine();
            SaludarEstudiante(nombre);

            
            Console.Write("\nIngrese la base del rectángulo: ");
            double baseRect = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la altura del rectángulo: ");
            double altura = double.Parse(Console.ReadLine());

            double area = CalcularAreaRectangulo(baseRect, altura);
            Console.WriteLine($"El área del rectángulo es: {area}");

            Console.ReadKey();
        }
    }
}
