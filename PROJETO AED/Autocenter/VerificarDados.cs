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
            List<VerificarDados> dadosCliente = new List<VerificarDados>();
            StreamReader sr = new StreamReader(Arquivo, Encoding.UTF8);
            string ler = "";
            while (true)
            {
                ler = sr.ReadLine();
                if (ler != null)
                {
                    string[] DadosColetados = ler.Split(';');
                    dadosCliente.Add(new VerificarDados ( DadosColetados[0] ));
                    Console.WriteLine(DadosColetados[0]);
                }
                //Arquivo = 
            }





            return ler;
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
