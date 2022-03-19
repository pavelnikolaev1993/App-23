class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число для вычисления факториала:");
        int n = Convert.ToInt32(Console.ReadLine());
        FaktorAsync(n);

        Console.ReadKey();


    }
    static void Faktor(int n)
    { 
    int s = 1;
        for (int i = 1; i < n+1; i++)
        {
            s *= i;
            Thread.Sleep(100);
        }
        Console.WriteLine("Факториал числа {0} равен {1}", n, s );   
    }
    static async void FaktorAsync(int n)
    {
       await Task.Run(() => Faktor(n));
    }
 
}