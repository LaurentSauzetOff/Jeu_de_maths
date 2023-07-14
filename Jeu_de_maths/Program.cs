namespace Jeu_de_maths
{
    class Program
    {
        static bool PoserQuestion(int min, int max)
        {
            Random rand = new Random();
            int reponseInt = 0;
            while (true)
            {
                int a = rand.Next(min, max + 1);
                int b = rand.Next(min, max + 1);

                Console.Write(a + " + " + b + " = ");
                string reponse = Console.ReadLine();
                try
                {
                    reponseInt = int.Parse(reponse);
                    if (reponseInt == a + b)
                    {
                        return true;
                    }
                    return false;
                }
                catch
                {
                    Console.WriteLine("Erreur : vous devez entrer un nombre !");
                }
            }



        }
        static void Main(string[] args)
        {
            const int NOMBRE_MIN = 1;
            const int NOMBRE_MAX = 10;
            const int NOMBRE_QUESTIONS = 3;

            int points = 0;

            for (int i = 0; i < NOMBRE_QUESTIONS; i++)
            {
                Console.WriteLine("Question N° " + (i + 1) + NOMBRE_QUESTIONS);

                bool bonneReponse = PoserQuestion(NOMBRE_MIN, NOMBRE_MAX);
                if (bonneReponse)
                {
                    Console.WriteLine("Bonne réponse !");
                    points++;
                }
                else
                {
                    Console.WriteLine("Mauvaise réponse:");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Nombre de points : " + points + "/" + NOMBRE_QUESTIONS);

            // 100% bonnes réponses = Excellent
            // 0 => Révisez vos maths

            // 10 => 5 ( 10/2 = 5)
            // 5/2 = 2,5 => 2
            int moyenne = NOMBRE_QUESTIONS / 2;

            //> moyenne = pas mal
            // <=moyenne => Peux mieux faire

            if (points == NOMBRE_QUESTIONS)
            {
                Console.WriteLine("Excellent");
            }
            else if (points == 0)
            {
                Console.WriteLine("Révisez vos maths !");
            }
            else if (points > moyenne)
            {
                Console.WriteLine("Pas mal");
            }
            else
            {
                Console.WriteLine("Peux mieux faire");
            }
        }
    }
}
