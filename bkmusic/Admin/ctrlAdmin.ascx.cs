using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ctrlAdmin : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string s = Request["f"];
        switch (s)
        {
            case "baihat":
                plLoad.Controls.Add(LoadControl("BaiHat/cataBaiHat.ascx"));
                break;
            case "casi":
                plLoad.Controls.Add(LoadControl("CaSi/cataCaSi.ascx"));
                break;
            case "dafault":
                break;
        }
    }
}