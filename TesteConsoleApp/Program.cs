using EscreveCaracterNumero;
using System;

namespace TesteConsoleApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            EscreveMensagemComNumero escreve = new EscreveMensagemComNumero();
            TrocaLetraPorNumero troca = new TrocaLetraPorNumero();

            Console.Write(escreve.RetornaLetra("SEMPRE ACESSO O DOJOPUZZLES"));
            Console.ReadLine();

        }   
    }
}
