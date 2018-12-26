using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using bkmusic.dal;

public partial class Admin_CaSi_cataCaSi : System.Web.UI.UserControl
{
    CaSi _casi = new CaSi();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadData();
        }
        void LoadData()
        {
            rptcataCaSi.DataSource = _casi.GetList();
            rptcataCaSi.DataBind();
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (fuHinhAnh.HasFile)
        {
            string filename = fuHinhAnh.FileName;
            fuHinhAnh.SaveAs(Server.MapPath("\\Content\\IMAGE\\") + filename);
        }
        if (hdInsert.Value == "Insert")
        {
            if (!string.IsNullOrEmpty(tbTenCaSi.Text.Trim()))
            {
                _casi.Insert(tbTenCaSi.Text.ToString(), ddlGioiTinh.SelectedValue.Trim(), tbNgaySinh.Text.ToString(), tbMoTa.Text.ToString(), fuHinhAnh.FileName.ToString());
                Response.Redirect(Request.Url.ToString());
            }
        }
        else
        {
            if (!string.IsNullOrEmpty(tbTenCaSi.Text.Trim()))
            {
                _casi.Update(int.Parse(hdCaSiID.Value), tbTenCaSi.Text.ToString(), ddlGioiTinh.SelectedValue.Trim(), tbNgaySinh.Text.ToString(), tbMoTa.Text.ToString(), fuHinhAnh.FileName.ToString());
                Response.Redirect(Request.Url.ToString());
            }
        }
    }

    protected void LinkAdd_Click(object sender, EventArgs e)
    {
        hdInsert.Value = "Insert";
        mul.ActiveViewIndex = 1;
    }

    protected void rptcataCaSi_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        DataTable dt = new DataTable();
        switch (e.CommandName.ToString())
        {
            case "Delete":
                _casi.Delete(int.Parse(e.CommandArgument.ToString()));
                Response.Redirect(Request.Url.ToString());
            break;
            case "Update":
                dt = _casi.GetListbyMaCaSi(int.Parse(e.CommandArgument.ToString()));
                if (dt.Rows.Count > 0)
                {
                    tbTenCaSi.Text = dt.Rows[0]["TenCaSi"].ToString();
                    ddlGioiTinh.SelectedValue = dt.Rows[0]["GioiTinh"].ToString();
                    tbMoTa.Text = dt.Rows[0]["MoTa"].ToString();
                    tbNgaySinh.Text = dt.Rows[0]["NgaySinh"].ToString();
                    hdCaSiID.Value = e.CommandArgument.ToString();
                    hdInsert.Value = "Update";
                    mul.ActiveViewIndex = 1;
                }
                break;
        }
    }
}