class Types
{
    static void Main(string[] args)
    {
        int a = 10;
        double b = 3.5;
        decimal c = 9.99m;
        string d = "texto";

        Console.WriteLine(a.GetType());   // System.Int32
        Console.WriteLine(b.GetType());   // System.Double
        Console.WriteLine(c.GetType());   // System.Decimal
        Console.WriteLine(d.GetType());   // System.String

        //Console.Write escreve o texto e deixa o cursor no fim, na mesma linha.
        Console.Write("Como te chamas? ");
        string nome = Console.ReadLine();

        //Console.WriteLine escreve o texto e muda de linha (o cursor passa para a linha seguinte).
        Console.WriteLine($"Olá {nome}!");
    }
}