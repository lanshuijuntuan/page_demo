using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace page_demo.Page_demos
{
    public partial class testApplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Object hitCountObj= this.Application.Get("hitCounter");
            if (hitCountObj == null)
            {
                this.Application.Add("hitCounter", 1);
            }
            else
            {
                int hitCount = (int)hitCountObj;
                hitCount++;
                this.Application.Set("hitCounter", hitCount);
            }
            this.lbl_hitCounter.Text = this.Application.Get("hitCounter").ToString();

        }
    }
}