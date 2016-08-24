﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GameOfDrones
{
    public partial class Finish : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage != null)
            {
                WinnerNameLabel.Text = PreviousPage.WinnerName;
            }
        }

        protected void PlayAgainButton_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/View/Start.aspx");
        }
    }
}