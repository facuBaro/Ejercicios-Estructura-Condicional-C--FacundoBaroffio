internal class Program
{
    private static void Main(string[] args)
    {
        /*Ingresar un numero positivo del 1 al 99, y determinar si tiene 2 digitos, teniendo en cuenta caracteristicas de los numeros con 2 digitos.*/
        int numero;
        Console.WriteLine("Ingrese el numero a analizar");
        numero = Convert.ToInt32(Console.ReadLine());
        if(numero<=99 && numero >= 10)
        {
            Console.WriteLine("El numero "+numero+" tiene 2 digitos");

        }
        else
        {
            Console.WriteLine("El numero " + numero + " NO tiene 2 digitos");
        }
        Console.ReadKey();
    }
}