using System;
namespace GuessTheNum{
    class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        bool playAgain = true;
        int min = 1;
        int max = 100;
        int guess;
        int number;
        int guesses;

        while(playAgain)
        {
            String response = "";
            guess = 0;
            guesses = 0;
            number = rnd.Next(min,max+1);
            Console.Beep();

            while(guess != number)
            {
                Console.Write("Adivinhe o número entre "+min+" e "+max+": ");
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nTentativa: "+guess);
                if(guess > number)
                {
                    Console.WriteLine("Número muito alto!Tente novamente");
                }else if (guess < number)
                {
                    Console.WriteLine("Número é muito baixo!Tente novamente");
                }
                guesses++;
            }
            Console.WriteLine("Numero: " + number);
            Console.WriteLine("YOU WIN!!");
            Console.WriteLine("Tentativas: " + guesses);
            Console.WriteLine("Deseja jogar novamente? (s/n)");
            response = Console.ReadLine();
            if (response != "n") {
                Console.WriteLine("__RESTARTING__");
            }
            else
            {
                playAgain = false;
            }
        }
        Console.ReadKey();
        }
    }    
}

