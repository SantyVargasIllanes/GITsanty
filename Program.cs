namespace GIT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, suma;
            Console.WriteLine("Ingrese el primer numero: ");
            num1 =int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero: ");
            num2=int.Parse(Console.ReadLine());

            suma = num1 + num2;
            Console.WriteLine("la suma es ", suma);
        }
    }
}