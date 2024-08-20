using System; 

class CGF
{
    public static void Main(string[] args)
    {
        Ejercicio5();
    }
    public static void Ejercicio1(string[] args)
    {
        int a = 10; float b; float c;
        b = (float)30.5; 
        c = (float)(a+b);
        Console.WriteLine("{0}+{1}={2}", a, b, c);
        Console.ReadKey();
    }

    public static void Ejercicio2()
    {
        int a = 2; int b = 2;
        if (a == b) { Console.WriteLine("Son iguales"); Console.ReadKey(); }
    }

    public static void Ejercicio3()
    {
        string cadena;
        int a, b, c;
        Console.WriteLine("Ingrese valor hora"); 
        cadena = Console.ReadLine();
        a = Convert.ToInt32(cadena);
        Console.WriteLine("Ingrese el tiempo trabajado");
        cadena = Console.ReadLine();
        b = Convert.ToInt32(cadena);
        c = a * b;
        Console.WriteLine("EL sueldo es {0}", c);
        Console.ReadKey();
    }

    public static void Ejercicio4()
    {
        string cadena;
        int a, b;

        Console.WriteLine("Ingrese un valor"); 
        cadena = Console.ReadLine();
        a = Convert.ToInt32(cadena);
        Console.WriteLine("Ingrese otro valor"); 
        cadena = Console.ReadLine();
        b = Convert.ToInt32(cadena);

        if(a == b) 
        { 
            Console.WriteLine("Son iguales");
            Console.ReadKey();
        } else
        {
            Console.WriteLine("Los valores son diferentes");
            if(a < b) { Console.WriteLine("Es menor -> {0}", a); }
            else { Console.WriteLine("Es menor -> {0}", b); }
        }
    }

    public static void Ejercicio5()
    {
        string cadena;
        int a; int tot; int i;
        tot = 00;

        for (int j = 0; j < 4; j++)
        {
            Console.WriteLine("Ingrese un valor");
            cadena = Console.ReadLine(); 
            a = Convert.ToInt32(cadena);
            tot += a; 
        }

        Console.WriteLine("El total de la suma es {0}", tot); 
        Console.ReadKey();
    }
}