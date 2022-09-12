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
                WcfServiceReference.Datos dt = dc.ConsultarData(tb_ID.Text.Trim());
                if (dt.LoginID != null)
                {
                    tb_Login.Text = dt.LoginID;
                    tb_JobTitle.Text = dt.JobTitle;
                    tb_BirthDate.Text = dt.BirthDate;
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