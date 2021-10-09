using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

public class Produto : PadraoProduto
{


    [Required]
    private int id;

    private string Nome;

    private double Preco;

    private string Categoria;


    internal string _nome
    {
        get{return Nome;}
        set{Nome = value;}
    }

    internal double _preco
    {
        get{return Preco;}
    }

    internal string _categoria
    {
        get{return Categoria;}
        set{Categoria = value;}
    }

    internal int _id
    {
        get{return id;}
        set{id = value;}
    }


    internal override void PrecificarProduto(int quantidade, int demanda)
    {

        Dictionary<int, double> modificador = new Dictionary<int, double>();
        modificador.Add(0, 0);
        modificador.Add(1, 10);
        modificador.Add(2, 20);
        modificador.Add(3, 40);
        modificador.Add(4, 80);
        modificador.Add(5, 160);
        modificador.Add(6, 320);
        modificador.Add(7, 640);
        modificador.Add(8, 1280);
        modificador.Add(9, 2560);
        modificador.Add(10, 5120);

        Preco = ((quantidade * modificador[demanda]) + modificador[demanda]) / quantidade;

    }



}