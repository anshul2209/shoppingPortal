using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace eShopee2.Account
{
    public partial class View_All_Users : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        static string email;
        protected void grid_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        protected void edit(object source, DataGridCommandEventArgs e)
        {
            string email = e.Item.Cells[5].Text.ToString();
            grid.EditItemIndex = e.Item.ItemIndex;
            grid.DataBind();
        }

        protected void cancel(object source, DataGridCommandEventArgs e)
        {
            grid.EditItemIndex = -1;
            grid.DataBind();

        }

        protected void grid_UpdateCommand(object source, DataGridCommandEventArgs e)
        {
            Classes.Database data = new Classes.Database();
            TextBox t1, t2, t3, t4,t5;
            t1 = (TextBox)e.Item.Cells[1].Controls[0];
            t2 = (TextBox)e.Item.Cells[2].Controls[0];
            t3 = (TextBox)e.Item.Cells[3].Controls[0];
            t4 = (TextBox)e.Item.Cells[4].Controls[0];
            t5 = (TextBox)e.Item.Cells[5].Controls[0];
            int effectedRows = data.setData("update users set name='" + t1.Text + "', mobile='" + t2.Text + "', role='" + t3.Text + "', status='" + t4.Text + "' where email='" + email + "'");
            //if (effectedRows == 1)



        }
    }
}   
