using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GameOfDrones
{
    public partial class Start : System.Web.UI.Page
    {

        public string Player1Name {
            get
            {
                return Player1TextBox.Text;
            }
        }

        public string Player2Name {
            get
            {
                return Player2TextBox.Text;
            }
        }

    }
}