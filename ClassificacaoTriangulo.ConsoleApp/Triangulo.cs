namespace ClassificacaoTriangulo.ConsoleApp
{
    class Triangulo
    {
        public static bool MedidasFormamTrianguloValido(int ladoX, int ladoY, int ladoZ)
        {
            bool medidasTrianguloValidas =
                ladoX + ladoY > ladoZ &&
                ladoX + ladoZ > ladoY &&
                ladoY + ladoZ > ladoX;

            return medidasTrianguloValidas;
        }
        public static string ClassificarTriangulo(int ladoX, int ladoY, int ladoZ)
        {
            string tipoTriangulo = "Algo novo, a gente não sabe o que é isso você ta de parabens em!!!";

            if (ladoX == ladoY && ladoY == ladoZ)
                tipoTriangulo = "Equilatero (Todos os lados iguais)";

            else if (ladoX != ladoY && ladoY != ladoZ && ladoX != ladoZ)
                tipoTriangulo = "Escaleno (Todos os lados diferentes)";

            else
                tipoTriangulo = "Isosceles (Dois lados iguais)";

            return tipoTriangulo;
        }
    }
}
