using System.IO;
using System;

internal class GerenciarProdutos : Produto
{



    //Criar Produto

    internal static string ProdutoInfo(string nome, string categoria, double preco)
    {

        int id = ((int)(preco * 2));

        string dados = $"\n\nId do poduto: {id}\nNome do produto: {nome}\nCategoria do produto: {categoria}\nPreço do produto: {preco}\n\n";



        return dados;
    }


    internal static void CriarProduto()
    {

        Console.Clear();
        Console.WriteLine("______________________________");
        Console.WriteLine("Digite o nome do produto a ser registrado:");
        Console.WriteLine("______________________________");
        string nome = Console.ReadLine(); 
        Console.Clear();
        Console.WriteLine("______________________________");
        Console.WriteLine("Digite a categoria do produto a ser registrado:");
        Console.WriteLine("______________________________");
        string categoria = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("______________________________");
        Console.WriteLine("Digite a quantidade do produto a ser registrado:");
        Console.WriteLine("______________________________");
        int quantidade = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("______________________________");
        Console.WriteLine("Digite a demanda do produto a ser registrado (de 1 a 10):");
        Console.WriteLine("______________________________");
        int demanda = int.Parse(Console.ReadLine());
        Console.Clear();

        Produto produto = new Produto();
        produto._nome = nome;
        produto._categoria = categoria;
        produto.PrecificarProduto(quantidade, demanda);
        produto._id = ((int)(produto._preco * 2));
        string dados = ProdutoInfo(produto._nome, produto._categoria, produto._preco);

        char separator = Path.DirectorySeparatorChar;
        string path = $@"Data{separator}produtos.txt";
        File.AppendAllText(path, dados);
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
        Console.Clear();
    }

    internal static void DeletarProduto()
    {

        char separator = Path.DirectorySeparatorChar;
        string path = $@"Data{separator}produtos.txt";

        if(File.Exists(path))
        {

            Console.Clear();
            Console.WriteLine("______________________________");
            Console.WriteLine("Digite o nome do produto a ser deletado:");
            Console.WriteLine("______________________________");
            string nome = Console.ReadLine(); 
            Console.Clear();
            Console.WriteLine("______________________________");
            Console.WriteLine("Digite a categoria do produto a ser deletado:");
            Console.WriteLine("______________________________");
            string categoria = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("______________________________");
            Console.WriteLine("Digite o preco do produto a ser deletado:");
            Console.WriteLine("______________________________");
            double preco = double.Parse(Console.ReadLine());
            Console.Clear();
          
            Produto produto = new Produto();
            produto._nome = nome;
            produto._id = ((int)(preco * 2));


            string dados = ProdutoInfo(produto._nome, categoria, preco);
            string arquivo = File.ReadAllText(path);
            string arquivoLimpo = arquivo.Replace(dados, string.Empty);

            File.Delete(path);
            File.AppendAllText(path, arquivoLimpo);
            if(File.ReadAllText(path) == string.Empty){
                File.Delete(path);
                Console.WriteLine("Pressione qualquer tecla para sair...");
                Console.ReadKey();
                Console.Clear();
            }else
            {
                Console.WriteLine("Pressione qualquer tecla para sair...");
                Console.ReadKey();
                Console.Clear();
            }
        }else
        {
            Console.Clear();
            Console.WriteLine("No momento não há produtos para deletar, pressione qualquer tecla para sair...");
            Console.ReadKey();
            Console.Clear();
        }
    }


    internal static void LerProdutos()
    {
        char separator = Path.DirectorySeparatorChar;
        string path = $@"Data{separator}produtos.txt";

        if(File.Exists(path))
        {
        Console.Clear();
        Console.WriteLine(File.ReadAllText(path));
        Console.ReadKey();
        Console.Clear();
        }else
        {
            Console.Clear();
            Console.WriteLine("Nenhum produto para ser lido no momento, pressione qualquer tecla para sair...");
            Console.ReadKey();
            Console.Clear();
        }
    }



}