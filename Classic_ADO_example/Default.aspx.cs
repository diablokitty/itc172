﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;//added because we need a data table
public partial class _Default : System.Web.UI.Page
{
    DataClass dc = new DataClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        LoadDropDownList();
    }
    protected void LoadDropDownList()
    {
        DataTable tbl = dc.GetServices();
        DropDownList1.DataSource = tbl;
        DropDownList1.DataTextField ="GrantTypeName";
        DropDownList1.DataValueField = "GrantTypeKey";
        DropDownList1.DataBind();
        DropDownList1.Items.Insert(0, "Choose a Service");
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillGrid();
    }

    protected void FillGrid()
    {
        if (!DropDownList1.SelectedValue.Equals("Choose a Service"))
        {
            int key = int.Parse(DropDownList1.SelectedValue.ToString());
            DataTable tbl = dc.GetGrants(key);
            GridView1.DataSource = tbl;
            GridView1.DataBind();
        }
    }


}