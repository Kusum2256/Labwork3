using System;

namespace Labwork
{
    public partial class Lab3_q7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double principal = Convert.ToDouble(txtPrincipal.Text);
                double time = Convert.ToDouble(txtTime.Text);
                double rate = Convert.ToDouble(txtRate.Text);

                double si = (principal * time * rate) / 100;
                lblResult.Text = "Simple Interest: " + si.ToString("F2");
            }
            catch (FormatException)
            {
                lblResult.Text = "Please enter valid numbers!";
            }
        }
    }
}
