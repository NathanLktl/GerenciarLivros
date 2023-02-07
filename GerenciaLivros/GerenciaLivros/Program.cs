using System;
using System.Collections.Generic;

namespace GerenciarLivros
{

    class Gerencia
    {
        static void Main(string[] args)
        {
            List<Livro> Livros = new List<Livro>();
            int opcao;

            do
            {
                Console.WriteLine("1 - Adicionar a Livro");
                Console.WriteLine("2 - Mostrar Livros");
                Console.WriteLine("3 - Procurar Livro");
                Console.WriteLine("4 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite os detalhes do livro:");
                        Console.Write("Título: ");
                        string titulo = Console.ReadLine();
                        Console.Write("Autor: ");
                        string autor = Console.ReadLine();
                        Console.Write("Ano: ");
                        int ano = Convert.ToInt32(Console.ReadLine());
                        Livros.Add(new Livro { Titulo = titulo, Autor = autor, Ano = ano });
                        Console.WriteLine("Livro adicionado com sucesso");
                        break;
                    case 2:
                        Console.WriteLine("Lista de Livros:");
                        foreach (Livro Livro in Livros)
                        {
                            Console.WriteLine("Titulo: " + Livro.Titulo);
                            Console.WriteLine("Autor: " + Livro.Autor);
                            Console.WriteLine("Ano: " + Livro.Ano);
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        Console.Write("Digite o título do livro para procurá-lo: ");
                        string procuraTitulo = Console.ReadLine();
                        Livro achaLivro = Livros.Find(x => x.Titulo == procuraTitulo);
                        if (achaLivro != null)
                        {
                            Console.WriteLine("Titulo: " + achaLivro.Titulo);
                            Console.WriteLine("Autor: " + achaLivro.Autor);
                            Console.WriteLine("Ano: " + achaLivro.Ano);
                        }
                        else
                        {
                            Console.WriteLine("Livro não encontrado");
                        }
                        break;
                }
            } while (opcao != 4);
        }
    }

    class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Ano { get; set; }
    }
}


