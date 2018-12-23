using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace page_demo.Page_demos
{
    public partial class testSession : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            object sessionCountObj=this.Session.Contents["sessionCount"];
            if (sessionCountObj == null)
            {
                this.Session.Contents.Add("sessionCount", 1);
            }
            else
            {
                int result=0;
                if (int.TryParse(sessionCountObj.ToString(), out result))
                {
                    this.Session.Contents["sessionCount"] = result + 1;
                }
                else
                {
                    this.Session.Contents.Remove("sessionCount");
                    this.Session.Contents.Add("sessionCount", 1);
                }
            }
            this.lbl_sessionCount.Text = this.Session.Contents["sessionCount"].ToString();

        }
    }
}