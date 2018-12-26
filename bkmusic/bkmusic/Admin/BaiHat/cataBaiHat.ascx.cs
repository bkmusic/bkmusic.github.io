using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bkmusic.dal;

public partial class Admin_BaiHat_cataBaiHat : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        BaiHat _baihat = new BaiHat();

        if(!IsPostBack)
        {
            LoadData();
        }
        void LoadData()
        {
            rptcataBaiHat.DataSource = _baihat.GetList();
            rptcataBaiHat.DataBind();
        }
    }

    //protected void LinkButton1_Click(object sender, EventArgs e)
    //{
    //    mul.ActiveViewIndex = 1;
    //}

}