using System;
using Soccer.Logic;
using Xunit;

namespace Soccesr.Logic.Tests
{
    public class GameTests
    {
        public GameTests()
        {
        }

        [Fact]
        public void Game_WinFirst_Test()
        {
            Team t1 = new Team("t1");
            Team t2 = new Team("t2");

            t1.AddPlayer(new Player(5, 5, 5, 5, "Rysiek"));
            t1.AddPlayer(new Player(5, 5, 5, 5, "Krzysiek"));
            t1.AddPlayer(new Player(5, 5, 5, 5, "Jo"));
            t1.AddPlayer(new Player(5, 5, 5, 5, "Mama"));
            t1.AddPlayer(new Player(5, 5, 5, 5, "Tata"));
            t1.AddPlayer(new Player(5, 5, 5, 5, "Jo2"));
            t1.AddPlayer(new Player(5, 5, 5, 5, "Ptys"));
            t1.AddPlayer(new Player(5, 5, 5, 5, "Krawczyk"));
            t1.AddPlayer(new Player(5, 5, 5, 5, "Krzystof"));
            t1.AddPlayer(new Player(5, 5, 5, 5, "Szymon"));
            t1.AddPlayer(new Player(5, 5, 5, 5, "Rajmund"));

            t2.AddPlayer(new Player(1, 1, 1, 1, "Marek"));
            t2.AddPlayer(new Player(1, 1, 1, 1, "Krysia"));
            t2.AddPlayer(new Player(1, 1, 1, 1, "Zyzio"));
            t2.AddPlayer(new Player(1, 1, 1, 1, "Danka"));
            t2.AddPlayer(new Player(1, 1, 1, 1, "Klaudia"));
            t2.AddPlayer(new Player(1, 1, 1, 1, "Dzozef"));
            t2.AddPlayer(new Player(1, 1, 1, 1, "Karol"));
            t2.AddPlayer(new Player(1, 1, 1, 1, "Kiszke"));
            t2.AddPlayer(new Player(1, 1, 1, 1, "Kapucz"));
            t2.AddPlayer(new Player(1, 1, 1, 1, "Jo4"));
            t2.AddPlayer(new Player(1, 1, 1, 1, "Ewelina"));

            Game g1 = new Game(t1, t2, new TestLuckFactory(0));
            g1.Run();

            Assert.Equal(t1.TeamName, g1.Winner.TeamName);
            Assert.Equal(t2.TeamName, g1.Losser.TeamName);
        }

        [Fact]
        public void Game_WinSeccond_Test()
        {
            Team t1 = new Team("t1");
            Team t2 = new Team("t2");

            t2.AddPlayer(new Player(5, 5, 5, 5, "Rysiek"));
            t2.AddPlayer(new Player(5, 5, 5, 5, "Krzysiek"));
            t2.AddPlayer(new Player(5, 5, 5, 5, "Jo"));
            t2.AddPlayer(new Player(5, 5, 5, 5, "Mama"));
            t2.AddPlayer(new Player(5, 5, 5, 5, "Tata"));
            t2.AddPlayer(new Player(5, 5, 5, 5, "Jo2"));
            t2.AddPlayer(new Player(5, 5, 5, 5, "Ptys"));
            t2.AddPlayer(new Player(5, 5, 5, 5, "Krawczyk"));
            t2.AddPlayer(new Player(5, 5, 5, 5, "Krzystof"));
            t2.AddPlayer(new Player(5, 5, 5, 5, "Szymon"));
            t2.AddPlayer(new Player(5, 5, 5, 5, "Rajmund"));

            t1.AddPlayer(new Player(1, 1, 1, 1, "Marek"));
            t1.AddPlayer(new Player(1, 1, 1, 1, "Krysia"));
            t1.AddPlayer(new Player(1, 1, 1, 1, "Zyzio"));
            t1.AddPlayer(new Player(1, 1, 1, 1, "Danka"));
            t1.AddPlayer(new Player(1, 1, 1, 1, "Klaudia"));
            t1.AddPlayer(new Player(1, 1, 1, 1, "Dzozef"));
            t1.AddPlayer(new Player(1, 1, 1, 1, "Karol"));
            t1.AddPlayer(new Player(1, 1, 1, 1, "Kiszke"));
            t1.AddPlayer(new Player(1, 1, 1, 1, "Kapucz"));
            t1.AddPlayer(new Player(1, 1, 1, 1, "Jo4"));
            t1.AddPlayer(new Player(1, 1, 1, 1, "Ewelina"));

            Game g1 = new Game(t1, t2, new TestLuckFactory(0));
            g1.Run();

            Assert.Equal(t2.TeamName, g1.Winner.TeamName);
            Assert.Equal(t1.TeamName, g1.Losser.TeamName);
        }

        [Fact]
        public void Game_WinFirst_Random_Test()
        {
            //1. Przygotowanie danych
            Team t1 = new Team("t1");
            Team t2 = new Team("t2");

            t2.AddPlayer(new Player(1,1,1,1, "Rysiek"));
            t2.AddPlayer(new Player(1,1,1,1, "Krzysiek"));
            t2.AddPlayer(new Player(1,1,1,1, "Jo"));
            t2.AddPlayer(new Player(1,1,1,1, "Mama"));
            t2.AddPlayer(new Player(1,1,1,1, "Tata"));
            t2.AddPlayer(new Player(1,1,1,1, "Jo2"));
            t2.AddPlayer(new Player(1,1,1,1, "Ptys"));
            t2.AddPlayer(new Player(1,1,1,1, "Krawczyk"));
            t2.AddPlayer(new Player(1,1,1,1, "Krzystof"));
            t2.AddPlayer(new Player(1,1,1,1, "Szymon"));
            t2.AddPlayer(new Player(1,1,1,1, "Rajmund"));

            t1.AddPlayer(new Player(1, 1, 1, 2, "Marek"));
            t1.AddPlayer(new Player(1, 1, 1, 1, "Krysia"));
            t1.AddPlayer(new Player(1, 1, 1, 1, "Zyzio"));
            t1.AddPlayer(new Player(1, 1, 1, 1, "Danka"));
            t1.AddPlayer(new Player(1, 1, 1, 1, "Klaudia"));
            t1.AddPlayer(new Player(1, 1, 1, 1, "Dzozef"));
            t1.AddPlayer(new Player(1, 1, 1, 1, "Karol"));
            t1.AddPlayer(new Player(1, 1, 1, 1, "Kiszke"));
            t1.AddPlayer(new Player(1, 1, 1, 1, "Kapucz"));
            t1.AddPlayer(new Player(1, 1, 1, 1, "Jo4"));
            t1.AddPlayer(new Player(1, 1, 1, 1, "Ewelina"));

            //2. Uruchomienie logiki
            Game g1 = new Game(t1, t2, new TestLuckFactory(0));
            g1.Run();

            //3. Assercje - sprawdzanie 
            Assert.Equal(t1.TeamName, g1.Winner.TeamName);
            Assert.Equal(t2.TeamName, g1.Losser.TeamName);
        }
    }
}
