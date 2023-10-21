using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProdutoEstoque
{
    internal class Produto
    {                                           // Declarando a estrutura da classe produto
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double EstoqueProduto()                 // Criando o primeiro estoque
        {
            double VTotal = (Preco * Quantidade);
            return VTotal;
        }

        public void AddProduto(int quantidade)            // Adicionando unidades ao estoque
        {
            Quantidade += quantidade;
        }

        public void RemoveProduto(int quantidade)        // Removendo unidades do estoque
        {
            Quantidade -= quantidade;
        }

        public override string ToString()                 // Retornando o estoque atualizado
        {
            return "Nome do produto: " 
                + Nome
                + ", Preço da unidade: R$"
                + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", Quantidade: "
                + Quantidade
                + " unidades, Preço Total: R$"
                + EstoqueProduto().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
