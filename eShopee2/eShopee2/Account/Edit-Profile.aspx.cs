using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;

namespace eShopee2.Account
{
    public partial class Edit_Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Classes.Auth objAuth = new Classes.Auth();
            objAuth.isLoggedIn();

            if (IsPostBack)
                return;

            Classes.User objUser = new Classes.User();



            try
            {
                SqlDataReader userData = objUser.getUser("email", Session["username"].ToString());
                if (userData != null)
                {
                    userData.Read();
                    litEmail.Text = userData["email"].ToString();
                    txtName.Text = userData["name"].ToString();
                    txtMobile.Text = userData["mobile"].ToString();

                }

            objUser.close();

            Classes.User newuser = new Classes.User();



           // litError.Text = uploadedFile;
          //  string image= newuser.getProfilePic(Session["username"].ToString());
            //Image1.ImageUrl = "ProfileUploads/"+newuser.getProfilePic(Session["username"].ToString());
            Image1.ImageUrl = "http://localhost:49242/ProfileUploads/"+newuser.getProfilePic(Session["username"].ToString());
            txtaddress.Text = newuser.getAddress(Session["username"].ToString());
            newuser.close();
            }
            catch (Exception ex)
            {

            }

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Classes.User objUser = new Classes.User();
            Classes.User newUser = new Classes.User();


            try
            {
                string email = Session["username"].ToString();
                string name = txtName.Text.ToString();
                string mobile = txtMobile.Text.ToString();
                string address = txtaddress.Text.ToString();


                Classes.Validation objValidate = new Classes.Validation();
                bool error = false;
                litError.Text = "";

                if (!objValidate.isValidName(name))
                {
                    error = true;
                    litError.Text = "Invalid Name";
                }

                if (error)
                    return;



                if (objUser.setUser(name, email, mobile) && newUser.setAddress(address,email))
                {
                    litError.Text = "Account Updated Successfully";
                }




            }

            catch (Exception ex)
            {
                litError.Text = "Account Could Not be Updated";
            }

            objUser.close();
            newUser.close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Classes.User picadd = new Classes.User();
            try
            {

                string imageExtension = Path.GetExtension(fileImage.PostedFile.FileName);
                string image = Guid.NewGuid().ToString() + imageExtension;

                string uploadDirectory = Path.Combine(Request.PhysicalApplicationPath, "ProfileUploads");
                string uploadedFile = Path.Combine(uploadDirectory, image);



                fileImage.PostedFile.SaveAs(uploadedFile);

                if (picadd.setprofilePic(Session["username"].ToString(), image))

                    litError.Text = "Profile Picture Updated" + uploadDirectory;
                Response.Redirect("Edit-Profile.aspx");

            }
            catch (Exception ex)
            {
                litError.Text =ex.Message;
            }
            picadd.close();


        }
    }
} B;
