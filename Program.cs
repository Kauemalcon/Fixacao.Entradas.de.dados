using System;
using System.Globalization;

namespace Fixacao.Entradas.de.dados
{
    class Program
    {
        static void Main(string[] args)
        {
            //int y = 32;

            //int w = y++;

            //double z = 100 % 60;

            //string x = "Maria";

            //Console.WriteLine("{0} tem {1} anos e saldo de {2:F2} reais", x.ToUpper(), ++y + ++w, z);


            //------------------------------------------------------------


            //Console.WriteLine("Entre com o priemiro valor");
            //int valor = int.Parse(Console.ReadLine());
            //Console.WriteLine("Entre com o segundo valor");
            //int valor1 = int.Parse(Console.ReadLine());

            //int soma = valor + valor1;

            //Console.WriteLine($"SOMA = {soma} ");

            //------------------------------------------------------------

            //Console.WriteLine("Entree com o valor do raio");
            //double raio = double.Parse(Console.ReadLine());

            //double pi = 3.14159;

            //double area = pi * (raio * raio);

            //Console.WriteLine($"A = {area.ToString("F4")}");

            //-----------------------------------------------------------

            //while

            //Console.WriteLine("Digite um numero: ");
            //int numero = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //while (numero >= 0.0)
            //{
            //    double raiz = Math.Sqrt(numero);
            //    Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
            //    Console.WriteLine("Digite outro numero: ");
            //    numero = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //}
            //Console.WriteLine("Numero negativo!");

            //+--------------------------------------

            //Console.WriteLine( "informe a senha:");
            //int senha = int.Parse(Console.ReadLine());
            //while (senha != 2002)
            //{
            //    Console.WriteLine("Senha invalida!");
            //    Console.WriteLine("informe outra senha!");
            //    senha = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Senha correta!");

            //------------------------------------------------------

            //string[] valores = Console.ReadLine().Split(' ');
            //int x = int.Parse(valores[0]);
            //int y = int.Parse(valores[1]);

            //while(x != 0 && y != 0)
            //{
            //    if (x > 0 && y > 0)
            //    {
            //        Console.WriteLine("primeiro");
            //    }
            //    else if (x > 0 && y < 0)
            //    {
            //        Console.WriteLine("segundo");
            //    }
            //    else if (x < 0 && y < 0)
            //    {
            //        Console.WriteLine("terceiro");
            //    }
            //    else
            //    {
            //        Console.WriteLine("quarto");
            //    }
            //    valores = Console.ReadLine().Split(' ');
            //    x = int.Parse(valores[0]);
            //    y = int.Parse(valores[1]);
            //}


            //-----------------------------------------------------

            //int alcool = 0;
            //int diesel = 0;
            //int gasolina = 0;

            //Console.WriteLine("Entre com o tipo de combustivel");
            //int tipo = int.Parse(Console.ReadLine());

            //while (tipo != 4)
            //{
            //    if (tipo == 1)
            //    {
            //        gasolina = gasolina + 1;
            //    }
            //    else if (tipo == 2)
            //    {
            //        alcool = alcool + 1;
            //    }
            //    else if (tipo == 3)
            //    {
            //        diesel = diesel + 1;
            //    }

            //    tipo = int.Parse(Console.ReadLine());

            //}
            //Console.WriteLine("MUITO OBRIGADO");
            //Console.WriteLine("gasolina: "+ gasolina);
            //Console.WriteLine("alcool: "+ alcool);
            //Console.WriteLine("diesel: "+ diesel);

            //---------------------------------------------------

            //Console.WriteLine("Entre com o valor:");
            //int x = int.Parse(Console.ReadLine());

            //for(int i = 1; i <= x; i++)
            //{
            //    if(i % 2 == 1)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //---------------------------------------------------

            //Console.WriteLine("entre com o valor de repetição: ");
            //int valor = int.Parse(Console.ReadLine());

            //int countIn = 0;
            //int countOut = 0;

            //for (int i = 1; i <= valor; i++)
            //{
            //    Console.WriteLine("entre com os valores:");
            //    int valor1 = int.Parse(Console.ReadLine());

            //    if (valor1 >= 10 && valor1 <= 20)
            //    {
            //        countIn += 1;
            //    }
            //    else
            //    {
            //        countOut += 1;
            //    }


            //}
            //Console.WriteLine($"{countIn} in");
            //Console.WriteLine($"{countOut} out");

            //---------------------------------------------------------



            //Console.WriteLine("Entre com a quantidade de repetições:");
            //int rep = int.Parse(Console.ReadLine());

            //for (int i = 0; i < rep; i++)
            //{
            //    string[] valores = Console.ReadLine().Split(' ');
            //    double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            //    double y = double.Parse(valores[1], CultureInfo.InvariantCulture);
            //    double z = double.Parse(valores[2], CultureInfo.InvariantCulture);

            //    double media = (x * 2 + y * 3 + z * 5) / 10;

            //    Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            //}

            //-----------------------------------------

            //Console.WriteLine("Entre com o valor:");
            //int n = int.Parse(Console.ReadLine());

            //for(int i = 0; i < n; i++)
            //{
            //    string[] valores = Console.ReadLine().Split(' ');
            //    double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            //    double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            //    if(x >= 0 && y <= 0)
            //    {
            //        double media = x / y;
            //        Console.WriteLine(media);
            //    }
            //    else if (x <= 0 && y == 0)
            //    {
            //        Console.WriteLine("Impossivel resolver");
            //    }
            //    else
            //    {
            //        double media = x / y;
            //        Console.WriteLine(media);
            //    }
            //}

            //---------------------------------------------------

            //int n = int.Parse(Console.ReadLine());
            //// FATORIAL
            //int fat = 1;
            //for (int i = 1; i <= n; i++)
            //{
            //    fat = fat * i;
            //}

            //Console.WriteLine(fat);

            //---------------------------------------------------+


            //Console.WriteLine("Entre com o valor:");
            //int n = int.Parse(Console.ReadLine());
            ////DIVISORES
            //for(int i = 1; i <= n; i++)
            //{
            //    if(n % i == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //-------------------------------------------------------
            Console.WriteLine("entre com o valor");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                int primeiro = i; // mostrar a quantidade de linhas
                int segunto = i * i;// mostrar valor ao quadrado
                int terceiro = i * i * i;// mostrar o valro ao cubo

                Console.WriteLine($"{primeiro} {segunto} {terceiro}");
            }
        }
    }

}



