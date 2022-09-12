using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;

namespace Index
{
    public partial class SiteMaster : MasterPage
    {
        public static int ban1 = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            Contact.Refresh(ban1);
        }

        protected void ProdShop_Click(object sender, EventArgs e)
        {
            ban1 = 0;            
        }
    }
}