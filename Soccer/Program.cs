using Soccer.Logic;
using System;

namespace Soccer
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Team t1 = new Team("t1");
            t1.AddPlayer(new Player(6, 2, 10, 5, "Rysiek"));
            t1.AddPlayer(new Player(5, 3, 4, 5, "Krzysiek"));
            t1.AddPlayer(new Player(10, 10, 10, 10, "Jo"));
            t1.AddPlayer(new Player(4, 8, 9, 5, "Mama"));
            t1.AddPlayer(new Player(6, 2, 6, 7, "Tata"));
            t1.AddPlayer(new Player(2, 1, 7, 9, "Jo2"));
            t1.AddPlayer(new Player(5, 10, 4, 10, "Ptys"));
            t1.AddPlayer(new Player(8, 9, 10, 7, "Krawczyk"));
            t1.AddPlayer(new Player(9, 8, 7, 6, "Krzystof"));
            t1.AddPlayer(new Player(5, 4, 3, 2, "Szymon"));
            t1.AddPlayer(new Player(8, 4, 2, 8, "Rajmund"));
            t1.AddPlayer(new Player(9, 5, 4, 2, "Jo3"));
            t1.AddPlayer(new Player(6, 2, 10, 5, "Rysiek2"));
            t1.AddPlayer(new Player(5, 3, 4, 5, "Krzysiek2"));
            t1.AddPlayer(new Player(10, 10, 10, 10, "Jo4"));
            t1.AddPlayer(new Player(4, 8, 9, 5, "Mama2"));
            t1.AddPlayer(new Player(6, 2, 6, 7, "Tata2"));
            t1.AddPlayer(new Player(2, 1, 7, 9, "Jo5"));
            t1.AddPlayer(new Player(5, 10, 4, 10, "Ptys2"));
            t1.AddPlayer(new Player(8, 9, 10, 7, "Krawczyk2"));
            t1.AddPlayer(new Player(9, 8, 7, 6, "Krzystof2"));
            t1.AddPlayer(new Player(5, 4, 3, 2, "Szymon2"));
            t1.AddPlayer(new Player(8, 4, 2, 8, "Rajmund2"));
            t1.AddPlayer(new Player(9, 5, 4, 2, "Jo6"));

            Team t2 = new Team("t2");
            t2.AddPlayer(new Player(6, 2, 10, 5, "Marek"));
            t2.AddPlayer(new Player(5, 3, 4, 5, "Krysia"));
            t2.AddPlayer(new Player(10, 10, 10, 10, "Zyzio"));
            t2.AddPlayer(new Player(2, 4, 8, 5, "Danka"));
            t2.AddPlayer(new Player(10, 10, 10, 10, "Klaudia"));
            t2.AddPlayer(new Player(5, 8, 2, 1, "Dzozef"));
            t2.AddPlayer(new Player(9, 5, 10, 2, "Karol"));
            t2.AddPlayer(new Player(8, 6, 2, 9, "Kiszke"));
            t2.AddPlayer(new Player(10, 2, 6, 3, "Kapucz"));
            t2.AddPlayer(new Player(6, 2, 7, 8, "Jo4"));
            t2.AddPlayer(new Player(9, 5, 4, 8, "Ewelina"));
            t2.AddPlayer(new Player(5, 8, 8, 1, "Gosia"));
            t2.AddPlayer(new Player(6, 2, 10, 5, "Marek2"));
            t2.AddPlayer(new Player(9, 7, 4, 7, "Krysia2"));
            t2.AddPlayer(new Player(4, 6, 8, 1, "Zyzio2"));
            t2.AddPlayer(new Player(2, 4, 8, 5, "Danka2"));
            t2.AddPlayer(new Player(10, 10, 10, 10, "Klaudia2"));
            t2.AddPlayer(new Player(5, 8, 2, 1, "Dzozef2"));
            t2.AddPlayer(new Player(9, 5, 10, 2, "Karol2"));
            t2.AddPlayer(new Player(8, 6, 2, 9, "Kiszke2"));
            t2.AddPlayer(new Player(10, 2, 6, 3, "Kapucz2"));
            t2.AddPlayer(new Player(6, 2, 7, 8, "Jo7"));
            t2.AddPlayer(new Player(9, 5, 4, 8, "Ewelina2"));
            t2.AddPlayer(new Player(5, 8, 8, 1, "Gosia2"));

            Game g1 = new Game(t1,t2, new LuckFactory(DateTime.Now.Millisecond));
            g1.Run();

            Console.WriteLine($"Wygral {g1.Winner.TeamName}");
            Console.WriteLine($"Przegral {g1.Losser.TeamName}");


            Console.ReadKey();
        }

    }
}
