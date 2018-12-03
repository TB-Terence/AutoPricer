using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class Homepage : System.Web.UI.Page
{
        protected void Page_Load(object sender, EventArgs e)
        {
        
        }

    protected void goToPages(object sender, EventArgs e)
    {
        switch (Select1.SelectedIndex)
        {
            case 0:
                profilePage();
                break;
        }
    }

    void profilePage()
    {
        if (Session["accountType"] != null) { Response.Redirect("~/UserProfile.aspx"); }
    }

}
