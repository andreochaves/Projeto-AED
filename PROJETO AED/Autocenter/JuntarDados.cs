using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Autocenter
{
    class JuntarDados
    {
        private string Cliente;
        private string Orcamento;
        private string Novo;


        public JuntarDados(string Cliente, string Orcamento, string Novo)
        {
            this.Cliente = Cliente;
            this.Orcamento = Orcamento;
            this.Novo = Novo;
        }
        public void LerArq1(string novoArquivo)
        {
            File.WriteAllText("Pesquisar.txt", "");
            string[] linhas2 = new string[1];
            string[] AquivoInteiro = File.ReadAllLines(Cliente);
            string[] AquivoInteiro2 = File.ReadAllLines(Orcamento);

            StreamWriter gravar = File.AppendText(novoArquivo);
            int i = 0;
            while (i < AquivoInteiro.Length)
            {
                    gravar.WriteLine(AquivoInteiro[i].Split(';')[8] + ";" + AquivoInteiro2[i].Split(';')[0]);

                i++;
            }
            gravar.Close();


        }
    }
}
