﻿class Program()
{
    static void Main(string[] args)
    {
        List<Veiculo> listaDeVeiculos = new List<Veiculo>();

        listaDeVeiculos.Add(new Carro { modelo = "BMW" });
        listaDeVeiculos.Add(new Moto{modelo = "PCX" });
        listaDeVeiculos.Add(new Caminhao{ modelo = "Volvo FH16"});

        foreach(var tipo in listaDeVeiculos)
        {
            tipo.Dirigir();
        } 
    }
}