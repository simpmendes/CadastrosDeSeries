using System;

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorio= new SerieRepositorio();   
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X"){
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSeries();
                        break;
                    case "3":
                        AtualizarSeries();
                        break;
                    case "4":
                        ExcluirSeries();
                        break;
                    case "5":
                        //VisualizarSeries();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                 }
                opcaoUsuario = ObterOpcaoUsuario();
            }
            
        }

        private static string ObterOpcaoUsuario(){
            Console.WriteLine();
            Console.WriteLine("DIO Series a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1- Listar séries");
            Console.WriteLine("2- Inserir nova série");
            Console.WriteLine("3- Atualizar série");
            Console.WriteLine("4- Excluir série");
            Console.WriteLine("5-Visualisar série");
            Console.WriteLine("C-Limpar Tela");
            Console.WriteLine("X-Sair");
            Console.WriteLine();
            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
         private static void ListarSeries(){
            Console.WriteLine("Listar séries");
            var lista = repositorio.Lista();
            if (lista.Count==0)
            {
                Console.WriteLine("Nenhuma série Cadastrada.");
                return;
            }
            foreach (var serie in lista)
            {   
                Console.WriteLine("#ID {0}: - {1}", serie.retornaId(), serie.retornaTitulo());   
            }

        }

        private static void InserirSeries(){
            Console.WriteLine("Inserir nova Série");
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}",i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o título da série: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de inicio da série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição da série: ");
            string entradaDescricao = Console.ReadLine();

            Series novaSerie = new Series(id: repositorio.ProximoId(), 
                                          genero: (Genero)entradaGenero, 
                                          titulo: entradaTitulo, 
                                          ano: entradaAno, 
                                          descricao: entradaDescricao);
            repositorio.Insere(novaSerie);
        }
        private static void AtualizarSeries()
		{
			Console.Write("Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Série: ");
			string entradaDescricao = Console.ReadLine();

			Series atualizaSerie = new Series(id: indiceSerie,
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorio.Atualiza(indiceSerie, atualizaSerie);
		}

        private static void ExcluirSerie()
		{
			Console.Write("Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			repositorio.Excluir(indiceSerie);
		}

    }
}
