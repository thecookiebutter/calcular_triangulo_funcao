// Importação dos namespaces necessários
using System;
using System.Globalization;

// Declaração do namespace do programa
namespace Course
{
    // Declaração da classe Program
    public class Program
    {
        // Método principal que é executado ao iniciar o programa
        public static void Main(string[] args)
        {
            // Declaração dos arrays de medidas dos triângulos X e Y
            double[] medidasX = LerMedidasTriangulo("X");
            double[] medidasY = LerMedidasTriangulo("Y");

            // Cálculo da área dos triângulos X e Y
            double areaX = CalcularAreaTriangulo(medidasX);
            double areaY = CalcularAreaTriangulo(medidasY);

            // Impressão das áreas calculadas com formatação de 4 casas decimais
            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            // Verificação da maior área e impressão do resultado
            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
        

        // Método responsável por ler as medidas de um triângulo
        public static double[] LerMedidasTriangulo(string nomeTriangulo)
        {
            // Declaração do array de medidas com 3 elementos
            double[] medidas = new double[3];

            // Solicitação ao usuário para inserir as medidas do triângulo
            Console.WriteLine("Entre com as medidas do triângulo " + nomeTriangulo + ":");
            for (int i = 0; i < 3; i++)
            {
                // Leitura das medidas fornecidas pelo usuário e armazenamento no array
                medidas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            // Retorno do array de medidas
            return medidas;
        }

        // Método responsável por calcular a área de um triângulo com base nas medidas fornecidas
        public static double CalcularAreaTriangulo(double[] medidas)
        {
            // Atribuição das medidas a variáveis individuais
            double a = medidas[0];
            double b = medidas[1];
            double c = medidas[2];

            // Cálculo do semiperímetro
            double p = (a + b + c) / 2.0;
            // Cálculo da área usando a fórmula de Heron
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            // Retorno da área calculada
            return area;
        }
    }
}
