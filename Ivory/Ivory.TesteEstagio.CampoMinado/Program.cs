using System;

namespace Ivory.TesteEstagio.CampoMinado
{
    class Program
    {

		static void Main(string[] args)
        {

            var campoMinado = new CampoMinado();
            Console.WriteLine("Início do jogo\n=========");
            Console.WriteLine(campoMinado.Tabuleiro);

            // Realize sua codificação a partir deste ponto, boa sorte!

            // Forma que o usuário coloca as coordenadas:

            /*            while (campoMinado.JogoStatus == 0)
                        {
                            Console.WriteLine("Digite a nova coordenada:");
                            Console.WriteLine("Digite a linha primeiro, depois a coluna.");
                            campoMinado.Abrir(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                            Console.WriteLine(campoMinado.Tabuleiro);

                            if (campoMinado.JogoStatus == 1)
                            {
                                Console.WriteLine("Parabéns, você ganhou!");
                            } else if (campoMinado.JogoStatus == 2)
                            {
                                Console.WriteLine("Que pena, você perdeu.");
                            }
                        }
            */

            // Forma autônoma:

            Random rnd = new Random();

            while (campoMinado.JogoStatus == 0)
            {

                    Console.WriteLine("Nova coordenada:");
                    campoMinado.Abrir(rnd.Next(1, 10), rnd.Next(1, 10));
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine(campoMinado.Tabuleiro);

                    if (campoMinado.JogoStatus == 1)
                {
                    Console.WriteLine("Parabéns, você ganhou!");
                }
                    else if (campoMinado.JogoStatus == 2)
                {
                    Console.WriteLine("Que pena, você perdeu.");
                }


            }

        }
    }
}
