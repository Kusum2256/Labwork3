using System;

namespace Labwork
{
    public partial class Lab3_q8 : System.Web.UI.Page
    {
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string name = txtName.Text.Trim();
                string email = txtEmail.Text.Trim();
                // In real app, do password hashing & security!
                string password = txtPassword.Text;

                lblMessage.Text = $"Registration Successful! Welcome, {name}.";
            }
        }
    }
}
