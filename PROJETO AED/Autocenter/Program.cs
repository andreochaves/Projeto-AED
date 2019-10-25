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
            string opcao="";

            //Chamando Tela Inicial
            string selecao = "";
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

            //Chamando a Classe Orçamento
            string servico="";
            int qtd=0;
            float valorU=0;
            float valorT=0;

            Orcamento novoOrcamento = new Orcamento(servico, qtd, valorU, valorT);
            

            string gravarDados = "Cliente.txt";
            string gravarOrcamento = "Orcamento.txt";
            string verificar = "Cliente.txt";
            VerificarDados novaVerificacao = new VerificarDados(verificar);

            Console.WriteLine("Digite:\n 1 - Cadastrar novo cliente \n 2 - Verifcar Orçamento \n sair - para fechar o programa\n");

            while (selecao != "sair") {
                //Começo do Programa
                Console.WriteLine("Digite opção desejada:");
                selecao = Console.ReadLine();

                if (selecao == "1")
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
                    Console.WriteLine("Modelo do Carro?");
                    modelo = Console.ReadLine();
                    Console.WriteLine("Marca do Carro?");
                    marca = Console.ReadLine();
                    Console.WriteLine("Placa do Carro?");
                    placa = Console.ReadLine();
                    novoCliente.setNome(nome);
                    novoCliente.setRua(rua);
                    novoCliente.setNumero(numero);
                    novoCliente.setBairro(bairro);
                    novoCliente.setCidade(cidade);
                    novoCliente.setEstado(estado);
                    novoCliente.setModelo(modelo);
                    novoCliente.setMarca(marca);
                    novoCliente.setPlaca(placa);
                    novoCliente.gravarArquvo(gravarDados);

                    Console.WriteLine("Deseja fazer um Orçamento?");
                    opcao = Console.ReadLine();
                    if (opcao == "sim")
                    {
                        while (opcao == "sim")
                       {
                            

                            Console.WriteLine("Qual o serviço?");
                            servico = Console.ReadLine();
                            Console.WriteLine("Quantidade?");
                            qtd = int.Parse(Console.ReadLine());
                            Console.WriteLine("Valor Unitário?");
                            valorU = float.Parse(Console.ReadLine());
                            novoOrcamento.setServico(servico);
                            novoOrcamento.setQuantidade(qtd);
                            novoOrcamento.setValorUnitario(valorU);
                            novoOrcamento.ValorTotal();
                            novoOrcamento.gravarArquvo(gravarOrcamento);
                            Console.WriteLine("Deseja incuir novo serviço?");
                            opcao = Console.ReadLine();

                        }
                    }
                    

                }
                else if (selecao == "2")
                {
                    //; 
                    Console.WriteLine(novaVerificacao.LerArq());
                }
                else if (selecao == "sair")
                {
                    //; 
                    break;
                }
                else
                {
                    Console.WriteLine("Opção Invalida!");
                }


            }




            Console.ReadKey();

        }
    }
}
