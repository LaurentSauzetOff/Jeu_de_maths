namespace Jeu_de_maths
{
    class Program
    {
        static void PoserQuestion()
        {
            int reponseInt = 0;
            while (true)
            {
                Console.Write("5 + 2 = ");
                string reponse = Console.ReadLine();

                try
                {
                    reponseInt = int.Parse(reponse);
                    break;
                }
                catch
                {
                    Console.WriteLine("Erreur : vous devez entrer un nombre !");
                }
            }



        }
        static void Main(string[] args)
        {
            PoserQuestion();
        }
    }
}
