namespace Parcial1Test
{
    public class TestUnitTrianguloBase
    {
        public static void Main()
        {
            Triangulo triangulo = new Triangulo(10, 5);
            Console.WriteLine($"Área del triángulo: {triangulo.Area()}");
            Console.WriteLine($"Perímetro del triángulo: {triangulo.Perimetro()}");
        }
    }
}