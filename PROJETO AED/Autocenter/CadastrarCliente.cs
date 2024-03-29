﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autocenter
{
    class CadastrarCliente
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

        public CadastrarCliente(string nome, string rua, int numeroDaCasa, string bairro, string cidade, string estado, string modeloDoCarro, string marcaDoCarro, string placaDoCarro)
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
        //busca

        public void gravarArquvo(string nomeArquvo)
        {
            StreamWriter escrever = File.AppendText(nomeArquvo);
            escrever.WriteLine( this.nome + ";" + this.rua + ";" + this.numeroDaCasa + ";" + this.bairro + ";" + this.cidade + ";" + this.estado + ";" + this.modeloDoCarro + ";" + this.marcaDoCarro + ";" + this.placaDoCarro );
            escrever.Close();
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