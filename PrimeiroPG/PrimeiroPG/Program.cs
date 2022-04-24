using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeiroPG
{
    internal class Program
    {
        public static object SIM { get; private set; }

        static void Main(string[] args)
        {
            int counter = 0;
           while (counter < 5)
                {

                Console.WriteLine("\t\tBEM VINDO AO JOGO DE DADOS!\n Para vencer este jogo voce precisa de 15 pontos ou mais.\n\t\tPressione ENTER para jogar");
                Console.ReadLine();
                Console.WriteLine("Lançando DADOS...\n...\n...\n...\n...\n...\n...\n...\n...\n...\n...");
                Random dice = new Random();
                int roll1 = dice.Next(1, 7);
                int roll2 = dice.Next(1, 7);
                int roll3 = dice.Next(1, 7);

                int total = roll1 + roll2 + roll3;
                Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
                if (roll1 == roll2 && roll2 != roll3 || roll2 == roll3  && roll3 != roll1 || roll1 == roll3 && roll1 != roll2)
                {
                    Console.WriteLine("Parabéns, dois dados iguais! +2 pontos!");
                    total +=2;
                }

                if (roll1 == roll2 && roll2 == roll3)
                {
                    Console.WriteLine("Parabéns, tres dados iguais! +6 pontos!");
                    total+=6;
                }
                else if (total > 14)
                {
                    Console.WriteLine("Você venceu!");
                }
                else if (total < 15)
                {
                    Console.WriteLine("Ops, tente novamente...");
                }
                Console.WriteLine("Total de pontos: " + total);
                if (total >=16)
                {
                    Console.WriteLine("PARABÉNS! VOCÊ ATINGIU A MARCA DE 16 PONTOS OU MAIS E ACABA DE GANHAR UM CARRO NOVO!");
                }
                else if (total >=10)
                {
                    Console.WriteLine("PARABÉNS! VOCÊ ATINGIU A MARCA DE 10 PONTOS OU MAIS E ACABA DE GANHAR UM LAPTOP!");
                }
                else if (total == 7)
                {
                    Console.WriteLine("PARABÉNS! VOCÊ CRAVOU O NÚMERO 7 E ACABA DE GANHAR UMA VIAGEM!");
                }
                else
                {
                    Console.WriteLine("Como prêmio de consolação, você acabada de ganhar...\n.\n.\n. UM GATINHO!");
                }
                Console.ReadLine();
                }


        }
    }
}

        
