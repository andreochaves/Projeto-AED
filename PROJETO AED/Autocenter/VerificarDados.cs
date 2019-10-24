using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Autocenter
{
    class VerificarDados
    {
        private string Arquivo;
        
        public VerificarDados(string Arquivo)
        {
            this.Arquivo = Arquivo;
        }

        

        public string LerArq()
        {
                //string[] todasLnhas = File.ReadAllLines("placa.txt");
            StreamReader ler = new StreamReader(this.Arquivo);
            string conteudo = ler.ReadLine();
            ler.Close();
            return conteudo;
        }

        public string getArquivo()
        {
            return Arquivo;
        }
        public void setArquivo(string a)
        {
            Arquivo = a;
        }
    }
}
