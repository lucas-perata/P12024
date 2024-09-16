using System.Collections.Concurrent;

class RecursividadClass
{
    static void Main(string[] args)
    {
        int n = 0;
        Console.WriteLine("Ingresa un número: ");
        n = Convert.ToInt32(Console.ReadLine());

        int[] vector = {1, 9, 3, 5, 4};
        int len = vector.Length;

        // Ejercicio1(n);
        // Console.WriteLine(Ejercicio2(n));
        ImprimirArray(vector);
        Ejercicio3(vector, 0, len-1);
        ImprimirArray(vector);
    }

    static void Ejercicio1(int n) 
    {
        Console.WriteLine(n);
        if(n == 1) { Console.ReadKey();  }
        Ejercicio1(n - 1);
    }

    static int Ejercicio2(int n)
    {
        if(n == 0) {  return 1; }
        return n * Ejercicio2(n -1);
    }

    static void Ejercicio3(int[] nums, int low, int high)
    {
        // Quicksort 
        if(low < high)
        {
            int pi = Particion(nums, low, high);

            Ejercicio3(nums, low, pi - 1);
            Ejercicio3(nums, pi + 1, high);
        }
        
    }

    static int Particion(int[] nums, int low, int high)
    {
        int pivot = nums[high];
        int i = (low - 1); 

        for(int j = low; j < high; j++)
        {
            if (nums[j] <= pivot)
            {
                i++;
                Swap(nums, i, j);
            }
        }

        Swap(nums, i+1, high);
        return i + 1; 
    }

    static void Swap(int[] nums, int i, int j)
    {
        int temp = nums[i]; 
        nums[i] = nums[j];
        nums[j] = temp;
    }

    static void ImprimirArray(int[] nums)
    {
        foreach(int n in nums)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine();
    }
}