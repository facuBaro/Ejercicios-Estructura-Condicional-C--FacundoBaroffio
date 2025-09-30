internal class Program
{
    private static void Main(string[] args)
    {
        /*Ingresar 3 notas de 1 alumno, si promedio>=7 ->Promocionado */
        double nota1, nota2, nota3,promedio;
        Console.WriteLine("Ingrese la primer nota");
        nota1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese la segunda nota");
        nota2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese la tercera nota");
        nota3 = Convert.ToDouble(Console.ReadLine());

        promedio = (nota1 + nota2 + nota3) / 3;
        Console.Clear();
        if (promedio >= 7)
        {
            Console.WriteLine("El alumno esta Promocionado");
            Console.WriteLine("Promedio: " + promedio);
        }
        else
        {
            Console.WriteLine("El no alumno esta Promocionado");
            Console.WriteLine("Promedio: " + promedio);
        }
        Console.ReadKey();
    }
}