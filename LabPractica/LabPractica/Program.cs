using System; 

class CGF
{
    public static void Main(string[] args)
    {
        Ejercicio10();
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
        int a; int total; 
        total = 0;

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("Ingrese un valor");
            cadena = Console.ReadLine(); 
            a = Convert.ToInt32(cadena);
            total += a; 
        }

        Console.WriteLine("El total de la suma es {0}", total); 
        Console.ReadKey();
    }

    public static void Ejercicio6()
    {
        string cadena;
        int legajo; int sueldo; int total; int contador;
        float promedio;
        total = contador = 0;
        promedio = 0;
        Console.WriteLine("Ingrese el legajo");
        cadena = Console.ReadLine();
        legajo = Convert.ToInt32(cadena);
        
        while(legajo != 0)
        {
            Console.WriteLine("Ingrese el sueldo");
            cadena = Console.ReadLine(); 
            sueldo = Convert.ToInt32(cadena);
            total += sueldo;
            contador++;
            Console.WriteLine("Ingrese el legajo");
            cadena = Console.ReadLine();
            legajo = Convert.ToInt32(cadena); 
        }

        Console.WriteLine("El total pagado es {0}", total);
        Console.ReadKey();
        promedio = (float)(total / contador);
        Console.WriteLine("El sueldo promedio es {0, 2:F2}", promedio);
        Console.ReadKey();
    }

    public static void Ejercicio7() 
    {
        string cadena; 
        int[] vecval = Enumerable.Repeat(0, 5).ToArray();
        int categoria, legajo, horas, sueldo, total;
        total = 0; 

        for (int j = 0; j < 4 ; j++)
        {
            Console.WriteLine("Ingrese el valor de la hora de la categoría {0}", j);
            cadena = Console.ReadLine(); 
            vecval[j] = Convert.ToInt32(cadena);
        }

        Console.WriteLine("Ingrese el número de legajo");
        cadena = Console.ReadLine();
        legajo = Convert.ToInt32(cadena); 

        while(legajo != 0)
        {
            Console.WriteLine("Ingrese el nro de categoría");
            cadena = Console.ReadLine(); 
            categoria = Convert.ToInt32(cadena);
            Console.WriteLine("Ingrese el nro de horas trabajadas");
            cadena = Console.ReadLine(); 
            horas = Convert.ToInt32(cadena);
            sueldo = horas * vecval[categoria];
            Console.WriteLine("El legajo {0} cobrará {1}", legajo, sueldo);
            total += sueldo;
            Console.WriteLine("Ingrese nro de legajo");
            cadena = Console.ReadLine();
            legajo = Convert.ToInt32(cadena); 
        }

        Console.WriteLine("El total a pagar por sueldos es {0}", total);
        Console.ReadKey();
    }

    public static void Ejercicio8() 
    {
        string cadena;
        int[] vecval = Enumerable.Repeat(0, 5).ToArray(); int[] veccant = Enumerable.Repeat(0, 5).ToArray();
        int cat, leg, hs, sdo, tot;
        tot = 0;

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("Ingrese el valor de las horas de la categoría {0}", i);
            cadena = Console.ReadLine(); 
            vecval[i] = Convert.ToInt32(cadena);
        }

        Console.WriteLine("Ingrese el nro de legajo"); 
        cadena = Console.ReadLine();
        leg = Convert.ToInt32(cadena);

        while (leg != 0)
        {
            Console.WriteLine("Ingrese el nro de categoría");
            cadena = Console.ReadLine(); 
            cat = Convert.ToInt32(cadena);
            Console.WriteLine("Ingrese el nro de horas trabajadas");
            cadena = Console.ReadLine();
            hs = Convert.ToInt32(cadena);
            sdo = hs * vecval[cat];
            Console.WriteLine("El legajo {0} cobrará {1}", leg, sdo);
            tot += tot + sdo; veccant[cat] = veccant[cat] + 1;
            Console.WriteLine("Ingrese el nro de legajo");
            cadena = Console.ReadLine();
            leg = Convert.ToInt32(cadena); 
        }

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("De la categoría {0} hay {1} empleados", i, veccant[i]);
        }

        Console.WriteLine("El total a pagar por sueldos es de {0}", tot);
        Console.ReadKey();

    }
    public static void Ejercicio9() 
    {
        string cadena;
        int[,] matriz = new int[5, 5];
        int cat, dep, hs;

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("Ingrese el valor de la hora de la categoría {0}", i);
            cadena = Console.ReadLine();
            cat = Convert.ToInt32(cadena);

            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine("Ingrese el nro de departamento");
                cadena = Console.ReadLine();
                dep = Convert.ToInt32(cadena);
                Console.WriteLine("Ingrese el nro de horas trabajadas");
                cadena = Console.ReadLine();
                hs = Convert.ToInt32(cadena);
                matriz[cat, dep] = matriz[cat, dep] + hs; 
            }
        }

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine("categoría {0} depto {1} horas {2} \n", i, j, matriz[i, j]);
            }
        }

        Console.ReadKey();
    }
    public static void Ejercicio10() 
    {
        int[] PRECIO = new int[7] { 10, 20, 30, 4, 5, 6, 7};
        int MONTOTOTAL = 0, monto;
        int tkmax = 0, montomax = 0, A = 0, cat, moto, motomax;
        int tk;
        int cant;
        int[] M = new int[5];
        int motomin;
        int prom = 0;
        int pora = 0;
        Console.WriteLine("Ingrese el nro de ticket");
        tk = Convert.ToInt32(Console.ReadLine());

        while(tk != 0)
        {
            Console.WriteLine("Ingrese la categoría de pizza (de 1 a 6)");
            cat = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad"); 
            cant = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la moto");
            moto = Convert.ToInt32(Console.ReadLine());
            monto = cant * PRECIO[cat];

            if (tkmax == 0)
            {
                tkmax = tk;
                motomax = moto;
                montomax = monto; 
            }
            else
            {
                if(monto > tkmax)
                {
                    tkmax = tk;
                    motomax = moto;
                    montomax = monto;
                }
            }
            M[moto]++;
            MONTOTOTAL = MONTOTOTAL + monto; 
            M[0]++;
            
            if(cat == 1)
            {
                A++; 
            }

            Console.WriteLine("INGRESE NRO DE TICKET");
            tk = Convert.ToInt32(Console.ReadLine());
        }

        prom = MONTOTOTAL / M[0];
        pora = A / M[0];
        motomin = 1;
        for (int i = 0; i < 4; i++)
        {
            if (M[i] < M[motomin])
            {
                motomin = i;
            }
        }

        Console.WriteLine("El ticket {0} de valor: {1} es el de mayor importe", tkmax, montomax);
        Console.WriteLine("La moto {0} es la que hizo menos viajes", motomin);
        Console.WriteLine("El valor promedio de los viajes es {0}", prom);
        Console.WriteLine("El porcentaje de pedidos de pizzas categoria A es {0}", pora);
        Console.WriteLine("La facturación total del negocio es {0}", MONTOTOTAL);
        Console.ReadKey();
    }
}