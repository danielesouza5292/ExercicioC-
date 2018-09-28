using Exercicio;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercicioConsole
{
    class Program : Master
    {
        static void Main(string[] args)
        {
            var service = new LivrariaService();
            var tema = new LivrariaService();
            bool ListaContemDados = false;
            string valor = "0";
            var listaLivros = service.ObterLivros();
            string pesquisa;
            

            do
            {
                RetornaMenu();
                valor = Console.ReadLine();


                switch (Convert.ToInt32(valor))
                {
                    case 1:
                        //Lista livros
                        Console.Clear();

                        

                        if (listaLivros != null && listaLivros.Any())
                        {
                            ListaContemDados = true;
                            Console.WriteLine("*****Livros*****");

                            foreach (var item in service.ObterLivros())
                            {

                                Console.WriteLine("Autor: " + item.Autor);
                                Console.WriteLine("Titulo: " + item.Titulo);
                                Console.WriteLine("Valor: " + item.Valor);
                                Console.WriteLine(" ");
                            }
                        }

                        break;

                    case 2:
                        //lista apenas autores
                        Console.Clear();             

                        if (listaLivros != null && listaLivros.Any())
                        {
                            ListaContemDados = true;
                            Console.WriteLine("*****Autores*****");
                            foreach (var item in listaLivros)
                            {
                                Console.WriteLine(item.Id + " : " + item.Autor);
                            }
                        }

                        break;

                    case 3:

                        Console.Clear();

                        {
                            ListaContemDados = true;
                            Console.WriteLine("*****Títulos*****");
                            foreach (var item in listaLivros)
                            {
                                Console.WriteLine(item.Id + ": " + item.Titulo);
                            }
                        }
                        Console.WriteLine();

                        break;


                    case 4:


                        Console.Clear();
                        
                        var listaTema = service.ObterTemas();

                        if (listaTema != null && listaTema.Any())
                        {
                            ListaContemDados = true;
                            Console.WriteLine("*****Temas*****");
                            foreach (var item in listaTema)
                            {
                                Console.WriteLine(item.Id + ": " + item.Descricao);
                            }
                        }
                        break;

                    case 5:

                        Console.Clear();

                        Console.WriteLine("Digite o tema a ser pesquisado: ");
                        pesquisa = Console.ReadLine();
                        Console.WriteLine("*******Livros de" + pesquisa + "*******");
                        var pesquisaPorTema = service.PesquisaLivros(pesquisa, Convert.ToInt32(valor));

                        if (pesquisaPorTema != null && pesquisaPorTema.Any())
                        {
                            ListaContemDados = true;

                            foreach (var item in pesquisaPorTema)
                            {

                                Console.WriteLine("\n  Autor: " + item.Autor);
                                Console.WriteLine("  Titulo: " + item.Titulo);
                                Console.WriteLine("  Valor: " + item.Valor);

                            }

                        }

                        break;

                    case 6:

                        Console.Clear();
                        Console.WriteLine("Digite o Autor a ser pesquisado: ");
                        pesquisa = Console.ReadLine();
                        Console.WriteLine("*******Livros de " + pesquisa + "*******");
                        var pesquisaAutor = service.PesquisaLivros(pesquisa, Convert.ToInt32(valor));

                        if (pesquisaAutor != null && pesquisaAutor.Any())
                        {
                            ListaContemDados = true;

                            foreach (var item in pesquisaAutor)
                            {                
                                Console.WriteLine("\n  Tema: " + item.Tema.Descricao);
                                Console.WriteLine("  Titulo: " + item.Titulo);
                                Console.WriteLine("  Valor: " + item.Valor);
                            }

                        }

                        break;
                }
                        if (ListaContemDados == false)
                        {

                            Console.WriteLine("Nenhum item encontrado na pesquisa");
                            Console.WriteLine("Aperte enter para continuar!");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("\nAperte enter para continuar!");
                            Console.ReadLine();
                        }


                } while (valor != "0") ;



            }
        }

    }
