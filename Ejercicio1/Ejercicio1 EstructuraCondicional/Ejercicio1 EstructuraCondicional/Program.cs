internal class Program
{
    private static void Main(string[] args)
    {
        /*Realizar un programa que pida 2 numeros, si el primero es mayor informar su suma y diferencia,sino informar el producto
         y la division del primero respecto al segundo.*/
        double num1, num2;
       
        Console.WriteLine("Ingrese el primer numero");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.Clear();

        if (num1 > num2)
        {            Console.WriteLine("La suma entre " + num1 + " y " + num2 + " da como resultado: " + Convert.ToString(num1 + num2));
            Console.WriteLine("La diferencia entre " + num1 + " y " + num2 + " da como resultado: " + Convert.ToString(num1 - num2));
        }
        else
        {
            Console.WriteLine("El producto entre " + num1 + " y " + num2 + " da como resultado: " + Convert.ToString(num1 * num2));
            Console.WriteLine("La division entre " + num1 + " y " + num2 + " da como resultado: " + Convert.ToString(num1 / num2));
        }
        Console.ReadKey();
    }
}