using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GameOfDrones
{
    public partial class Match : System.Web.UI.Page
    {

        public static int CurrentRound { get; set; }

        public static string CurrentPlayer { get; set; }

        public static string Player1Name { get; set; }

        public static string Player2Name { get; set; }

        public string WinnerName { get; set; }

        public static string Player1Move { get; set; }

        public static string Player2Move { get; set; }

        public static int Player1Victories { get; set; }

        public static int Player2Victories { get; set; }

        public static Dictionary<string, string> RoundWinners { get; set; }

        public Dictionary<string, string> Moves
        {
            get
            {
                Dictionary<string, string> moves = new Dictionary<string, string>();
                moves.Add("Paper", "Rock");
                moves.Add("Rock", "Scissors");
                moves.Add("Scissors", "Paper");
                return moves;
            }
        
        }

        public Match()
        {
            if (RoundWinners == null)
                RoundWinners = new Dictionary<string, string>();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage != null)
            {
                Player1Name = PreviousPage.Player1Name;
                Player2Name = PreviousPage.Player2Name;
                PlayerLabel.Text = Player1Name;
                CurrentRound = 1;
                RoundNumberLabel.Text = CurrentRound.ToString();
                RoundWinners.Clear();
            }
        }

        protected void OkButton_Click(object sender, EventArgs e)
        {
            if (Player1Move == null)
            {
                Player1Move = MovesDropDown.SelectedValue;
                PlayerLabel.Text = Player2Name;
                MovesDropDown.ClearSelection();
                return;
            }

            Player2Move = MovesDropDown.SelectedValue;
            
            if (Player1Move != null && Player2Move != null)
            {
                Console.Out.Write(Player1Move + " / " + Player2Move);
                RoundNumberLabel.Text = CurrentRound.ToString();
                PlayerLabel.Text = Player1Name;
                

                if (Moves[Player1Move].Equals(Player2Move))
                {
                    RoundWinners.Add(CurrentRound.ToString(), Player1Name);
                    Player1Victories++;
                }
                else if (Moves[Player2Move].Equals(Player1Move))
                {
                    RoundWinners.Add(CurrentRound.ToString(), Player2Name);
                    Player2Victories++;
                }
                else
                {
                    RoundWinners.Add(CurrentRound.ToString(), "- no winner -");
                }

                CurrentRound++;
                Player1Move = null;
                Player2Move = null;
                MovesDropDown.ClearSelection();

                GridView1.DataSource = RoundWinners;
                GridView1.DataBind();

                if (Player1Victories == 3)
                {
                    Player1Victories = 0;
                    Player2Victories = 0;
                    WinnerName = Player1Name;
                    Server.Transfer("~/Finish.aspx", true);
                }
            }
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[0].Text = "Round";
                e.Row.Cells[1].Text = "Winner";
            }
        }
    }
}