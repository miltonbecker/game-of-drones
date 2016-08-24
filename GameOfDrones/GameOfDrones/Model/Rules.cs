using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameOfDrones.Models
{
    public class Rules
    {

        private static Rules instance;
        private Dictionary<string, string> allowedMoves;

        private Rules() { }

        public static Rules GetInstance()
        {
            if (instance == null)
                instance = new Rules();
            return instance;
        }

        public static Dictionary<string, string> GetAllowedMoves()
        {
            return GetInstance().AllowedMoves;
        }

        private Dictionary<string, string> AllowedMoves {
            get
            {
                if (allowedMoves == null)
                {
                    allowedMoves = new Dictionary<string, string>();
                    allowedMoves.Add("Paper", "Rock");
                    allowedMoves.Add("Rock", "Scissors");
                    allowedMoves.Add("Scissors", "Paper");
                }
                return allowedMoves;
            }
            set
            {
                allowedMoves = value;
            }
        }


    }
}