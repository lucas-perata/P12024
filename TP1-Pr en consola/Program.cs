using System;

class CGF
{
    public static void Main(string[] args)
    {
        // Ejercicio1();
        // Ejercicio2();
    }

    public static void Ejercicio1()
    {
        int a, b;
        int resultado = 0;

        Console.WriteLine("Ingrese un número: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese otro número: ");
        b = Convert.ToInt32(Console.ReadLine());

        resultado = a + b;

        Console.WriteLine("El resultado de la suma es {0}", resultado);
        Console.ReadKey();
    }

    public static void Ejercicio2()
    {
        int a, b;
        int resultado = 0;

        Console.WriteLine("Ingrese un número: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese otro número: ");
        b = Convert.ToInt32(Console.ReadLine());

        resultado = a - b;

        Console.WriteLine("Hay {0} números entre los dos valores", resultado);
        Console.ReadKey();
    }

    public static void Ejercicio3()
    {

    }

}