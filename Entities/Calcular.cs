namespace Calculadora.Entities
{
    public class Calcular
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void Multiplicar(float x, float y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
        public void Dividir(float x, float y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void Potencia(double x, double y)
        {
            double poten = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} = {poten}");
        }

        //Funções Trigométrica: Seno, Coseno, Tangente com a classe Math
        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}* = {Math.Round(seno,4)}");
        }
        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo}* = {Math.Round(coseno,4)}");
        }
        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}* = {Math.Round(tangente,4)}");
        }
        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
        }

    }
}