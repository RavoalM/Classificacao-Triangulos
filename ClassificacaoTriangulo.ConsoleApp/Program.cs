namespace ClassificacaoTriangulo.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            ExibirMenu();

            int ladoX = LerLado("X");
            int ladoY = LerLado("Y");
            int ladoZ = LerLado("Z");

            ExibirValoresInformados(ladoX, ladoY, ladoZ);

            bool medidasFormamTrianguloValido =
            Triangulo.MedidasFormamTrianguloValido(ladoX, ladoY, ladoZ);

                if (medidasFormamTrianguloValido)
                {
                    string tipoTriangulo = Triangulo.ClassificarTriangulo(ladoX, ladoY, ladoZ);

                    Console.WriteLine($"O triângulo é {tipoTriangulo}.");
                }
                else
                    Console.WriteLine("Creio esteja mais perto de ser o Michael Jackson que um triangulo");

                Console.WriteLine("================================================");
                Console.Write("Deseja continuar? (S/N) ");

                string opcaoContinuar = Console.ReadLine()!.ToUpper();

                if (opcaoContinuar != "S")
                    break;
        }
    }

    public static void ExibirMenu()
    {
        Console.Clear();
        Console.WriteLine("=======================================");
        Console.WriteLine("Classificação de Triangulos");
        Console.WriteLine("=======================================");
    }

    public static int LerLado(string nomeLado)
    {
        int valor;

        while (true)
        {
            Console.Write($"Informe o valor do lado {nomeLado}: ");

            bool conseguiuConverter = int.TryParse(Console.ReadLine(), out valor);

            if (conseguiuConverter)
            {
                break;
            }
        }

        return valor;
    }

    public static void ExibirValoresInformados(int ladoX, int ladoY, int ladoZ)
    {
    Console.Clear();    
    Console.WriteLine("===============================================");
    Console.WriteLine("Valores informados:");
    Console.WriteLine("Lado X: " + ladoX);
    Console.WriteLine("Lado Y: " + ladoY);
    Console.WriteLine("Lado Z: " + ladoZ);
    Console.WriteLine("===============================================");
    }
    
}
