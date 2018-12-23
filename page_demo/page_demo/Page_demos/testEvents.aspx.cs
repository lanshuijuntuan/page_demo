using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace page_demo.Page_demos
{
    public partial class testEvents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.lblMessage.Text += "Page_Load...........<br/>";
            if (this.IsPostBack)
            {
                this.lblMessage.Text += "Page_Load Post Back...........<br/>";
            }
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            this.lblMessage.Text += "Page_Init ...........<br/>";
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            this.lblMessage.Text += "Page_PreRender ...........<br/>";
        }

        protected void Page_Render(object sender, EventArgs e)
        {
            this.lblMessage.Text += "Page_Render ...........<br/>";
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            this.lblMessage.Text += "Page_Unload ...........<br/>";
        }


        protected void btnTestEvent_Click(object sender, EventArgs e)
        {
            this.lblMessage.Text += "btnTestEvent_Click...........<br />";

        }
    }
}