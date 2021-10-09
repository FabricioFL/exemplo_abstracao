using System;

internal class Menus : GerenciarProdutos
{

    internal static void MenuPrincipal()
    {
        inicio:

        Console.Clear();
        Console.WriteLine("_______________|Gerenciar Produtos|______________\n\n\n");
        Console.WriteLine("Digite o inice da ação a ser executada:\n\n(0) Fechar a aplicação.\n\n(1) Registrar produto.\n\n(2) Deletar produto.\n\n(3) Ler Produtos.");
        Console.WriteLine("_________________________________________________");
        string indicador = Console.ReadLine();

        switch(indicador)
        {

            case "0":
                Console.Clear();
                Environment.Exit(0);
            break;
            case "1":
                CriarProduto();
            goto inicio;
            case "2":
                DeletarProduto();
            goto inicio;
            case "3":
                LerProdutos();
            goto inicio;
            default:
            goto inicio;
        }
    }


}