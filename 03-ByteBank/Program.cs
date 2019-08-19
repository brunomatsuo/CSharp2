using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.conta = 863452;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 863;
            contaDaGabrielaCosta.conta = 863452;

            Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta);

            int idade = 27;
            int idadeMaisUmaVez = 27;

            Console.WriteLine(idade == idadeMaisUmaVez);

            Console.ReadLine();
        }
    }
}
