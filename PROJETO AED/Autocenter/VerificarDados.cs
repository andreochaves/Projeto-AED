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
           	string[] todasLnhas = File.ReadAllLines(Arquivo);
			if(todasLnhas.Count > 0){
				return todasLnhas[0];
			}else{
				return "";
			}
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
