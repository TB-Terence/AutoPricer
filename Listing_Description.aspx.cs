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
        try
        {
            string CarModel = Txt_Model.Text;
            string CarMake = Txt_Make.Text;
            string Engine = Txt_Engine.Text;
            string Condition = Txt_Condition.Text;
            int Milage = Convert.ToInt32(Txt_Milage.Text);


        }
        catch
        {

        }
    }

    public class Carinfo
    {
        public string CarModel { get; set; }
        public string CarMake { get; set; }
        public string Engine { get; set; }
        public int Milage { get; set; }
        public string Condition { get; set; }

        public Carinfo(string carmodel, string carmake, string engine, int milage, string condition)
        {

        }
    }
}
    