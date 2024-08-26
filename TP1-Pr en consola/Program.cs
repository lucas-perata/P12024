using System;

class CGF
{
    public static void Main(string[] args)
    {
        // Ejercicio1();
        // Ejercicio2();
        // Ejercicio3();
        // Ejercicio4();
        // Ejercicio5();
        // Ejercicio6();
        // Ejercicio7();
        // Ejercicio8();
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
        int a, b, c;
        int perimetro = 0;

        Console.WriteLine("Ingrese lado a: "); 
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese lado b: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese lado c: "); 
        c = Convert.ToInt32(Console.ReadLine());

        perimetro = a + b + c;

        Console.WriteLine("El perímetro es {0}", perimetro);
        Console.ReadKey();
    }

    public static void Ejercicio4()
    {
        int a;
        int superficie = 0;

        Console.WriteLine("Ingrese la medida del lado del cuadrado"); 
        a = Convert.ToInt32(Console.ReadLine());

        superficie = a * a;

        Console.WriteLine("La superficie es {0}", superficie); 
        Console.ReadKey();
    }

    public static void Ejercicio5()
    {
        int Largo, Ancho;
        int Superficie;

        Console.WriteLine("Ingresa el ancho de un rectángulo");
        Ancho = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa el largo de un rectángulo"); 
        Largo = Convert.ToInt32(Console.ReadLine());

        Superficie = Largo * Ancho;

        Console.WriteLine("La superficie es {0}", Superficie); 
        Console.ReadKey();
    }

    public static void Ejercicio6()
    {
        double Diametro; 
        double PI = 3.14;

        Console.WriteLine("Ingrese la circunferencia: ");
        Diametro = Convert.ToInt32(Console.ReadLine()) / PI;

        Console.WriteLine("El diámetro es {0}", Diametro);
        Console.ReadKey();
    }

    public static void Ejercicio7()
    {
        // Cada 1KB hay 1000 Bytes y en cada 1 Byte hay 8 bits 
        int Bits, KBytes;

        Console.WriteLine("Ingrese una cantidad de KBytes");
        KBytes = Convert.ToInt32(Console.ReadLine());
        Bits = (KBytes *1000) * 8;

        Console.WriteLine("Hay {0} bytes en {1} KBytes", Bits, KBytes);
        Console.ReadKey();
    }

    public static void Ejercicio8()
    {
        int Resultado = 1;
        int N = 0; 

        Console.WriteLine("Ingrese un número para calcular factorial");
        N = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <=N; i++) 
        {
            Resultado *= i;
            Console.WriteLine("{0}", Resultado);
        }

        Console.WriteLine("El factorial de {0} es {1}", N, Resultado); 
        Console.ReadKey();

    }

    public static void Ejercicio9() { }
    public static void Ejercicio10() { }
    public static void Ejercicio11() { }
    public static void Ejercicio12() { }
    public static void Ejercicio13() { }
    public static void Ejercicio14() { }
    public static void Ejercicio15() { }

}