using System;

namespace Diamante_de_letras.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // Entrada da variavel inteira do tipo aschi que permite ultilizarmos variaveis inteiras mas usando letras ao inves de numeros.
            int letraA = 'A';

            // Variavel que referece ao meio do diamante. 
            int meioDoDiamante;

            //while repetir enquanto for true.
            while (true)
            {
                Console.Write("Digite que será a metade do diamante a letra precisa ser MAIUSCULA: ");
                meioDoDiamante = Console.Read();

                if (meioDoDiamante > 90 || meioDoDiamante < 65)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Por favor, digite um valor entre A e Z (maiúsculo)!");
                    Console.ReadLine();

                    Console.ResetColor();
                    continue;
                }
                else
                    break;
            }

                int tamanhoInicialEspacosEx = meioDoDiamante - letraA;
                int tamanhoInicialEspacosIn = -1;

                Console.WriteLine();

                #region Parte Superior do Diamante
            Console.ForegroundColor = ConsoleColor.Cyan;

                for (int i = letraA; i < meioDoDiamante; i++)
                {
                    // Desenhando espaços do exterior do diamante
                    for (int j = 0; j < tamanhoInicialEspacosEx; j++)
                        Console.Write(" ");

                    char letraAtual = Convert.ToChar(i);

                    // Desenhando primeira letra
                    Console.Write(letraAtual);

                    // Desenhando espaços do interior
                    for (int k = 0; k < tamanhoInicialEspacosIn; k++)
                        Console.Write(" ");

                    // Desenhando segunda letra
                    if (i != letraA)
                        Console.Write(letraAtual);

                    Console.WriteLine();

                    tamanhoInicialEspacosEx--;
                    tamanhoInicialEspacosIn += 2;
                }

                #endregion

                #region Parte Inferior do Diamante

                for (int i = meioDoDiamante; i >= letraA; i--)
                {
                    // Desenhando espaços do exterior do diamante
                    for (int j = 0; j < tamanhoInicialEspacosEx; j++)
                        Console.Write(" ");

                    char letraAtual = Convert.ToChar(i);

                    // Desenhando primeira
                    Console.Write(letraAtual);

                    // Desenhando espaços do interior
                    for (int k = 0; k < tamanhoInicialEspacosIn; k++)
                        Console.Write(" ");

                    // Desenhando segunda letra
                    if (i != letraA)
                        Console.Write(letraAtual);

                    Console.WriteLine();

                    tamanhoInicialEspacosEx++;
                    tamanhoInicialEspacosIn -= 2;
                }

                #endregion

                Console.ReadKey();
                Console.WriteLine("Pressioe qualquer tecla para sair...");

            }
        }
    }