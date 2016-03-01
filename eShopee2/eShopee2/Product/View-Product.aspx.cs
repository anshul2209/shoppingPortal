using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace eShopee2.Product
{
    public partial class View_Product : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            int iValue = int.Parse(Request.QueryString["id"]);
            Classes.Product objUser=new Classes.Product();


            litExcerpt.Text = iValue.ToString();
             try
            {
                SqlDataReader userData = objUser.getProduct(" ID ='"+iValue.ToString()+"'");

                if (userData != null)
                {
                    userData.Read();
                    litName.Text = userData["name"].ToString();
                    litExcerpt.Text = userData["excerpt"].ToString();
                    litCost.Text = userData["cost"].ToString();
                   litInStock.Text = userData["instock"].ToString();
                   litDescription.Text = userData["description"].ToString();
                 imgProduct.ImageUrl = "http://localhost:49242/ProductPics/" +userData["image"].ToString();

                }
            }




            catch (Exception ex)
            {

            }

            objUser.close();
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            Classes.User user = new Classes.User();
            if (user.addtocart((Request.QueryString["id"]).ToString(), litName.Text.ToString(), litCost.Text.ToString()))
            {
                Response.Write("ADDED");
            }
            //Response.Redirect("Cart.aspx");
        }

        }
    }
 bC
