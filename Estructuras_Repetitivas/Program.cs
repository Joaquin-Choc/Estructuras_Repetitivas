// See https://aka.ms/new-console-template for more information
class Ejercicios
{
    //forma 1
    public void Metodo1()
    {
        int n = 0;

        do
        {
            Console.WriteLine("Ingrese un número entero positivo");
            n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine(n + " Es par");
            }
            else
            {

            }
        } while (n != 99);
    } 
    //metodo 2
    public void Metodo2()
    {
        Console.WriteLine("Ingrese un número");
        int a = Convert.ToInt32(Console.ReadLine());
        string fila = "";
        for (int i = 1; i <= a;i++)
        {
            fila = fila + "" + i;
            Console.WriteLine(fila);
        }
    }
    //metodo 3
    public void Metodo3()
    {
        Console.WriteLine("Metodo 3");
        int suma = 0;
        for (int i = 100; i <= 200; i++)
        {
            if (i % 9 == 0)
            {
                Console.WriteLine(i);
                suma = suma + i;
            }
            else
            {
                
            }
        }
        Console.WriteLine(suma);
    }

    public void Metodo4()
    {
        Console.WriteLine("ingrese un número entero positivo");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + ": ");
            for (int j = 1; j < 11; j++)
            {
                Console.Write((i * j) + "\t");
            }
            Console.Write("\n");
        }
    }

    static void Main()
    {
         //pruebas
        Ejercicios P = new Ejercicios();
        P.Metodo1();
        P.Metodo2();
        P.Metodo3();
        P.Metodo4();

    }
}
