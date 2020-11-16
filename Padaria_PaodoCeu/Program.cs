﻿using System;

namespace Padaria_PaodoCeu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variaveis

            //Váriaveis de Produtos
                //Váriaveis do primeiro produto
                object[] Produto1 = new object[4];

                int codP1 = 0;
                double precoP1 = 0;
                string nomeP1 = "a";
                int qtdP1 = 0;
                int contP1 = 0;
                
                //Váriaveis do segundo produto
                object[] Produto2 = new object[4];

                int codP2 = 0;
                double precoP2 = 0;
                string nomeP2 = "a";
                int qtdP2 = 0;
                int contP2 = 0;


            //Váriaveis dos clientes
                //Primeiro Cliente
                object[] Cliente1 = new object[5];
                
                string nomeCliente1 = "a";
                string sobrenomeCliente1 = null;
                string emailCliente1 = null;
                int telefoneCliente1 = 0;

                //Segundo Cliente
                object[] Cliente2 = new object[5];

                string nomeCliente2 = null;
                string sobrenomeCliente2 = null;
                string emailCliente2 = null;
                int telefoneCliente2 = 0;


            //Váriaveis das Vendas
                
                double maiorVenda = 0;
                double menorVenda = 0;
                int contVendas = 0;
                double somatorioVendas = 0;
                double subtotalVendas = 0;
                int qtdProduto = 1;
                int contCliente1 = 0;
                int contCliente2 = 0;

        inicio:

            Console.Clear();

            Console.WriteLine("      Bem Vindo a Padaria");
            Console.WriteLine("          Pão do Céu");
            Console.WriteLine("");
            Console.WriteLine("1 - Estoque");
            Console.WriteLine("2 - Cliente");
            Console.WriteLine("3 - Realizar venda");
            Console.WriteLine("4 - Financeiro e Estatisticas");
            Console.Write("Digite a opção desejada: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:

                    Console.WriteLine("1 - Adicionar Produto");
                    Console.WriteLine("2 - Visualizar o estoque");
                    Console.Write("Digite a opção: ");
                    int opcaoEstoque = int.Parse(Console.ReadLine());

                    if (opcaoEstoque == 1)
                    {
                        Console.WriteLine("Escolha um espaço dispónivel para adicionar o produto: ");
                        Console.Write("1 ");
                        Console.WriteLine("2");
                        int opcaoProd = int.Parse(Console.ReadLine());
                        Console.WriteLine("");

                        if (opcaoProd == 1)
                        {
                            //Adicionando primeiro produto
                            Console.Write("Digite o codigo do produto: "); //Codigo do produto
                            codP1 = int.Parse(Console.ReadLine());
                            Produto1[0] = codP1;

                            Console.Write("Digite o nome do Produto: "); //Nome do produto
                            nomeP1 = Console.ReadLine();
                            Produto1[1] = nomeP1;

                            Console.Write("Digite o preço do produto: "); //Preço do produto
                            precoP1 = double.Parse(Console.ReadLine());
                            Produto1[2] = precoP1;

                            Console.Write("Digite a quantidade em estoque: "); //Quantidade a ser adicionada
                            qtdP1 = int.Parse(Console.ReadLine());
                            Produto1[3] = qtdP1;
                        } if (opcaoProd == 2)
                        {
                            //Adicionando segundo produto
                            Console.Write("Digite o codigo do produto: "); //Codigo do produto
                            codP2 = int.Parse(Console.ReadLine());
                            if (codP2 == codP1)
                            {
                                Console.WriteLine("Código já existente, por favor digite outro código: ");
                                Console.Write("Digite o codigo do produto: "); //Codigo do produto
                                codP2 = int.Parse(Console.ReadLine());
                                Produto2[0] = codP2;
                            }

                            Console.Write("Digite o nome do Produto: "); //Nome do produto
                            nomeP2 = Console.ReadLine();
                            Produto2[1] = nomeP2;

                            Console.Write("Digite o preço do produto: "); //Preço do produto
                            precoP2 = double.Parse(Console.ReadLine());
                            Produto2[2] = precoP2;

                            Console.Write("Digite a quantidade em estoque: "); //Quantidade a ser adicionada
                            qtdP2 = int.Parse(Console.ReadLine());
                            Produto2[3] = qtdP2;
                        }
                        
                    }else
                    {
                        //Visualizando o estoque
                            if( codP1 > 0)
                        {
                            Console.WriteLine("Código: "+Produto1[0]);
                            Console.WriteLine("Nome: " + Produto1[1]);
                            Console.WriteLine("Preço: R$" + Produto1[2]);
                            Console.WriteLine("Quantidade: " + Produto1[3]);
                            }
                        Console.WriteLine("");
                        {
                            Console.WriteLine("Código: " + Produto2[0]);
                            Console.WriteLine("Nome: " + Produto2[1]);
                            Console.WriteLine("Preço: R$" + Produto2[2]);
                            Console.WriteLine("Quantidade: " + Produto2[3]);
                        }

                    }
                        
                    break;
                    

                case 2:
                    Console.WriteLine("Digite a opção desejada: ");
                    Console.WriteLine("1 - Cadastrar Cliente");
                    Console.WriteLine("2 - Exibir cliente cadastrados");
                    int opcaoCliente = int.Parse(Console.ReadLine());

                    if (opcaoCliente == 1)
                    {
                        //Realizando cadastro de cliente

                        Console.WriteLine("Escolha em qual espaço deseja cadastra-lo");
                        Console.WriteLine("1 ou 2");
                        int opcaoCadastro = int.Parse(Console.ReadLine());
                        
                        
                        if (opcaoCadastro == 1)
                        {
                            Console.WriteLine("Digite o seu nome: "); //Nome do cliente
                            nomeCliente1 = Console.ReadLine();
                            Cliente1[0] = nomeCliente1;

                            Console.WriteLine("Digite seu sobrenome: "); // Sobrenome do Cliente
                            sobrenomeCliente1 = Console.ReadLine();
                            Cliente1[1] = sobrenomeCliente1;

                            Console.WriteLine("Digite o seu telefone (com DDD): "); //Telefone do Cliente
                            telefoneCliente1 = int.Parse(Console.ReadLine());
                            Cliente1[2] = telefoneCliente1;

                            Console.WriteLine("Digite o seu email: "); //Email do Cliente
                            emailCliente1 = Console.ReadLine();
                            Cliente1[3] = emailCliente1;

                            Cliente1[4] = 1;

                        }if (opcaoCadastro == 2)
                        {
                            Console.WriteLine("Digite o seu nome: "); //Nome do cliente
                            nomeCliente2 = Console.ReadLine();
                            Cliente2[0] = nomeCliente2;

                            Console.WriteLine("Digite seu sobrenome: "); // Sobrenome do Cliente
                            sobrenomeCliente2 = Console.ReadLine();
                            Cliente2[1] = sobrenomeCliente2;

                            Console.WriteLine("Digite o seu telefone (com DDD): "); //Telefone do Cliente
                            telefoneCliente2 = int.Parse(Console.ReadLine());
                            Cliente2[2] = telefoneCliente2;

                            Console.WriteLine("Digite o seu email: "); //Email do Cliente
                            emailCliente2 = Console.ReadLine();
                            Cliente2[3] = emailCliente2;

                            Cliente2[4] = 2;
                        }
                        
                    } if (opcaoCliente == 2)
                    {
                        Console.WriteLine("Qual Cliente deseja exibir as informações:");
                        Console.WriteLine("1 - " + Cliente1[0] + Cliente1[1]);
                        Console.WriteLine("2 - " + Cliente2[0] + Cliente2[1]);
                        Console.WriteLine("Digite a opção desejada: ");
                        int opcaoConsultaCliente = int.Parse(Console.ReadLine());

                        if (opcaoConsultaCliente == 1)
                            for (int i = 0; i < 5; i++)
                            {
                                Console.WriteLine("Nome: "+Cliente1[i]);
                                Console.WriteLine("Sobrenome: " + Cliente1[i]);
                                Console.WriteLine("Telefone: " + Cliente1[i]);
                                Console.WriteLine("Email: " + Cliente1[i]);
                                Console.WriteLine("Código do Cliente: "+ Cliente1[i]);

                            }
                        if (opcaoConsultaCliente == 2)
                        {
                                for (int i = 0; i < 5; i++)
                            {
                                Console.WriteLine("Nome: ",Cliente2[i]);
                                Console.WriteLine("sobrenome: " + Cliente2[i]);
                                Console.WriteLine("Telefone: " + Cliente2[i]);
                                Console.WriteLine("Email: " + Cliente2[i]);
                                Console.WriteLine("Código do Cliente: " + Cliente2[i]);

                            }

                        }
                            

                    }
                    
                    break;

                case 3:
                    //Vendas
                    Console.WriteLine("Digite o código do Cliente: ");
                    int codCliente = int.Parse(Console.ReadLine());

                    if (codCliente == 1)
                    {
                        contCliente1 = contCliente1 + 1; //Identificando Cliente
                    }else
                    {
                        contCliente2 = contCliente2 + 1; //Identificando Cliente
                    }

                    
                    Console.WriteLine("Digite 0 quando solicitar o codigo para encerrar a venda");

                    Console.WriteLine("");
                    
                    Console.WriteLine("Digite o codigo do produto: "); //Código do produto
                    int codVenda = int.Parse(Console.ReadLine());

                    while(codVenda != 0)
                    {
                        Console.WriteLine("Digite o codigo do cliente: ");

                        
                        
                        Console.WriteLine("");

                        if (codVenda == 1)//Realizando venda do produto 1
                        {

                            Console.WriteLine("Digite a quantidade do produto: "); //Quantidade selecionada para ser vendida
                            qtdProduto = int.Parse(Console.ReadLine());

                            if (qtdProduto > qtdP1)
                            {
                                Console.WriteLine("Quantidade indispovível em estoque, digite uma quantidade até {0}", Produto2[3]);
                                qtdProduto = int.Parse(Console.ReadLine());
                            }

                            qtdP1 -= qtdProduto; //Atualizando quantidade do produto em estoque

                            Console.WriteLine(Produto1[1]);
                            contP1 = contP1 + 1; //Atualizando a quantidade do Produto 1 que foi vendida
                            subtotalVendas = subtotalVendas + (precoP1 * qtdProduto);//Atualizando subtotal da venda
                            Console.WriteLine(subtotalVendas);
                        }

                        if (codVenda ==2) //Realizando venda do Produto 2;
                        {

                            if (qtdProduto > qtdP1)
                            {
                                Console.WriteLine("Quantidade indispovível em estoque, digite uma quantidade até {0}", Produto2[3]);
                                qtdProduto = int.Parse(Console.ReadLine());
                            }

                            qtdP2 -= qtdProduto;

                            Console.WriteLine(Produto2[1]);
                            contP2 = contP2 + 1; //Atualizando a quantidade do Produto 2 que foi vendida
                            subtotalVendas = subtotalVendas + (precoP2 * qtdProduto); //Atualizando o subtotal da venda
                            Console.WriteLine(subtotalVendas);
                        }

                        Console.WriteLine("Digite o codigo do produto: "); //Código do produto
                        codVenda = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("Total a pagar: "+ subtotalVendas); //Exibindo na tela o valor final da compra
                    contVendas = contVendas + 1; //Atualizando a quantidade de vendas realizadas
                    somatorioVendas = somatorioVendas + subtotalVendas; //Atualizando o total (em R$) vendido

                    if (subtotalVendas < menorVenda)
                    {
                        menorVenda = subtotalVendas; //Registrando a menor venda ja feita
                    }

                    if (subtotalVendas > maiorVenda)
                    {
                        maiorVenda = subtotalVendas; //Registrando a maior venda ja feita
                    }
                    break;

                case 4:

                    //Estatisticas e financeiro
                    Console.WriteLine("Digite a opção desejada: ");
                    Console.WriteLine("1 - Média de vendas");
                    Console.WriteLine("2 - Maior venda ja registrada");
                    Console.WriteLine("3 - Menor venda ja registrada");
                    Console.WriteLine("4 - Produto mais vendido");
                    Console.WriteLine("5 - Produto menos vendido");
                    Console.WriteLine("6 - Quantidade de venda por cliente");
                    Console.WriteLine("7 - Quantidade vendida por produto: ");
                    Console.WriteLine("8 - Saldo final");
                    int opcaoFinanEstat = int.Parse(Console.ReadLine());

                    if (opcaoFinanEstat == 1)
                    {
                        //Média de vendas
                        Console.Write("A média das vendas é: ");
                        Console.Write(" "+contVendas/somatorioVendas+ " R$ ");
                    }
                    if (opcaoFinanEstat == 2)
                    {
                        //Maior venda ja registrada
                        Console.WriteLine("A maior venda ja registrada é de "+ maiorVenda +" R$ ");
                    }
                    if (opcaoFinanEstat == 3)
                    {
                        //Menor venda ja registarda
                        Console.WriteLine("A menor venda ja registrada é de "+ menorVenda +" R$ ");
                    }
                    if (opcaoFinanEstat == 4)
                    {
                        //Produto mais vendido
                        if (contP1 > contP2)
                        {
                            Console.WriteLine("O produto mais vendido foi: "+Produto1[1]);
                        }
                        else
                        {
                            Console.WriteLine("O produto mais vendido foi: "+Produto2[1]);
                        }
                    }
                    if (opcaoFinanEstat == 5)
                    {
                        //Produto menos vendido
                        if (contP1 < contP2)
                        {
                            Console.WriteLine("O produto menos vendido foi: " + Produto1[1]);
                        }
                        else
                        {
                            Console.WriteLine("O produto menos vendido foi: " + Produto2[1]);
                        }
                    }
                    if (opcaoFinanEstat == 6)
                    {
                        //Venda Por Cliente
                        Console.WriteLine("Nome do cliente: "+nomeCliente1+" "+sobrenomeCliente1);
                        Console.WriteLine("Quantidade de compras realizadas: "+contCliente1);
                        Console.WriteLine("");
                        Console.WriteLine("Nome do cliente: " + nomeCliente2 + " " + sobrenomeCliente2);
                        Console.WriteLine("Quantidade de compras realizadas: " + contCliente2);
                    }
                    if (opcaoFinanEstat == 7)
                    {
                        Console.WriteLine("Nome do Produto: "+nomeP1);
                        Console.WriteLine("Quantidade vendida: "+contP1);
                        Console.WriteLine();
                        Console.WriteLine("Nome do Produto: " + nomeP2);
                        Console.WriteLine("Quantidade vendida: " + contP2);
                        Console.WriteLine();
                    }
                    if (opcaoFinanEstat == 8)
                    {
                        Console.WriteLine("Saldo total de vendas: "+somatorioVendas);
                    }
                    break;
            }

            Console.WriteLine("");
            Console.WriteLine("Deseja volta ao menu principal? ");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            int escolha = int.Parse(Console.ReadLine());
            if (escolha == 1)
            {
                goto inicio;
            }
            else { Console.WriteLine("Até a mais. "); }
        }      
    }
    
}


