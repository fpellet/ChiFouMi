namespace ChiFouMi
{
    using System;
    using System.Linq;

    class Program
    {
        private static bool roxorMoMode;

        static void Main(string[] args)
        {
            #region
            if (args.Any())
            {
                if (args[0].Equals("roxor"))                 roxorMoMode = true;
            }
            #endregion

            #region intro
            string str_ = "exit";
            var str_textIntro = "Veuillez choisir un signe:";
            Console.WriteLine("Bienvenue dans mon chifumi, ici c'est un appli de ROXXXXXXXXXXXXXXXOOR!");
            Console.WriteLine("Taper sur la touche entrée pour commencer une partie, ou 'exit' pour quitter.");
            #endregion

            #region jeu
            while (!
                Console.ReadLine().Equals("exit"))
            {
                #region intro
                Console.WriteLine(str_textIntro);
                Console.WriteLine("1- Pierre");
                Console.WriteLine("2- Feuille");
                Console.WriteLine("3- Ciseaux");
                var int_us = int.Parse(Console.ReadLine());
                #endregion

                #region
                //var rand = new Random(DateTime.Now.Millisecond);
                //var intPersonalComputer = rand.Next(1, 6);

                //if (roxorMoMode != false && intPersonalComputer == 6)
                //{
                //    Console.WriteLine("Tu es un roxor contre Spock");
                //    Console.WriteLine("Gagne!");
                //}
                //else if (int_us == 1 && intPersonalComputer == 1)
                //{
                //    Console.WriteLine("Pierre contre Pierre!");
                //    Console.WriteLine("Egalite!");
                //}
                //else if (roxorMoMode != false && intPersonalComputer == 2)
                //{
                //    Console.WriteLine("Tu es un roxor contre Feuille");
                //    Console.WriteLine("Gagne!");
                //}
                //else if (int_us == 1 && intPersonalComputer == 2)
                //{
                //    Console.WriteLine("Pierre contre Feuille!");
                //    Console.WriteLine("Perdu!");
                //}
                #endregion

                #region business logic
                var rand = new Random(DateTime.Now.Millisecond);
                var intPersonalComputer = rand.Next(1, 4);

                if (roxorMoMode != false && intPersonalComputer == 1)
                {
                    Console.WriteLine("Tu es un roxor contre Pierre");
                    Console.WriteLine("Gagne!");
                }
                else if (int_us == 1 && intPersonalComputer == 1)
                {
                    Console.WriteLine("Pierre contre Pierre!");
                    Console.WriteLine("Egalite!");
                }
                else if (roxorMoMode != false && intPersonalComputer == 2)
                {
                    Console.WriteLine("Tu es un roxor contre Feuille");
                    Console.WriteLine("Gagne!");
                }
                else if(int_us == 1 && intPersonalComputer == 2)
                {
                    Console.WriteLine("Pierre contre Feuille!");
                    Console.WriteLine("Perdu!");
                }
                else if (roxorMoMode != false && intPersonalComputer == 3)
                {
                    Console.WriteLine("Tu es un roxor contre Ciseaux");
                    Console.WriteLine("Gagne!");
                }

                else if (int_us == 1 && intPersonalComputer == 3)
                {
                    Console.WriteLine("Pierre contre Ciseaux!");
                    Console.WriteLine("Gagne!");
                }
                else if (roxorMoMode != false && intPersonalComputer == 2)
                {
                    Console.WriteLine("Tu es un roxor contre Feuille");
                    Console.WriteLine("Gagne!");
                }
                else if (int_us == 2 && intPersonalComputer == 1)
                {
                    Console.WriteLine("Feuille contre Pierre!");
                    Console.WriteLine("Gagne!");
                }
                else if (int_us == 2 && intPersonalComputer == 2)
                {
                    Console.WriteLine("Feuille contre Feuille!");
                    Console.WriteLine("Egalite!");
                }

                else if (int_us == 2 && intPersonalComputer == 3)
                {
                    Console.WriteLine("Feuille contre Ciseaux!");
                    Console.WriteLine("Perdu!");
                }
                else if (roxorMoMode != false && intPersonalComputer == 3)
                {
                    Console.WriteLine("Tu es un roxor contre Ciseaux");
                    Console.WriteLine("Gagne!");
                }
                else if (int_us == 3 && intPersonalComputer == 1)
                {
                    Console.WriteLine("Ciseaux contre Pierre!");
                    Console.WriteLine("Perdu!");
                }
                else if (int_us == 3 && intPersonalComputer == 2)
                {
                    Console.WriteLine("Ciseaux contre Feuille!");
                    Console.WriteLine("Gagne!");
                }

                else if (int_us == 3 && intPersonalComputer == 3)
                {
                    Console.WriteLine("Ciseaux contre Ciseaux!");
                    Console.WriteLine("Egalite!");
                }
                else if (int_us == 3 && intPersonalComputer == 4)
                {
                    Console.WriteLine("Ciseaux contre Ciseaux!");
                    Console.WriteLine("Egalite!");
                }
                else if (int_us == 3 && intPersonalComputer == 5)
                {
                    Console.WriteLine("Ciseaux contre Ciseaux!");
                    Console.WriteLine("Egalite!");
                }
                else if (int_us == 4 && intPersonalComputer == 4)
                {
                    Console.WriteLine("Ciseaux contre Ciseaux!");
                    Console.WriteLine("Egalite!");
                }
                else if ("exit".Equals(str_))
                {
                    break;
                }

                else if (true)
                {
                    Console.WriteLine("Je sais pas");
                }

                else
                {
                    Console.WriteLine("Perdu");
                }
            }
                #endregion
            #endregion
        }
    }
}
