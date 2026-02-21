using System.Drawing;
using System.IO;

namespace CursoProgramação
{
    public class Aula1
    {

        public void Soma()
        {
            int valor1;
            int valor2;

            Console.WriteLine("informe o valor 1");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("informe o valor 2");
            valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine(valor1 + valor2);
        }

        public void Multiplicar()
        {

            int valor3;
            int valor4;
            Console.WriteLine("Informe qual valor deseja multiplicar");
            valor3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe qual outro valor deseja multiplicar por");
            valor4 = int.Parse(Console.ReadLine());

            Console.WriteLine(valor3 * valor4);

        }

        public void Divisao()
        {
            int valor1;
            int valor2;
            Console.WriteLine("Informe qual valor deseja dividir");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe qual outro valor deseja dividir por");
            valor2 = int.Parse(Console.ReadLine());

            if (valor1 == 0 || valor2 == 0)
            {
                Console.WriteLine("Erro, não pode dividir por 0");
            }
            else
            {
                Console.WriteLine(valor1 / valor2);
            }

        }

        public void Subtracao()
        {

            int valor1;
            int valor2;

            Console.WriteLine("informe o valor 1");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("informe o valor 2");
            valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine(valor1 - valor2);
        }

    }
}