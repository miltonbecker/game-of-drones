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
        public Player Winner { get; set; }
        public int CurrentRound { get; set; }
        public Dictionary<string, string> Moves { get; set; }
        public Dictionary<string, string> Score { get; set; }

        private Game() { }

        public Game GetInstance()
        {
            if (instance == null)
                instance = new Game();
            return instance;
        }

    }
}