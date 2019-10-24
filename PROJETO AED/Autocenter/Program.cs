using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Autocenter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chamando Tela Inicial
            int selecao = 0;
            TelaInicial novaTela = new TelaInicial(selecao);

            //Chamando Formulario de Cadastro
            string nome = "";
            string rua = "";
            string bairro = "";
            string cidade = "";
            string estado = "";
            int numero = 0;
            string placa = "";
            string modelo = "";
            string marca = "";
            CadastrarCliente novoCliente = new CadastrarCliente(nome, rua, numero, bairro, cidade, estado, modelo, marca, placa);

            //Gravar Arquivo
           // FileStream novo = new FileStream("placa.txt", FileMode.Create, FileAccess.ReadWrite);
            //StreamWriter sw = new StreamWriter(novo, Encoding.UTF8);
            

            File.WriteAllText("placa.txt", "");
            string[] todasLnhas = File.ReadAllLines("placa.txt");
            string gravar = "placa.txt";
            //Verificar dados
            string verificar = "placa.txt";
            VerificarDados novaVerificacao = new VerificarDados(verificar);
           // StreamReader sr = new StreamReader(novo, Encoding.UTF8);

            //Começo do Programa
            Console.WriteLine("Digite opção desejada:");
            selecao = int.Parse(Console.ReadLine());

            if (selecao == 1)
            {


                Console.WriteLine("Qual seu nome?");
                nome = Console.ReadLine();
                Console.WriteLine("Seu Endereço?");
                rua = Console.ReadLine();
                Console.WriteLine("Numero?");
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine("Bairro?");
                bairro = Console.ReadLine();
                Console.WriteLine("Cidade?");
                cidade = Console.ReadLine();
                Console.WriteLine("Estado?");
                estado = Console.ReadLine();
                novoCliente.setNome(nome);
                novoCliente.setRua(rua);
                novoCliente.setNumero(numero);
                novoCliente.setBairro(bairro);
                novoCliente.setCidade(cidade);
                novoCliente.setEstado(estado);
                novoCliente.gravarArquvo(gravar);
                //sw.WriteLine(novoCliente.getNome(), novoCliente.getRua(), novoCliente.getNumero(), novoCliente.getBairro(), novoCliente.getCidade(), novoCliente.getEstado());

            }
            else if (selecao == 2)
            {
                //novaVerificacao.LerArq(); 
                Console.WriteLine(novaVerificacao.LerArq());
            }
            else
            {
                Console.WriteLine("Opção Invalida!");
            }

           





            //sw.Close();
            //novo.Close();
            //sr.Close();

            Console.ReadKey();

        }
    }
}
