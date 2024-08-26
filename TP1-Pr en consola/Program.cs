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
        // Ejercicio9();
        // Ejercicio10();
        // Ejercicio11();
        // Ejercicio12();
        // Ejercicio13();
         Ejercicio14();
        //Ejercicio15();
    }

    public static void Ejercicio1()
    {
        int A, B;
        int Resultado = 0;

        Console.WriteLine("Ingrese un número: ");
        A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese otro número: ");
        B = Convert.ToInt32(Console.ReadLine());

        Resultado = A + B;

        Console.WriteLine("El resultado de la suma es {0}", Resultado);
        Console.ReadKey();
    }

    public static void Ejercicio2()
    {
        int A, B;
        int Resultado = 0;

        Console.WriteLine("Ingrese un número: ");
        A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese otro número: ");
        B = Convert.ToInt32(Console.ReadLine());

        Resultado = A - B;

        Console.WriteLine("Hay {0} números entre los dos valores", Resultado);
        Console.ReadKey();
    }

    public static void Ejercicio3()
    {
        int A, B, C;
        int Perimetro = 0;

        Console.WriteLine("Ingrese lado a: "); 
        A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese lado b: ");
        B = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese lado c: "); 
        C = Convert.ToInt32(Console.ReadLine());

        Perimetro = A + B + C;

        Console.WriteLine("El perímetro es {0}", Perimetro);
        Console.ReadKey();
    }

    public static void Ejercicio4()
    {
        int A;
        int Superficie = 0;

        Console.WriteLine("Ingrese la medida del lado del cuadrado"); 
        A = Convert.ToInt32(Console.ReadLine());

        Superficie = A * A;

        Console.WriteLine("La superficie es {0}", Superficie); 
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

    public static void Ejercicio9() 
    {
        string Cadena1, Cadena2, Concat;

        Console.WriteLine("Ingresa una frase: "); 
        Cadena1 = Console.ReadLine();
        Console.WriteLine("Ingresa otra frase: "); 
        Cadena2 = Console.ReadLine();

        Concat = Cadena1 + Cadena2;

        Console.WriteLine("{0}", Concat);
        Console.ReadKey();

    }
    public static void Ejercicio10() 
    {
        string Cadena;
        string CadenaA, CadenaB; 

        Console.WriteLine("Ingrese una frase: ");
        Cadena = Console.ReadLine();

        CadenaB = Cadena.Substring(Cadena.Length / 2);
        CadenaA = Cadena.Substring(0, Cadena.Length/2);

        Console.WriteLine("{0} {1}", CadenaB, CadenaA);
        Console.ReadKey();
    }
    public static void Ejercicio11() 
    {
        string Cadena;

        Console.WriteLine("Ingresa una frase: "); 
        Cadena = Console.ReadLine();

        Console.WriteLine("Tiene {0} caracteres", Cadena.Length);
        Console.ReadKey();
    }
    public static void Ejercicio12() 
    {
        DateTime DT = DateTime.Now;

        Console.WriteLine("{0}", DT);
        Console.ReadKey();
    }
    public static void Ejercicio13() 
    {
        DateTime DT;
        int year, month, day;

        Console.WriteLine("Ingresa un año: ");
        year = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa un mes: "); 
        month = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa un día: "); 
        day = Convert.ToInt32(Console.ReadLine());

        DT = new DateTime(year, month, day);

        Console.WriteLine("{0}", DT.ToShortDateString());
        Console.ReadKey();
    }
    public static void Ejercicio14() 
    {
        DateTime DT1;
        DateTime DT2; 
        int YearA, MonthA, DayA;
        int YearB, MonthB, DayB;
        int Diferencia = 0; 

        Console.WriteLine("Ingresa día a: ");
        DayA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa mes a: ");
        MonthA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa año a: ");
        YearA = Convert.ToInt32(Console.ReadLine());

        DT1 = new DateTime(YearA, MonthA, DayA);

        Console.WriteLine("Ingresa día b: ");
        DayB = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa mes b: ");
        MonthB = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa año b: ");
        YearB = Convert.ToInt32(Console.ReadLine());

        DT2 = new DateTime(YearB, MonthB, DayB);

        Diferencia = DT1 > DT2 ? (DT1 - DT2).Days : (DT2 - DT1).Days;

        Console.WriteLine("La diferencia de días es {0}", Diferencia);
        Console.ReadKey();
    }
    public static void Ejercicio15() 
    {
        DateTime Navidad = new DateTime(2024, 12, 25);
        DateTime Hoy = DateTime.Now;
        int CuentaRegresiva = 0;

        CuentaRegresiva = (Navidad - Hoy).Days;

        Console.WriteLine("Faltan {0} días para navidad", CuentaRegresiva);
        Console.ReadKey();
    }

}