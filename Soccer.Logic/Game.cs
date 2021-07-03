using System;
using System.Collections.Generic;
using System.Text;


namespace Soccer.Logic
{
    public class Game
    {
        public Game(Team t1, Team t2, ILuckFactory luckFactory)
        {
            T1 = t1;
            T2 = t2;
            this.luckFactory = luckFactory;
        }

        private Team T1 { get; set; }
        private Team T2 { get; set; }
        public Team Winner { get; private set; }
        public Team Losser { get; private set; }

        private readonly ILuckFactory luckFactory;

        public void Run()
        {
            var wynikPierwszejPolowy = PierwszaPolowa();
            var wynikDrugiejPolowy = DrugaPolowa();
            var wynikMeczu = wynikPierwszejPolowy + wynikDrugiejPolowy;
            if (CzyPotrzebnaDogrywka(wynikMeczu))
            {
                var wynikPierwszejDogrywki = PierwszaDogrywka();
                var wynikDrugiejDogrywki = DrugaDogrywka();
                wynikMeczu = wynikPierwszejDogrywki + wynikDrugiejDogrywki;
                if (CzyPotrzebneKarne(wynikMeczu))
                {
                    wynikMeczu = Karne();
                }
            }

            if(wynikMeczu > 0)
            {
                Winner = T1;
                Losser = T2;
            }
            else
            {
                Winner = T2;
                Losser = T1;
            }
        }

        private int Karne()
        {
            int win1 = 0, win2 = 0;
            for (int playerNumber = 0; playerNumber < 5; playerNumber++)
            {

                Player p1 = T1.Players[playerNumber];
                Player p2 = T2.Players[playerNumber];


                if (BetterPlayer(p1, p2))
                {
                    win1++;

                }
                else
                {
                    win2++;
                }
            }


            if (win1 == win2)
                return Karne();
            else if (win1 > win2)
                return win1;
            else
                return win2;
        }

        private int DrugaDogrywka()
        {
            return RunPartGame();
        }

        private int PierwszaDogrywka()
        {
            return RunPartGame();
        }

        private int DrugaPolowa()
        {
            return RunPartGame();
        }

        private int PierwszaPolowa()
        {
            return RunPartGame();
        }

        private int RunPartGame()
        {
            int win1 = 0, win2 = 0;
            for (int playerNumber = 0; playerNumber < 11; playerNumber++)
            {

                Player p1 = T1.Players[playerNumber];
                Player p2 = T2.Players[playerNumber];


                if (BetterPlayer(p1, p2))
                {
                    win1++;

                }
                else
                {
                    win2++;
                }
            }
            return win1 - win2;
        }

        //win1 = 4, win2 =7 return = -3
        //win1 = 4, win2 =4 return = 0
        //win1 = 8, win2 =7 return = 1

        private bool CzyPotrzebneKarne(int wynikMeczu)
        {
            return wynikMeczu == 0;
        }

        private bool CzyPotrzebnaDogrywka(int wynikMeczu)
        {
            return wynikMeczu == 0;
        }

        private bool BetterPlayer(Player p1, Player p2)
        {
            return p1.PlayerPerformance + luckFactory.GetLuck() > p2.PlayerPerformance + luckFactory.GetLuck();
        }        
    }    
}
