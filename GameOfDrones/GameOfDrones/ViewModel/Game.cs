using GameOfDrones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameOfDrones.ViewModel
{
    public class Game
    {

        private static Game instance;

        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public Dictionary<string, string> Moves { get; set; }

        public int CurrentRound { get; set; }
        public int CurrentTurn { get; set; }
        public Dictionary<string, string> Score { get; set; }
        public Player Winner { get; set; }
        public Player CurrentPlayer { get; set; }


        private Game() { }

        public static Game GetInstance()
        {
            if (instance == null)
                instance = new Game();
            return instance;
        }

        public void StartGame(string player1Name, string player2Name)
        {
            Player1 = new Player();
            Player1.Name = player1Name;

            Player2 = new Player();
            Player2.Name = player2Name;

            ResetGameStats();
        }

        public void PlayRound(string move)
        {
            CurrentPlayer.RoundMove = move;

            switch (CurrentTurn)
            {
                case 1:
                    CurrentTurn = 2;
                    CurrentPlayer = Player2;
                    break;
                case 2:
                    CurrentTurn = 1;
                    CurrentPlayer = Player1;
                    ProcessWhoWonTheRound();
                    CurrentRound++;
                    break;
                default:
                    break;
            }

            ProcessIfWeHaveAWinner();
        }

        private void ResetGameStats()
        {
            CurrentRound = 1;
            CurrentTurn = 1;
            Score = new Dictionary<string, string>();
            Winner = null;
            CurrentPlayer = Player1;
            Moves = Rules.GetAllowedMoves();
        }

        private void ProcessWhoWonTheRound()
        {
            if (Player1.RoundMove == null || Player2.RoundMove == null)
                return;

            if (Moves[Player1.RoundMove].Equals(Player2.RoundMove))
            {
                Score.Add(CurrentRound.ToString(), Player1.Name);
                Player1.RoundsWon++;
            }
            else if (Moves[Player2.RoundMove].Equals(Player1.RoundMove))
            {
                Score.Add(CurrentRound.ToString(), Player2.Name);
                Player2.RoundsWon++;
            }
            else
            {
                Score.Add(CurrentRound.ToString(), "*no winner*");
            }

            ResetPlayersRoundMoves();
        }

        private void ResetPlayersRoundMoves()
        {
            Player1.RoundMove = null;
            Player2.RoundMove = null;
        }

        private void ProcessIfWeHaveAWinner()
        {
            if (Player1.RoundsWon == 3)
            {
                Winner = Player1;
            }
            if (Player2.RoundsWon == 3)
            {
                Winner = Player2;
            }
        }

    }
}