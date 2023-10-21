using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Aluno Daniel Gama - 4121047");
        Console.WriteLine("Vamos resolver a fórmula de BHASKARA"); // Apresenta a funcionalidade do programa
        Console.WriteLine("Informe os valores pedidos abaixo\n");  
        Console.Write("Valor de a: ");
        int a = int.Parse(Console.ReadLine());  // Solicita e lê o valor de 'a' do usuário
        Console.Write("Valor de b: ");
        int b = int.Parse(Console.ReadLine());  // Solicita e lê o valor de 'b' do usuário
        Console.Write("Valor de c: ");
        int c = int.Parse(Console.ReadLine());  // Solicita e lê o valor de 'c' do usuário
        int d = CalculaDelta(a, b, c);  // Chama a função para calcular o delta
        Tuple<int, int> resultadoX = CalculaX(a, b, d);  // Chama a função para calcular as raízes
        MostraResultado(resultadoX.Item1, resultadoX.Item2, d);  // Mostra os resultados
    }

    static int CalculaDelta(int a, int b, int c)
    {
        int delta = (b * b) - (4 * a * c);  // Calcula o delta
        return delta;
    }

    static Tuple<int, int> CalculaX(int a, int b, int delta) // Cria tupla para calcular e armazenar os valores de delta
    {
        if (delta >= 0 && a != 0)
        {
            int x1 = (-b + (int)Math.Sqrt(delta)) / (2 * a);  // Calcula a primeira raiz (Positiva)
            int x2 = (-b - (int)Math.Sqrt(delta)) / (2 * a);  // Calcula a segunda raiz (Negativa)
            return Tuple.Create(x1, x2);  // Retorna as raízes como uma tupla
        }
        else
        {
            return Tuple.Create(0, 0);  // Tratamento de erro quando delta é negativo
        }
    }

    static void MostraResultado(int x1, int x2, int delta)
    {
        if (delta >= 0)
        {
            Console.WriteLine("O valor de delta é " + delta + "\n");
            Console.WriteLine("x1 = " + x1 + "\n");
            Console.WriteLine("x2 = " + x2 + "\n");
        }
        else
        {
            Console.WriteLine("Impossível calcular! Pois o valor de delta é menor que 0(zero)");
        }
    }
}
