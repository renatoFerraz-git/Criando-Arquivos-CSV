using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriarArquivoCsv
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar e Subsituir arquivo existente com o mesmo nome (FileMode.Create)
            var destinoDoArquivo = "contaRenato.csv";
            using (var fluxoDoArquivo = new FileStream(destinoDoArquivo, FileMode.Create))
            using (var contaRenato = new StreamWriter(fluxoDoArquivo, Encoding.UTF8))
            {
                contaRenato.Write("001,200301,1900.00,Renato Ferraz");
            }

            // Criar um novo arquivo (FileMode.CreateNew)
            var destinoDoArquivoNovo = "contaLeidiane.csv";
            using (var fluxoDoArquivo = new FileStream(destinoDoArquivoNovo, FileMode.CreateNew))
            using (var contaLeidiane = new StreamWriter(fluxoDoArquivo, Encoding.UTF8))
            {
                contaLeidiane.Write("001,200404,2700.00,Leidiane Ferraz");
            }


            Console.WriteLine("Arquivos Criados - Pressione ENTER p/ finalizar");
            Console.ReadLine();
        }
    }
}
