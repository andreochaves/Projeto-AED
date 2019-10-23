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

        public void EscreverDados(string gravar)
        {
            StreamWriter sw = new StreamWriter(this.Arquivo, true);
            sw.WriteLine(this.Arquivo);
            sw.Close();
        }

        public string LerArq()
        {
            string conteudo = string.Empty;
            if (File.Exists(this.Arquivo))
            {
                StreamReader sr = new StreamReader(this.Arquivo);
                conteudo = sr.ReadToEnd();
                sr.Close();
            }
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
