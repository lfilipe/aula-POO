using System;

// Classe base (superclasse)
class Imovel
{
    protected double area;          // acessível nesta classe e nas derivadas
    private string numeroPredial;   // acessível apenas nesta classe

    public Imovel(double area, string numeroPredial)
    {
        this.area = area;
        this.numeroPredial = numeroPredial;
    }

    public void AbrirPorta()
    {
        Console.WriteLine("Rodar a chave e empurrar a porta");
    }
}

// Classe derivada: Moradia "é um" Imovel
class Moradia : Imovel
{
    double areaJardim;

    // base(...) invoca o construtor da classe base
    public Moradia(double area, string numeroPredial, double areaJardim)
        : base(area, numeroPredial)
    {
        this.areaJardim = areaJardim;
    }

    public void MostrarJardim()
    {
        Console.WriteLine("O jardim da moradia tem " + areaJardim + " m²");
    }
}

// Classe derivada: Apartamento "é um" Imovel
class Apartamento : Imovel
{
    int andar;

    public Apartamento(double area, string numeroPredial, int andar)
        : base(area, numeroPredial)
    {
        this.andar = andar;
    }

    public void MostrarAndar()
    {
        Console.WriteLine("Apartamento no " + andar + "º andar");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Moradia moradiaCampo = new Moradia(300, "CASA-456", 50);
        moradiaCampo.MostrarJardim();
        moradiaCampo.AbrirPorta();      // método herdado de Imovel

        Apartamento apartamento1Porto = new Apartamento(80, "APTO-00123", 3);
        apartamento1Porto.MostrarAndar();
        apartamento1Porto.AbrirPorta(); // método herdado de Imovel
    }
}
