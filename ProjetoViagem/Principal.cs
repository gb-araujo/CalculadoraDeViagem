using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CalculadoraViagem
{
    public class Principal
    {
        public static void Main(string[] args)
        {

            Percurso percurso1 = new Percurso();
            Custos calcular = new Custos();
            calcular.CalcularViagem(percurso1);
            

            int selecao;


            while (true) {
                mostrarMenu();
                selecao = int.Parse(Console.ReadLine());
            switch(selecao)
            {
                case 1:
                    Console.WriteLine("Digite a KM percorrida");
                    double x = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor do combustivel");
                    double y = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor do pedágio");
                    double z = double.Parse(Console.ReadLine());
                    percurso1 = new Percurso(x, y, z);
                    Console.WriteLine("Novo percurso criado.");

                    break;
                case 2:
                    Console.WriteLine($"Valores do percurso: " +
                        $"Percorridos: {percurso1.kmPercorrida}," +
                        $" valor do Combustivel: {percurso1.valorCombustivel}," +
                        $"valor do pedágio:  {percurso1.valorPedagio}");
                    break;
                case 3:
                    double calculo = calcular.CalcularViagem(percurso1);
                    Console.WriteLine($"O valor total é de {calculo}");
                    break; 
                case 0:
                    Console.WriteLine("Aperte ENTER para sair");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Número inválido.");
                    break;
            }
            }

        }

        public static void mostrarMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Novo percurso");
            Console.WriteLine("2. Listar percurso");
            Console.WriteLine("3. Calcular custos");
            Console.WriteLine("0. Sair");
            Console.WriteLine("Escolha uma opção: ");
        }
    }
}
