using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Autocenter
{
    class Orcamento
    {
        private string servico;
        private int quantidade;
        private float valorUnitario;
        private float valorTotal;

        public Orcamento(string servico,int quantidade,float valorUnitario,float valorTotal)
        {
            this.servico = servico;
            this.quantidade = quantidade;
            this.valorUnitario = valorUnitario;
            this.valorTotal = valorTotal;

            
        }

        public void gravarArquvo(string nomeArquvo)
        {
            StreamWriter escrever = File.AppendText(nomeArquvo);
            escrever.WriteLine(this.servico + ";" + this.quantidade + ";" + this.valorUnitario + ";" + this.valorTotal);
            escrever.Close();
        }
        public void ValorTotal()
        {
            valorTotal = quantidade * valorUnitario;
        }

        public string getServico()
        {
            return servico;
        }
        public int getQuantidade()
        {
            return quantidade;
        }
        public float getValorUnitario()
        {
            return valorUnitario;
        }
        public float getValorTotal()
        {
            return valorTotal;
        }

        public void setServico(string s)
        {
            servico = s;
        }
        public void setQuantidade(int q)
        {
            quantidade = q;
        }
        public void setValorUnitario(float valUn)
        {
            valorUnitario = valUn;
        }
        public void setValorTotal(float vt)
        {
            valorTotal = vt;
        }
    }
}
