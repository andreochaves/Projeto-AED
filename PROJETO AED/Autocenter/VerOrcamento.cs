using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Autocenter
{
    class VerOrcamento
    {
        private string servico;
        private int quantidade;
        private float valorUnitario;
        private float valorTotal;

        public VerOrcamento(string servico, int quantidade, float valorUnitario, float valorTotal)
        {
            this.servico = servico;
            this.quantidade = quantidade;
            this.valorUnitario = valorUnitario;
            this.valorTotal = valorTotal;


        }
        public void LerArq()
        {
            string Arquivo = "Orcamento.txt";
            string Novo = "Pesquisar.txt";
            string[] linhas = new string[4];
            string[] AquivoInteiro = File.ReadAllLines(Arquivo);
            string[] AquivoInteiro2 = File.ReadAllLines(Novo);
            string pesquisaPlaca;

            Console.WriteLine("Digite a Placa do Carro:");
            pesquisaPlaca = Console.ReadLine();
            foreach (string linha in AquivoInteiro)
            {
                linhas = linha.Split(';');
                
                for (int i = 0; i < AquivoInteiro2.Length; i++)
                {
                    
                    if (pesquisaPlaca == AquivoInteiro2[i].Split(';')[0])
                    {
                        servico = AquivoInteiro[i].Split(';')[0];
                        quantidade = int.Parse(AquivoInteiro[i].Split(';')[1]);
                        valorUnitario = float.Parse(AquivoInteiro[i].Split(';')[2]);
                        valorTotal = float.Parse(AquivoInteiro[i].Split(';')[3]);
                    }
                }
            }
            Console.WriteLine("Tipo de Serviço: {0} \nQuantidade: {1} \nValor do Serviço: {2} \nValor Total: {3} \n",servico,quantidade,valorUnitario,valorTotal);

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
