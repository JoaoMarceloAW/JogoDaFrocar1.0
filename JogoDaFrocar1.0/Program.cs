namespace JogoDaFrocar1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palavraSecreta = "MELANCIA";

            char[] letrasEncontrada =  new char [palavraSecreta.Length];

            for (int i = 0; i < letrasEncontrada.Length; i++)
            {
                letrasEncontrada[i] = '-';
            }

            bool acertou = false;
            bool enforcou = false;
            int erros = 0;


            do
            {
                DesenharForca(erros);

                Console.WriteLine(letrasEncontrada);

                // receber o input do jogador
                Console.Write("Qual o seu chute? ");
                char chute = Convert.ToChar(Console.ReadLine());

                bool letraFoiEncontrada = false;

                // comparar o chute com cada letra da palavraSecreta
                for (int i = 0; i < palavraSecreta.Length; i++)
                {
                    // se o chute for igual a palavra secreta
                    if (chute == palavraSecreta[i])
                    {
                        letrasEncontrada[i] = chute;
                        letraFoiEncontrada = true;
                    }
                }

                if (letraFoiEncontrada == false)
                    erros++;

                // caso o usuário acerte a palavra inteira
                string palavraEncontrada = new string(letrasEncontrada);

                acertou = palavraEncontrada == palavraSecreta;
                enforcou = erros == 5;

                if (acertou)
                    Console.WriteLine($"Você acertou a palavra {palavraSecreta}, parabéns!");
                else if (enforcou)
                    Console.WriteLine("Que azar! Tente novamente!");

            } while (acertou == false && enforcou == false);


            Console.ReadLine();
        }

        private static void DesenharForca(int quantidadeErros)
        {
            // operação ternária
            string cabecaDoBoneco = quantidadeErros >= 1 ? " o " : " ";
            string bracoEsquerdo = quantidadeErros >= 3 ? "/" : " ";
            string tronco = quantidadeErros >= 2 ? "x" : " ";
            string troncoBaixo = quantidadeErros >= 2 ? " x " : " ";
            string bracoDireito = quantidadeErros >= 3 ? @"\" : " ";
            string pernas = quantidadeErros >= 4 ? "/ \\" : " ";

            Console.Clear();
            Console.WriteLine(" ___________        ");
            Console.WriteLine(" |/        |        ");
            Console.WriteLine(" |        {0}       ", cabecaDoBoneco);
            Console.WriteLine(" |        {0}{1}{2} ", bracoEsquerdo, tronco, bracoDireito);
            Console.WriteLine(" |        {0}       ", troncoBaixo);
            Console.WriteLine(" |        {0}       ", pernas);
            Console.WriteLine(" |                  ");
            Console.WriteLine(" |                  ");
            Console.WriteLine("_|____              ");

        }
    }
}