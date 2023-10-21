using System;
using System.Globalization;

namespace ProdutoEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aluno Daniel Gama - 4121047");    
            Console.WriteLine("Iniciando o programa...");
            
            Produto produto1 = new Produto();       // Declarando Variáveis
            int quantidade = new int();
            int funcaoprog = new int();

            Console.WriteLine("Preencha os dados do produto abaixo.");
            
            Console.WriteLine("Nome: ");                                
            produto1.Nome = string.Format(Console.ReadLine());                          // Pegando o nome do produto

            Console.WriteLine("Preço: ");
            produto1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);     // Pegando o preço do produto

            Console.WriteLine("Quantidade: ");
            produto1.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);   // Pegando a quantidade do produto

            Console.WriteLine("...........................................");
            Console.WriteLine();
            Console.WriteLine("Dados do produto registrado: " + produto1);                        // Apresentando o produto já registrado
            Console.WriteLine();
            
            Console.WriteLine("Digite 1 para adicionar unidades do produto," +                     // Fornecendo opções de edição ao usuário
            " 2 para remover unidades do produto ou 3 para encerrar o programa: ");
            funcaoprog = int.Parse(Console.ReadLine());

            while (funcaoprog != 3)
            {
                if (funcaoprog == 1)                                                            // Adicionando unidades ao estoque
                {
                    Console.WriteLine("Digite quantas unidades do produto você quer adicionar: ");
                    quantidade = int.Parse(Console.ReadLine());
                    produto1.AddProduto(quantidade);                                                
                    Console.WriteLine();
                    Console.WriteLine("Produto atualizado: " + produto1);
                    Console.WriteLine();
                    Console.WriteLine("Digite 1 para adicionar unidades do produto," +
                    " 2 para remover unidades do produto ou 3 para encerrar o programa: ");
                    funcaoprog = int.Parse(Console.ReadLine());
                }
                else if (funcaoprog == 2)                                                        // Removendo unidades do estoque
                {
                    Console.WriteLine("Digite quantas unidades do produto você quer remover: ");
                    quantidade = int.Parse(Console.ReadLine());
                    produto1.RemoveProduto(quantidade);
                    Console.WriteLine();
                    Console.WriteLine("Produto atualizado: " + produto1);
                    Console.WriteLine();
                    Console.WriteLine("Digite 1 para adicionar unidades do produto," +
                    " 2 para remover unidades do produto ou 3 para encerrar o programa: ");
                    funcaoprog = int.Parse(Console.ReadLine());
                }
                else                                                                             // Validando a opção do usuário
                {
                    Console.WriteLine("Este NÃO é um valor válido!");
                    Console.WriteLine();
                    Console.WriteLine("Digite 1 para adicionar unidades do produto," +
                    " 2 para remover unidades do produto ou 3 para encerrar o programa: ");
                    funcaoprog = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();                                                             
            Console.WriteLine("Encerrando o programa...");






        }
    }
}

