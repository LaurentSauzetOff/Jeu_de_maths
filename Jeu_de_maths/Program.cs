namespace Jeu_de_maths
{
    class Program
    {
        static void PoserQuestion()
        {
            int reponseInt = 0;
            while (reponseInt == 0)
            {
                Console.Write("5 + 2 = ");
                string reponse = Console.ReadLine();

                try
                {
                    reponseInt = int.Parse(reponse)
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
