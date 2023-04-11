using Exercicios;

Console.WriteLine("Entre a Largura e Altura do Retângulo: ");

 var retangulo = new Retangulo();

if (double.TryParse(Console.ReadLine(), out retangulo.Largura) &&
    double.TryParse(Console.ReadLine(), out retangulo.Altura))
{
    double area = retangulo.Area(retangulo.Altura, retangulo.Largura);
    double perimetro = retangulo.Perimetro(retangulo.Largura, retangulo.Altura);
    double diagonal = retangulo.Diagonal(retangulo.Largura, retangulo.Altura);

    Console.WriteLine($"Area: {area}");
    Console.WriteLine($"Perímetro {perimetro}");
    Console.WriteLine($"Diagonal {diagonal}");
}
else
{
    Console.WriteLine("Entrada inválida. Por favor, digite apenas valores numéricos.");
}

