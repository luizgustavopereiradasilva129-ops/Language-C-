using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)

    {
        // Configuração cultural
        CultureInfo CI = CultureInfo.InvariantCulture;

        // Declaração de variáveis
        double baseRetangulo, alturaRetangulo, areaRetangulo;
        double area;
        double perimetro;
        double diagonal;

        // Entrada de dados
        Console.Write("Base do retangulo: ");
        double baseretangulo = double.Parse(Console.ReadLine(), CI);
        Console.Write("Altura do rertangulo: ");
        double alturaretangulo = double.Parse(Console.ReadLine(), CI);

        // Cálculo da área, perímetro e diagonal

        area = baseretangulo * alturaretangulo;
        perimetro = 2 * (baseretangulo + alturaretangulo);
        diagonal = Math.Sqrt(Math.Pow(baseretangulo, 2) + Math.Pow(alturaretangulo, 2));

        // Saída de dados

        Console.WriteLine("Area =" + area.ToString("F4"));
        Console.WriteLine("Perimetro =" + perimetro.ToString("F4"));
        Console.WriteLine("Diagonal =" + diagonal.ToString("F4"));
    }
}
