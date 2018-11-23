using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Listing_Description : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_submit_Click(object sender, EventArgs e)
    {
       
    }

    public class Carinfo
    {
        public string CarModel { get; set; }
        public string CarMake { get; set; }
        public string Engine { get; set; }
        public int Milage { get; set; }
    }
}
    