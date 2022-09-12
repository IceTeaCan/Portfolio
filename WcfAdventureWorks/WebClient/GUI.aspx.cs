using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class GUI : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                WcfServiceReference.IDatosClient dc = new WcfServiceReference.IDatosClient();
                WcfServiceReference.Datos dt = dc.consultarData(tb_ID.Text.Trim());
                if (dt.loginID != null)
                {
                    tb_Login.Text = dt.loginID;
                    tb_JobTitle.Text = dt.jobTitle;
                    tb_BirthDate.Text = dt.birthDate;
                    tb_MaritalStatus.Text = dt.Maritalstatus;
                    tb_Gender.Text = dt.Gender;
                    lbl_Salida.Text = "<>";
                }
                else
                {
                    lbl_Salida.Text = "Este usuario no existe";
                    tb_Login.Text = "";
                    tb_Login.Text = "";
                    tb_JobTitle.Text = "";
                    tb_BirthDate.Text = "";
                    tb_MaritalStatus.Text = "";
                    tb_Gender.Text = "";
                }
            }
            catch(NullReferenceException exe)
            {
                exe.ToString();
            }
        }
    }
}