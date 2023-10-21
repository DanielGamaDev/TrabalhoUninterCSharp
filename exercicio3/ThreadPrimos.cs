using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadsNumerosPrimos
{
    public class ThreadPrimos
    {
        private int start;
        private int end;

        public ThreadPrimos(int start, int end)
        {
            this.start = start;
            this.end = end;
        }

        public void Run()
        {
            for (int numer = start; numer <= end; numer++)
            {
                if (EPrimo(numer))                 // Manda numer para a verificação
                {
                    Console.Write(numer + " ");     // Imprime numeros primos
                }
            }
        }

        private bool EPrimo(int numer)      // Verifica numer, se for aprovado em todas as etapas como um número primo, retorna true.
        {
            if (numer <= 1)                    // numer deve ser maior que 1
            {
                return false;
            }
            if (numer <= 3)                    // Se numer for 2 ou 3 ele é primo
            {
                return true;
            }
            if (numer % 2 == 0 || numer % 3 == 0)  // numer NÃO pode ser divisível por 2 ou por 3
            {
                return false;
            }
            for (int i = 5; i * i <= numer; i += 6)       // Verifica se numer é divisível por qualquer número além dos divisores comuns de 2 e 3
            {
                if (numer % i == 0 || numer % (i + 2) == 0)     // Se numer for divisível por i ou por i+2 nas condições do loop ele NÃO é primo
                {
                    return false;
                }
            }
            return true;
        }
    }
}