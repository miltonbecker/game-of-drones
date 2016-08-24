using GameOfDrones.ViewModel;
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

        private Game game;
        public string WinnerName { get; set; }

        public Match()
        {
            game = Game.GetInstance();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage != null)
            {
                game.StartGame(PreviousPage.Player1Name, PreviousPage.Player2Name);

                RefreshData();
            }
        }

        protected void OkButton_Click(object sender, EventArgs e)
        {
            game.PlayRound(MovesDropDown.SelectedValue);

            RefreshData();

            DoWeHaveAWinner();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[0].Text = "Round";
                e.Row.Cells[1].Text = "Winner";
            }
        }

        private void RefreshData()
        {
            PlayerLabel.Text = game.CurrentPlayer.Name;
            RoundNumberLabel.Text = game.CurrentRound.ToString();
            MovesDropDown.ClearSelection();
            GridView1.DataSource = game.Score;
            GridView1.DataBind();
        }

        private void DoWeHaveAWinner()
        {
            if (game.Winner != null)
            {
                WinnerName = game.Winner.Name;
                Server.Transfer("~/View/Finish.aspx");
            }
        }
    }
}