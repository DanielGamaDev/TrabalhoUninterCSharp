using System;
using System.Threading;
using ThreadsNumerosPrimos;



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Feito pelo aluno Daniel Gama - RU 4121047");
        Console.WriteLine();
        Console.Write("Digite o RU do aluno: ");
        int ruAluno = int.Parse(Console.ReadLine());        // Recebe o RU do aluno
        Console.WriteLine();
        Console.WriteLine($"Os números primos entre 0 e {ruAluno} são: ");
        Console.WriteLine();

        Thread[] threads = new Thread[(ruAluno / 10) + 1]; // Criando uma matriz de threads dos tamanhos necessários

        for (int i = 0; i <= ruAluno; i += 10)
        {
            int start = i;
            int end = Math.Min(i + 9, ruAluno);
            ThreadPrimos primoThread = new ThreadPrimos(start, end);
            threads[i / 10] = new Thread(primoThread.Run);
            threads[i / 10].Start();
        }

        foreach (var thread in threads)    // Loop que inicia cada thread
        {
            thread.Join();
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Encerrando o programa... "); 
        Console.WriteLine();
    }
}
