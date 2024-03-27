using System;

class MainClass
{
    public static void Main(string[] args)
    {
        double hipotenusa,cateto1 ,cateto2;
        Console.Write("Calculadora de hipotenusa!");
        Console.WriteLine();
        Console.Write("digite um valor para o primeiro cateto: ");
        cateto1 = double.Parse(Console.ReadLine());
        Console.Write("digite um valor para o segundo cateto: ");
        cateto2 = double.Parse(Console.ReadLine());

        hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));

        Console.Write("hipotenusa = " + hipotenusa);
    }
}