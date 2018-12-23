using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace page_demo.Page_demos
{
    /*
     * Page对象的事件
     * 1、事件顺序Page_Init Page_Load Page_PreRender Page_UnLoad。
     * 2、事件无需订阅，系统自动订阅，不知道内部机制。
     * 3、事件处理函数不区分大小写,估计是通过反射调用的，例如Page_Init可以写成page_init、page_Init、Page_init.
     * 4、可以通过断点查看调用层次。
     * 
     * 
     * */
    public partial class testAspPage : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("page Load......... ");
        }

        protected void Application_Start(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Applcation Start..............");
        }

        protected void Application_End(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Applcation End..............");
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Session Start..............");
        }

        protected void Session_End(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Session End..............");
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Page_Init..............");
        }

       

        //protected void Page_init(object sender, EventArgs e)
        //{
        //    System.Diagnostics.Debug.WriteLine("小写 Page_init..............");
        //}

        //protected void page_init(object sender, EventArgs e)
        //{
        //    System.Diagnostics.Debug.WriteLine("小写 page_init..............");
        //}

        //protected void page_Init(object sender, EventArgs e)
        //{
        //    System.Diagnostics.Debug.WriteLine("小写 page_Init..............");
        //}

        protected void Page_Unload(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Page_Unload..............");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Page_PreRender..............");
        }

        protected void Page_Render(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Page_Render..............");
        }

        protected void Page_Disposed(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Page_Disposed..............");
        }

        protected void Page_DataBinding(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Page_DataBinding..............");
        }

        protected void Page_Error(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Page_Error..............");
        }


        protected void page_Error(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("小写 Page_Error..............");
        }
    
    }
}