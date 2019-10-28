using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Autocenter
{
    class VerCliente
    {
        private string nome;
        private string rua;
        private string bairro;
        private string cidade;
        private string estado;
        private int numeroDaCasa;
        private string modeloDoCarro;
        private string marcaDoCarro;
        private string placaDoCarro;

        public VerCliente(string nome, string rua, int numeroDaCasa, string bairro, string cidade, string estado, string modeloDoCarro, string marcaDoCarro, string placaDoCarro)
        {
            this.nome = nome;
            this.rua = rua;
            this.numeroDaCasa = numeroDaCasa;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
            this.modeloDoCarro = modeloDoCarro;
            this.marcaDoCarro = marcaDoCarro;
            this.placaDoCarro = placaDoCarro;

        }

        public void LerArq()
        {
            string Arquivo = "Cliente.txt";
            string Novo = "Pesquisar.txt";
            string[] linhas = new string[9];
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
                        nome = AquivoInteiro[i].Split(';')[0];
                        rua = AquivoInteiro[i].Split(';')[1];
                        numeroDaCasa = int.Parse(AquivoInteiro[i].Split(';')[2]);
                        bairro = AquivoInteiro[i].Split(';')[3];
                        cidade = AquivoInteiro[i].Split(';')[4];
                        estado = AquivoInteiro[i].Split(';')[5];
                        modeloDoCarro = AquivoInteiro[i].Split(';')[6];
                        marcaDoCarro = AquivoInteiro[i].Split(';')[7];
                        placaDoCarro = AquivoInteiro[i].Split(';')[8];
                    }

                }
            }
            
            
            Console.WriteLine("Nome: {0}\nRua: {1}\nNumero: {2}\nBairro: {3}\nCidade: {4}\nEstado: {5}\nModelo do Carro: {6}\nMarca do Carro: {7}\nPlaca do Carro: {8}\n",nome,rua,numeroDaCasa,bairro,cidade,estado,modeloDoCarro,marcaDoCarro,placaDoCarro);

        }
        public string getNome()
        {
            return nome;
        }
        public string getRua()
        {
            return rua;
        }
        public int getNumero()
        {
            return numeroDaCasa;
        }
        public string getBairro()
        {
            return bairro;
        }
        public string getCidade()
        {
            return cidade;
        }
        public string getEstado()
        {
            return estado;
        }
        public string getModelo()
        {
            return modeloDoCarro;
        }
        public string getMarca()
        {
            return marcaDoCarro;
        }
        public string getPlaca()
        {
            return placaDoCarro;
        }
        //adicionar
        public void setNome(string n)
        {
            nome = n;
        }
        public void setRua(string r)
        {
            rua = r;
        }
        public void setNumero(int num)
        {
            numeroDaCasa = num;
        }
        public void setBairro(string b)
        {
            bairro = b;
        }
        public void setCidade(string c)
        {
            cidade = c;
        }
        public void setEstado(string e)
        {
            estado = e;
        }
        public void setModelo(string modelo)
        {
            modeloDoCarro = modelo;
        }
        public void setMarca(string marca)
        {
            marcaDoCarro = marca;
        }
        public void setPlaca(string p)
        {
            placaDoCarro = p;
        }

    }
}
