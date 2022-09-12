using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Index
{
    public partial class About : Page
    {

        //varibles de valores necesarios 
        private static int val1 = 0, val2 = 0, val3 = 0, val4 = 0, val5 = 0, val6 = 0;
        private static int ind1 = 0, ind2 = 0, ind3 = 0, ind4 = 0, ind5 = 0, ind6 = 0;
        public static int ban1 = 1, ban = 0;
        ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Contact.idPedido = 1;
            //Loging.idCarrito = 1;
            
            decimal suma = 0;
            if(ban == 0)
            {
                foreach (var value in proxy.ObtenerPedido(Contact.idPedido, Loging.idCarrito))//recorrido de consulta
                {
                    switch (ban)//variable bandera utilizada colocar cada producto en un espacio designado de la pantalla 
                    {
                        case 0:
                            switch (value.IdProducto)
                            {
                                case 1:
                                    val1 = 1;
                                    img_btn_Prod1.ImageUrl = "/Content/Chalupa.jpg";
                                    img_btn_Prod1.Visible = true;
                                    btn_Mod1.Visible = true;
                                    dl_Prod1.Visible = true;
                                    lbl_Head1.Visible = true;
                                    
                                    suma += value.CostoTotal;
                                    switch (value.Cantidad)
                                    {
                                        case 1:
                                            dl_Prod1.Items.Insert(1, "1");
                                            break;
                                        case 2:
                                            dl_Prod1.Items.Insert(1, "1"); dl_Prod1.Items.Insert(2, "2");
                                            break;
                                        case 3:
                                            dl_Prod1.Items.Insert(1, "1"); dl_Prod1.Items.Insert(2, "2"); dl_Prod1.Items.Insert(3, "3");
                                            break;
                                        case 4:
                                            dl_Prod1.Items.Insert(1, "1"); dl_Prod1.Items.Insert(2, "2"); dl_Prod1.Items.Insert(3, "3"); dl_Prod1.Items.Insert(4, "4");
                                            break;
                                        case 5:
                                            dl_Prod1.Items.Insert(1, "1"); dl_Prod1.Items.Insert(2, "2"); dl_Prod1.Items.Insert(3, "3"); dl_Prod1.Items.Insert(4, "4"); dl_Prod1.Items.Insert(5, "5");
                                            break;
                                        case 6:
                                            dl_Prod1.Items.Insert(1, "1"); dl_Prod1.Items.Insert(2, "2"); dl_Prod1.Items.Insert(3, "3"); dl_Prod1.Items.Insert(4, "4"); dl_Prod1.Items.Insert(5, "5"); dl_Prod1.Items.Insert(6, "6");
                                            break;
                                    }
                                    ++ban;
                                    break;
                                case 2:
                                    val1 = 2;
                                    img_btn_Prod1.ImageUrl = "/Content/TacoPapa.jpg";
                                    img_btn_Prod1.Visible = true;
                                    btn_Mod1.Visible = true;
                                    lbl_Head1.Visible = true;
                                    dl_Prod1.Visible = true;
                                    
                                    suma += value.CostoTotal;
                                    switch (value.Cantidad)
                                    {
                                        case 1:
                                            dl_Prod1.Items.Insert(1, "1");
                                            break;
                                        case 2:
                                            dl_Prod1.Items.Insert(1, "1"); dl_Prod1.Items.Insert(2, "2");
                                            break;
                                        case 3:
                                            dl_Prod1.Items.Insert(1, "1"); dl_Prod1.Items.Insert(2, "2"); dl_Prod1.Items.Insert(3, "3");
                                            break;
                                        case 4:
                                            dl_Prod1.Items.Insert(1, "1"); dl_Prod1.Items.Insert(2, "2"); dl_Prod1.Items.Insert(3, "3"); dl_Prod1.Items.Insert(4, "4");
                                            break;
                                        case 5:
                                            dl_Prod1.Items.Insert(1, "1"); dl_Prod1.Items.Insert(2, "2"); dl_Prod1.Items.Insert(3, "3"); dl_Prod1.Items.Insert(4, "4"); dl_Prod1.Items.Insert(5, "5");
                                            break;
                                        case 6:
                                            dl_Prod1.Items.Insert(1, "1"); dl_Prod1.Items.Insert(2, "2"); dl_Prod1.Items.Insert(3, "3"); dl_Prod1.Items.Insert(4, "4"); dl_Prod1.Items.Insert(5, "5"); dl_Prod1.Items.Insert(6, "6");
                                            break;
                                    }
                                    ++ban;
                                    break;
                                case 3:
                                    val1 = 3;
                                    img_btn_Prod1.ImageUrl = "/Content/Wings.jpg";
                                    img_btn_Prod1.Visible = true;
                                    btn_Mod1.Visible = true;
                                    dl_Prod1.Visible = true;
                                    lbl_Head1.Visible = true;
                                    
                                    suma += value.CostoTotal;
                                    switch (value.Cantidad)
                                    {
                                        case 1:
                                            dl_Prod1.Items.Insert(1, "1");
                                            break;
                                        case 2:
                                            dl_Prod1.Items.Insert(1, "1"); dl_Prod1.Items.Insert(2, "2");
                                            break;
                                        case 3:
                                            dl_Prod1.Items.Insert(1, "1"); dl_Prod1.Items.Insert(2, "2"); dl_Prod1.Items.Insert(3, "3");
                                            break;
                                        case 4:
                                            dl_Prod1.Items.Insert(1, "1"); dl_Prod1.Items.Insert(2, "2"); dl_Prod1.Items.Insert(3, "3"); dl_Prod1.Items.Insert(4, "4");
                                            break;
                                        case 5:
                                            dl_Prod1.Items.Insert(1, "1"); dl_Prod1.Items.Insert(2, "2"); dl_Prod1.Items.Insert(3, "3"); dl_Prod1.Items.Insert(4, "4"); dl_Prod1.Items.Insert(5, "5");
                                            break;
                                        case 6:
                                            dl_Prod1.Items.Insert(1, "1"); dl_Prod1.Items.Insert(2, "2"); dl_Prod1.Items.Insert(3, "3"); dl_Prod1.Items.Insert(4, "4"); dl_Prod1.Items.Insert(5, "5"); dl_Prod1.Items.Insert(6, "6");
                                            break;
                                    }
                                    ++ban;
                                    break;
                                case 4:
                                    val1 = 4;
                                    img_btn_Prod1.ImageUrl = "/Content/Lapiz.jpg";
                                    img_btn_Prod1.Visible = true;
                                    btn_Mod1.Visible = true;
                                    dl_Prod1.Visible = true;
                                    lbl_Head1.Visible = true;
                                    
                                    suma += value.CostoTotal;
                                    switch (value.Cantidad)
                                    {
                                        case 1:
                                            dl_Prod1.Items.Insert(1, "1");
                                            break;
                                        case 2:
                                            dl_Prod1.Items.Insert(1, "1"); dl_Prod1.Items.Insert(2, "2");
                                            break;
                                        case 3:
                                            dl_Prod1.Items.Insert(1, "1"); dl_Prod1.Items.Insert(2, "2"); dl_Prod1.Items.Insert(3, "3");
                                            break;
                                        case 4:
                                            dl_Prod1.Items.Insert(1, "1"); dl_Prod1.Items.Insert(2, "2"); dl_Prod1.Items.Insert(3, "3"); dl_Prod1.Items.Insert(4, "4");
                                            break;
                                        case 5:
                                            dl_Prod1.Items.Insert(1, "1"); dl_Prod1.Items.Insert(2, "2"); dl_Prod1.Items.Insert(3, "3"); dl_Prod1.Items.Insert(4, "4"); dl_Prod1.Items.Insert(5, "5");
                                            break;
                                        case 6:
                                            dl_Prod1.Items.Insert(1, "1"); dl_Prod1.Items.Insert(2, "2"); dl_Prod1.Items.Insert(3, "3"); dl_Prod1.Items.Insert(4, "4"); dl_Prod1.Items.Insert(5, "5"); dl_Prod1.Items.Insert(6, "6");
                                            break;
                                    }
                                    ++ban;
                                    break;
                                case 5:
                                    val1 = 5;
                                    img_btn_Prod1.ImageUrl = "/Content/Hamburguesa.jpg";
                                    img_btn_Prod1.Visible = true;
                                    btn_Mod1.Visible = true;
                                    dl_Prod1.Visible = true;
                                    lbl_Head1.Visible = true;
                                    
                                    suma += value.CostoTotal;
                                    switch (value.Cantidad)
                                    {
                                        case 1:
                                            dl_Prod1.Items.Insert(1, "1");
                                            break;
                                        case 2:
                                            dl_Prod1.Items.Insert(1, "1"); dl_Prod1.Items.Insert(2, "2");
                                            break;
                                        case 3:
                                            dl_Prod1.Items.Insert(1, "1"); dl_Prod1.Items.Insert(2, "2"); dl_Prod1.Items.Insert(3, "3");
                                            break;
                                        case 4:
                                            dl_Prod1.Items.Insert(1, "1"); dl_Prod1.Items.Insert(2, "2"); dl_Prod1.Items.Insert(3, "3"); dl_Prod1.Items.Insert(4, "4");
                                            break;
                                        case 5:
                                            dl_Prod1.Items.Insert(1, "1"); dl_Prod1.Items.Insert(2, "2"); dl_Prod1.Items.Insert(3, "3"); dl_Prod1.Items.Insert(4, "4"); dl_Prod1.Items.Insert(5, "5");
                                            break;
                                        case 6:
                                            dl_Prod1.Items.Insert(1, "1"); dl_Prod1.Items.Insert(2, "2"); dl_Prod1.Items.Insert(3, "3"); dl_Prod1.Items.Insert(4, "4"); dl_Prod1.Items.Insert(5, "5"); dl_Prod1.Items.Insert(6, "6");
                                            break;
                                    }
                                    ++ban;
                                    break;
                                case 6:
                                    val1 = 6;
                                    img_btn_Prod1.ImageUrl = "/Content/Doradita.jpg";
                                    img_btn_Prod1.Visible = true;
                                    btn_Mod1.Visible = true;
                                    dl_Prod1.Visible = true;
                                    lbl_Head1.Visible = true;
                                    suma += value.CostoTotal;
                                    
                                    switch (value.Cantidad)
                                    {
                                        case 1:
                                            dl_Prod1.Items.Insert(1, "1");
                                            break;
                                        case 2:
                                            dl_Prod1.Items.Insert(1, "1"); dl_Prod1.Items.Insert(2, "2");
                                            break;
                                        case 3:
                                            dl_Prod1.Items.Insert(1, "1"); dl_Prod1.Items.Insert(2, "2"); dl_Prod1.Items.Insert(3, "3");
                                            break;
                                        case 4:
                                            dl_Prod1.Items.Insert(1, "1"); dl_Prod1.Items.Insert(2, "2"); dl_Prod1.Items.Insert(3, "3"); dl_Prod1.Items.Insert(4, "4");
                                            break;
                                        case 5:
                                            dl_Prod1.Items.Insert(1, "1"); dl_Prod1.Items.Insert(2, "2"); dl_Prod1.Items.Insert(3, "3"); dl_Prod1.Items.Insert(4, "4"); dl_Prod1.Items.Insert(5, "5");
                                            break;
                                        case 6:
                                            dl_Prod1.Items.Insert(1, "1"); dl_Prod1.Items.Insert(2, "2"); dl_Prod1.Items.Insert(3, "3"); dl_Prod1.Items.Insert(4, "4"); dl_Prod1.Items.Insert(5, "5"); dl_Prod1.Items.Insert(6, "6");
                                            break;
                                    }
                                    ++ban;
                                    break;

                            }
                            break;
                        case 1:
                            switch (value.IdProducto)
                            {
                                case 1:
                                    val2 = 1;
                                    img_btn_Prod2.ImageUrl = "/Content/Chalupa.jpg";
                                    img_btn_Prod2.Visible = true;
                                    btn_Mod2.Visible = true;
                                    dl_Prod2.Visible = true;
                                    lbl_Head2.Visible = true;
                                    
                                    suma += value.CostoTotal;
                                    switch (value.Cantidad)
                                    {
                                        case 1:
                                            dl_Prod2.Items.Insert(1, "1");
                                            break;
                                        case 2:
                                            dl_Prod2.Items.Insert(1, "1"); dl_Prod2.Items.Insert(2, "2");
                                            break;
                                        case 3:
                                            dl_Prod2.Items.Insert(1, "1"); dl_Prod2.Items.Insert(2, "2"); dl_Prod2.Items.Insert(3, "3");
                                            break;
                                        case 4:
                                            dl_Prod2.Items.Insert(1, "1"); dl_Prod2.Items.Insert(2, "2"); dl_Prod2.Items.Insert(3, "3"); dl_Prod2.Items.Insert(4, "4");
                                            break;
                                        case 5:
                                            dl_Prod2.Items.Insert(1, "1"); dl_Prod2.Items.Insert(2, "2"); dl_Prod2.Items.Insert(3, "3"); dl_Prod2.Items.Insert(4, "4"); dl_Prod2.Items.Insert(5, "5");
                                            break;
                                        case 6:
                                            dl_Prod2.Items.Insert(1, "1"); dl_Prod2.Items.Insert(2, "2"); dl_Prod2.Items.Insert(3, "3"); dl_Prod2.Items.Insert(4, "4"); dl_Prod2.Items.Insert(5, "5"); dl_Prod2.Items.Insert(6, "6");
                                            break;
                                    }
                                    ++ban;
                                    break;
                                case 2:
                                    val2 = 2;
                                    img_btn_Prod2.ImageUrl = "/Content/TacoPapa.jpg";
                                    img_btn_Prod2.Visible = true;
                                    btn_Mod2.Visible = true;
                                    dl_Prod2.Visible = true;
                                    lbl_Head2.Visible = true;
                                    
                                    suma += value.CostoTotal;
                                    switch (value.Cantidad)
                                    {
                                        case 1:
                                            dl_Prod2.Items.Insert(1, "1");
                                            break;
                                        case 2:
                                            dl_Prod2.Items.Insert(1, "1"); dl_Prod2.Items.Insert(2, "2");
                                            break;
                                        case 3:
                                            dl_Prod2.Items.Insert(1, "1"); dl_Prod2.Items.Insert(2, "2"); dl_Prod2.Items.Insert(3, "3");
                                            break;
                                        case 4:
                                            dl_Prod2.Items.Insert(1, "1"); dl_Prod2.Items.Insert(2, "2"); dl_Prod2.Items.Insert(3, "3"); dl_Prod2.Items.Insert(4, "4");
                                            break;
                                        case 5:
                                            dl_Prod2.Items.Insert(1, "1"); dl_Prod2.Items.Insert(2, "2"); dl_Prod2.Items.Insert(3, "3"); dl_Prod2.Items.Insert(4, "4"); dl_Prod2.Items.Insert(5, "5");
                                            break;
                                        case 6:
                                            dl_Prod2.Items.Insert(1, "1"); dl_Prod2.Items.Insert(2, "2"); dl_Prod2.Items.Insert(3, "3"); dl_Prod2.Items.Insert(4, "4"); dl_Prod2.Items.Insert(5, "5"); dl_Prod2.Items.Insert(6, "6");
                                            break;
                                    }
                                    ++ban;
                                    break;
                                case 3:
                                    val2 = 3;
                                    img_btn_Prod2.ImageUrl = "/Content/Wings.jpg";
                                    img_btn_Prod2.Visible = true;
                                    btn_Mod2.Visible = true;
                                    dl_Prod2.Visible = true;
                                    lbl_Head2.Visible = true;
                                    
                                    suma += value.CostoTotal;
                                    switch (value.Cantidad)
                                    {
                                        case 1:
                                            dl_Prod2.Items.Insert(1, "1");
                                            break;
                                        case 2:
                                            dl_Prod2.Items.Insert(1, "1"); dl_Prod2.Items.Insert(2, "2");
                                            break;
                                        case 3:
                                            dl_Prod2.Items.Insert(1, "1"); dl_Prod2.Items.Insert(2, "2"); dl_Prod2.Items.Insert(3, "3");
                                            break;
                                        case 4:
                                            dl_Prod2.Items.Insert(1, "1"); dl_Prod2.Items.Insert(2, "2"); dl_Prod2.Items.Insert(3, "3"); dl_Prod2.Items.Insert(4, "4");
                                            break;
                                        case 5:
                                            dl_Prod2.Items.Insert(1, "1"); dl_Prod2.Items.Insert(2, "2"); dl_Prod2.Items.Insert(3, "3"); dl_Prod2.Items.Insert(4, "4"); dl_Prod2.Items.Insert(5, "5");
                                            break;
                                        case 6:
                                            dl_Prod2.Items.Insert(1, "1"); dl_Prod2.Items.Insert(2, "2"); dl_Prod2.Items.Insert(3, "3"); dl_Prod2.Items.Insert(4, "4"); dl_Prod2.Items.Insert(5, "5"); dl_Prod2.Items.Insert(6, "6");
                                            break;
                                    }
                                    ++ban;
                                    break;
                                case 4:
                                    val2 = 4;
                                    img_btn_Prod2.ImageUrl = "/Content/Lapiz.jpg";
                                    img_btn_Prod2.Visible = true;
                                    btn_Mod2.Visible = true;
                                    dl_Prod2.Visible = true;
                                    lbl_Head2.Visible = true;
                                    
                                    suma += value.CostoTotal;
                                    switch (value.Cantidad)
                                    {
                                        case 1:
                                            dl_Prod2.Items.Insert(1, "1");
                                            break;
                                        case 2:
                                            dl_Prod2.Items.Insert(1, "1"); dl_Prod2.Items.Insert(2, "2");
                                            break;
                                        case 3:
                                            dl_Prod2.Items.Insert(1, "1"); dl_Prod2.Items.Insert(2, "2"); dl_Prod2.Items.Insert(3, "3");
                                            break;
                                        case 4:
                                            dl_Prod2.Items.Insert(1, "1"); dl_Prod2.Items.Insert(2, "2"); dl_Prod2.Items.Insert(3, "3"); dl_Prod2.Items.Insert(4, "4");
                                            break;
                                        case 5:
                                            dl_Prod2.Items.Insert(1, "1"); dl_Prod2.Items.Insert(2, "2"); dl_Prod2.Items.Insert(3, "3"); dl_Prod2.Items.Insert(4, "4"); dl_Prod2.Items.Insert(5, "5");
                                            break;
                                        case 6:
                                            dl_Prod2.Items.Insert(1, "1"); dl_Prod2.Items.Insert(2, "2"); dl_Prod2.Items.Insert(3, "3"); dl_Prod2.Items.Insert(4, "4"); dl_Prod2.Items.Insert(5, "5"); dl_Prod2.Items.Insert(6, "6");
                                            break;
                                    }
                                    ++ban;
                                    break;
                                case 5:
                                    val2 = 5;
                                    img_btn_Prod2.ImageUrl = "/Content/Hamburguesa.jpg";
                                    img_btn_Prod2.Visible = true;
                                    btn_Mod2.Visible = true;
                                    lbl_Head2.Visible = true;
                                    dl_Prod2.Visible = true;
                                    
                                    suma += value.CostoTotal;
                                    switch (value.Cantidad)
                                    {
                                        case 1:
                                            dl_Prod2.Items.Insert(1, "1");
                                            break;
                                        case 2:
                                            dl_Prod2.Items.Insert(1, "1"); dl_Prod2.Items.Insert(2, "2");
                                            break;
                                        case 3:
                                            dl_Prod2.Items.Insert(1, "1"); dl_Prod2.Items.Insert(2, "2"); dl_Prod2.Items.Insert(3, "3");
                                            break;
                                        case 4:
                                            dl_Prod2.Items.Insert(1, "1"); dl_Prod2.Items.Insert(2, "2"); dl_Prod2.Items.Insert(3, "3"); dl_Prod2.Items.Insert(4, "4");
                                            break;
                                        case 5:
                                            dl_Prod2.Items.Insert(1, "1"); dl_Prod2.Items.Insert(2, "2"); dl_Prod2.Items.Insert(3, "3"); dl_Prod2.Items.Insert(4, "4"); dl_Prod2.Items.Insert(5, "5");
                                            break;
                                        case 6:
                                            dl_Prod2.Items.Insert(1, "1"); dl_Prod2.Items.Insert(2, "2"); dl_Prod2.Items.Insert(3, "3"); dl_Prod2.Items.Insert(4, "4"); dl_Prod2.Items.Insert(5, "5"); dl_Prod2.Items.Insert(6, "6");
                                            break;
                                    }
                                    ++ban;
                                    break;
                                case 6:
                                    val2 = 6;
                                    img_btn_Prod2.ImageUrl = "/Content/Doradita.jpg";
                                    img_btn_Prod2.Visible = true;
                                    btn_Mod2.Visible = true;
                                    lbl_Head2.Visible = true;
                                    dl_Prod2.Visible = true;
                                    
                                    suma += value.CostoTotal;
                                    switch (value.Cantidad)
                                    {
                                        case 1:
                                            dl_Prod2.Items.Insert(1, "1");
                                            break;
                                        case 2:
                                            dl_Prod2.Items.Insert(1, "1"); dl_Prod2.Items.Insert(2, "2");
                                            break;
                                        case 3:
                                            dl_Prod2.Items.Insert(1, "1"); dl_Prod2.Items.Insert(2, "2"); dl_Prod2.Items.Insert(3, "3");
                                            break;
                                        case 4:
                                            dl_Prod2.Items.Insert(1, "1"); dl_Prod2.Items.Insert(2, "2"); dl_Prod2.Items.Insert(3, "3"); dl_Prod2.Items.Insert(4, "4");
                                            break;
                                        case 5:
                                            dl_Prod2.Items.Insert(1, "1"); dl_Prod2.Items.Insert(2, "2"); dl_Prod2.Items.Insert(3, "3"); dl_Prod2.Items.Insert(4, "4"); dl_Prod2.Items.Insert(5, "5");
                                            break;
                                        case 6:
                                            dl_Prod2.Items.Insert(1, "1"); dl_Prod2.Items.Insert(2, "2"); dl_Prod2.Items.Insert(3, "3"); dl_Prod2.Items.Insert(4, "4"); dl_Prod2.Items.Insert(5, "5"); dl_Prod2.Items.Insert(6, "6");
                                            break;
                                    }
                                    ++ban;
                                    break;

                            }
                            break;
                        case 2:
                            switch (value.IdProducto)
                            {
                                case 1:
                                    val3 = 1;
                                    img_btn_Prod3.ImageUrl = "/Content/Chalupa.jpg";
                                    img_btn_Prod3.Visible = true;
                                    btn_Mod3.Visible = true;
                                    dl_Prod3.Visible = true;
                                    lbl_Head3.Visible = true;
                                   
                                    suma += value.CostoTotal;
                                    switch (value.Cantidad)
                                    {
                                        case 1:
                                            dl_Prod3.Items.Insert(1, "1");
                                            break;
                                        case 2:
                                            dl_Prod3.Items.Insert(1, "1"); dl_Prod3.Items.Insert(2, "2");
                                            break;
                                        case 3:
                                            dl_Prod3.Items.Insert(1, "1"); dl_Prod3.Items.Insert(2, "2"); dl_Prod3.Items.Insert(3, "3");
                                            break;
                                        case 4:
                                            dl_Prod3.Items.Insert(1, "1"); dl_Prod3.Items.Insert(2, "2"); dl_Prod3.Items.Insert(3, "3"); dl_Prod3.Items.Insert(4, "4");
                                            break;
                                        case 5:
                                            dl_Prod3.Items.Insert(1, "1"); dl_Prod3.Items.Insert(2, "2"); dl_Prod3.Items.Insert(3, "3"); dl_Prod3.Items.Insert(4, "4"); dl_Prod3.Items.Insert(5, "5");
                                            break;
                                        case 6:
                                            dl_Prod3.Items.Insert(1, "1"); dl_Prod3.Items.Insert(2, "2"); dl_Prod3.Items.Insert(3, "3"); dl_Prod3.Items.Insert(4, "4"); dl_Prod3.Items.Insert(5, "5"); dl_Prod3.Items.Insert(6, "6");
                                            break;
                                    }
                                    ++ban;
                                    break;
                                case 2:
                                    val3 = 2;
                                    img_btn_Prod3.ImageUrl = "/Content/TacoPapa.jpg";
                                    img_btn_Prod3.Visible = true;
                                    btn_Mod3.Visible = true;
                                    dl_Prod3.Visible = true;
                                    lbl_Head3.Visible = true;
                                    
                                    suma += value.CostoTotal;
                                    switch (value.Cantidad)
                                    {
                                        case 1:
                                            dl_Prod3.Items.Insert(1, "1");
                                            break;
                                        case 2:
                                            dl_Prod3.Items.Insert(1, "1"); dl_Prod3.Items.Insert(2, "2");
                                            break;
                                        case 3:
                                            dl_Prod3.Items.Insert(1, "1"); dl_Prod3.Items.Insert(2, "2"); dl_Prod3.Items.Insert(3, "3");
                                            break;
                                        case 4:
                                            dl_Prod3.Items.Insert(1, "1"); dl_Prod3.Items.Insert(2, "2"); dl_Prod3.Items.Insert(3, "3"); dl_Prod3.Items.Insert(4, "4");
                                            break;
                                        case 5:
                                            dl_Prod3.Items.Insert(1, "1"); dl_Prod3.Items.Insert(2, "2"); dl_Prod3.Items.Insert(3, "3"); dl_Prod3.Items.Insert(4, "4"); dl_Prod3.Items.Insert(5, "5");
                                            break;
                                        case 6:
                                            dl_Prod3.Items.Insert(1, "1"); dl_Prod3.Items.Insert(2, "2"); dl_Prod3.Items.Insert(3, "3"); dl_Prod3.Items.Insert(4, "4"); dl_Prod3.Items.Insert(5, "5"); dl_Prod3.Items.Insert(6, "6");
                                            break;
                                    }
                                    ++ban;
                                    break;
                                case 3:
                                    val3 = 3;
                                    img_btn_Prod3.ImageUrl = "/Content/Wings.jpg";
                                    img_btn_Prod3.Visible = true;
                                    btn_Mod3.Visible = true;
                                    dl_Prod3.Visible = true;
                                    lbl_Head3.Visible = true;

                                    suma += value.CostoTotal;
                                    switch (value.Cantidad)
                                    {
                                        case 1:
                                            dl_Prod3.Items.Insert(1, "1");
                                            break;
                                        case 2:
                                            dl_Prod3.Items.Insert(1, "1"); dl_Prod3.Items.Insert(2, "2");
                                            break;
                                        case 3:
                                            dl_Prod3.Items.Insert(1, "1"); dl_Prod3.Items.Insert(2, "2"); dl_Prod3.Items.Insert(3, "3");
                                            break;
                                        case 4:
                                            dl_Prod3.Items.Insert(1, "1"); dl_Prod3.Items.Insert(2, "2"); dl_Prod3.Items.Insert(3, "3"); dl_Prod3.Items.Insert(4, "4");
                                            break;
                                        case 5:
                                            dl_Prod3.Items.Insert(1, "1"); dl_Prod3.Items.Insert(2, "2"); dl_Prod3.Items.Insert(3, "3"); dl_Prod3.Items.Insert(4, "4"); dl_Prod3.Items.Insert(5, "5");
                                            break;
                                        case 6:
                                            dl_Prod3.Items.Insert(1, "1"); dl_Prod3.Items.Insert(2, "2"); dl_Prod3.Items.Insert(3, "3"); dl_Prod3.Items.Insert(4, "4"); dl_Prod3.Items.Insert(5, "5"); dl_Prod3.Items.Insert(6, "6");
                                            break;
                                    }
                                    ++ban;
                                    break;
                                case 4:
                                    val3 = 4;
                                    img_btn_Prod3.ImageUrl = "/Content/Lapiz.jpg";
                                    img_btn_Prod3.Visible = true;
                                    btn_Mod3.Visible = true;
                                    dl_Prod3.Visible = true;
                                    lbl_Head3.Visible = true;

                                    suma += value.CostoTotal;
                                    switch (value.Cantidad)
                                    {
                                        case 1:
                                            dl_Prod3.Items.Insert(1, "1");
                                            break;
                                        case 2:
                                            dl_Prod3.Items.Insert(1, "1"); dl_Prod3.Items.Insert(2, "2");
                                            break;
                                        case 3:
                                            dl_Prod3.Items.Insert(1, "1"); dl_Prod3.Items.Insert(2, "2"); dl_Prod3.Items.Insert(3, "3");
                                            break;
                                        case 4:
                                            dl_Prod3.Items.Insert(1, "1"); dl_Prod3.Items.Insert(2, "2"); dl_Prod3.Items.Insert(3, "3"); dl_Prod3.Items.Insert(4, "4");
                                            break;
                                        case 5:
                                            dl_Prod3.Items.Insert(1, "1"); dl_Prod3.Items.Insert(2, "2"); dl_Prod3.Items.Insert(3, "3"); dl_Prod3.Items.Insert(4, "4"); dl_Prod3.Items.Insert(5, "5");
                                            break;
                                        case 6:
                                            dl_Prod3.Items.Insert(1, "1"); dl_Prod3.Items.Insert(2, "2"); dl_Prod3.Items.Insert(3, "3"); dl_Prod3.Items.Insert(4, "4"); dl_Prod3.Items.Insert(5, "5"); dl_Prod3.Items.Insert(6, "6");
                                            break;
                                    }
                                    ++ban;
                                    break;
                                case 5:
                                    val3 = 5;
                                    img_btn_Prod3.ImageUrl = "/Content/Hamburguesa.jpg";
                                    img_btn_Prod3.Visible = true;
                                    btn_Mod3.Visible = true;
                                    dl_Prod3.Visible = true;
                                    lbl_Head3.Visible = true;
                                    
                                    suma += value.CostoTotal;
                                    switch (value.Cantidad)
                                    {
                                        case 1:
                                            dl_Prod3.Items.Insert(1, "1");
                                            break;
                                        case 2:
                                            dl_Prod3.Items.Insert(1, "1"); dl_Prod3.Items.Insert(2, "2");
                                            break;
                                        case 3:
                                            dl_Prod3.Items.Insert(1, "1"); dl_Prod3.Items.Insert(2, "2"); dl_Prod3.Items.Insert(3, "3");
                                            break;
                                        case 4:
                                            dl_Prod3.Items.Insert(1, "1"); dl_Prod3.Items.Insert(2, "2"); dl_Prod3.Items.Insert(3, "3"); dl_Prod3.Items.Insert(4, "4");
                                            break;
                                        case 5:
                                            dl_Prod3.Items.Insert(1, "1"); dl_Prod3.Items.Insert(2, "2"); dl_Prod3.Items.Insert(3, "3"); dl_Prod3.Items.Insert(4, "4"); dl_Prod3.Items.Insert(5, "5");
                                            break;
                                        case 6:
                                            dl_Prod3.Items.Insert(1, "1"); dl_Prod3.Items.Insert(2, "2"); dl_Prod3.Items.Insert(3, "3"); dl_Prod3.Items.Insert(4, "4"); dl_Prod3.Items.Insert(5, "5"); dl_Prod3.Items.Insert(6, "6");
                                            break;
                                    }
                                    ++ban;
                                    break;
                                case 6:
                                    val3 = 6; ;
                                    img_btn_Prod3.ImageUrl = "/Content/Doradita.jpg";
                                    img_btn_Prod3.Visible = true;
                                    btn_Mod3.Visible = true;
                                    dl_Prod3.Visible = true;
                                    lbl_Head3.Visible = true;
                                    suma += value.CostoTotal;
                                    
                                    switch (value.Cantidad)
                                    {
                                        case 1:
                                            dl_Prod3.Items.Insert(1, "1");
                                            break;
                                        case 2:
                                            dl_Prod3.Items.Insert(1, "1"); dl_Prod3.Items.Insert(2, "2");
                                            break;
                                        case 3:
                                            dl_Prod3.Items.Insert(1, "1"); dl_Prod3.Items.Insert(2, "2"); dl_Prod3.Items.Insert(3, "3");
                                            break;
                                        case 4:
                                            dl_Prod3.Items.Insert(1, "1"); dl_Prod3.Items.Insert(2, "2"); dl_Prod3.Items.Insert(3, "3"); dl_Prod3.Items.Insert(4, "4");
                                            break;
                                        case 5:
                                            dl_Prod3.Items.Insert(1, "1"); dl_Prod3.Items.Insert(2, "2"); dl_Prod3.Items.Insert(3, "3"); dl_Prod3.Items.Insert(4, "4"); dl_Prod3.Items.Insert(5, "5");
                                            break;
                                        case 6:
                                            dl_Prod3.Items.Insert(1, "1"); dl_Prod3.Items.Insert(2, "2"); dl_Prod3.Items.Insert(3, "3"); dl_Prod3.Items.Insert(4, "4"); dl_Prod3.Items.Insert(5, "5"); dl_Prod3.Items.Insert(6, "6");
                                            break;
                                    }
                                    ++ban;
                                    break;

                            }
                            break;
                        case 3:
                            switch (value.IdProducto)
                            {
                                case 1:
                                    val4 = 1;
                                    img_btn_Prod4.ImageUrl = "/Content/Chalupa.jpg";
                                    img_btn_Prod4.Visible = true;
                                    btn_Mod4.Visible = true;
                                    dl_Prod4.Visible = true;
                                    lbl_Head4.Visible = true;
                                    
                                    suma += value.CostoTotal;
                                    switch (value.Cantidad)
                                    {
                                        case 1:
                                            dl_Prod4.Items.Insert(1, "1");
                                            break;
                                        case 2:
                                            dl_Prod4.Items.Insert(1, "1"); dl_Prod4.Items.Insert(2, "2");
                                            break;
                                        case 3:
                                            dl_Prod4.Items.Insert(1, "1"); dl_Prod4.Items.Insert(2, "2"); dl_Prod4.Items.Insert(3, "3");
                                            break;
                                        case 4:
                                            dl_Prod4.Items.Insert(1, "1"); dl_Prod4.Items.Insert(2, "2"); dl_Prod4.Items.Insert(3, "3"); dl_Prod4.Items.Insert(4, "4");
                                            break;
                                        case 5:
                                            dl_Prod4.Items.Insert(1, "1"); dl_Prod4.Items.Insert(2, "2"); dl_Prod4.Items.Insert(3, "3"); dl_Prod4.Items.Insert(4, "4"); dl_Prod4.Items.Insert(5, "5");
                                            break;
                                        case 6:
                                            dl_Prod4.Items.Insert(1, "1"); dl_Prod4.Items.Insert(2, "2"); dl_Prod4.Items.Insert(3, "3"); dl_Prod4.Items.Insert(4, "4"); dl_Prod4.Items.Insert(5, "5"); dl_Prod4.Items.Insert(6, "6");
                                            break;
                                    }
                                    ++ban;
                                    break;
                                case 2:
                                    val4 = 2;
                                    img_btn_Prod4.ImageUrl = "/Content/TacoPapa.jpg";
                                    img_btn_Prod4.Visible = true;
                                    btn_Mod4.Visible = true;
                                    dl_Prod4.Visible = true;
                                    lbl_Head4.Visible = true;
                                    
                                    suma += value.CostoTotal;
                                    switch (value.Cantidad)
                                    {
                                        case 1:
                                            dl_Prod4.Items.Insert(1, "1");
                                            break;
                                        case 2:
                                            dl_Prod4.Items.Insert(1, "1"); dl_Prod4.Items.Insert(2, "2");
                                            break;
                                        case 3:
                                            dl_Prod4.Items.Insert(1, "1"); dl_Prod4.Items.Insert(2, "2"); dl_Prod4.Items.Insert(3, "3");
                                            break;
                                        case 4:
                                            dl_Prod4.Items.Insert(1, "1"); dl_Prod4.Items.Insert(2, "2"); dl_Prod4.Items.Insert(3, "3"); dl_Prod4.Items.Insert(4, "4");
                                            break;
                                        case 5:
                                            dl_Prod4.Items.Insert(1, "1"); dl_Prod4.Items.Insert(2, "2"); dl_Prod4.Items.Insert(3, "3"); dl_Prod4.Items.Insert(4, "4"); dl_Prod4.Items.Insert(5, "5");
                                            break;
                                        case 6:
                                            dl_Prod4.Items.Insert(1, "1"); dl_Prod4.Items.Insert(2, "2"); dl_Prod4.Items.Insert(3, "3"); dl_Prod4.Items.Insert(4, "4"); dl_Prod4.Items.Insert(5, "5"); dl_Prod4.Items.Insert(6, "6");
                                            break;
                                    }
                                    ++ban;
                                    break;
                                case 3:
                                    val4 = 3;
                                    img_btn_Prod4.ImageUrl = "/Content/Wings.jpg";
                                    img_btn_Prod4.Visible = true;
                                    btn_Mod4.Visible = true;
                                    dl_Prod4.Visible = true;
                                    lbl_Head4.Visible = true;
                                    
                                    suma += value.CostoTotal;
                                    switch (value.Cantidad)
                                    {
                                        case 1:
                                            dl_Prod4.Items.Insert(1, "1");
                                            break;
                                        case 2:
                                            dl_Prod4.Items.Insert(1, "1"); dl_Prod4.Items.Insert(2, "2");
                                            break;
                                        case 3:
                                            dl_Prod4.Items.Insert(1, "1"); dl_Prod4.Items.Insert(2, "2"); dl_Prod4.Items.Insert(3, "3");
                                            break;
                                        case 4:
                                            dl_Prod4.Items.Insert(1, "1"); dl_Prod4.Items.Insert(2, "2"); dl_Prod4.Items.Insert(3, "3"); dl_Prod4.Items.Insert(4, "4");
                                            break;
                                        case 5:
                                            dl_Prod4.Items.Insert(1, "1"); dl_Prod4.Items.Insert(2, "2"); dl_Prod4.Items.Insert(3, "3"); dl_Prod4.Items.Insert(4, "4"); dl_Prod4.Items.Insert(5, "5");
                                            break;
                                        case 6:
                                            dl_Prod4.Items.Insert(1, "1"); dl_Prod4.Items.Insert(2, "2"); dl_Prod4.Items.Insert(3, "3"); dl_Prod4.Items.Insert(4, "4"); dl_Prod4.Items.Insert(5, "5"); dl_Prod4.Items.Insert(6, "6");
                                            break;
                                    }
                                    ++ban;
                                    break;
                                case 4:
                                    val4 = 4;
                                    img_btn_Prod4.ImageUrl = "/Content/Lapiz.jpg";
                                    img_btn_Prod4.Visible = true;
                                    btn_Mod4.Visible = true;
                                    dl_Prod4.Visible = true;
                                    lbl_Head4.Visible = true;
                                    
                                    suma += value.CostoTotal;
                                    switch (value.Cantidad)
                                    {
                                        case 1:
                                            dl_Prod4.Items.Insert(1, "1");
                                            break;
                                        case 2:
                                            dl_Prod4.Items.Insert(1, "1"); dl_Prod4.Items.Insert(2, "2");
                                            break;
                                        case 3:
                                            dl_Prod4.Items.Insert(1, "1"); dl_Prod4.Items.Insert(2, "2"); dl_Prod4.Items.Insert(3, "3");
                                            break;
                                        case 4:
                                            dl_Prod4.Items.Insert(1, "1"); dl_Prod4.Items.Insert(2, "2"); dl_Prod4.Items.Insert(3, "3"); dl_Prod4.Items.Insert(4, "4");
                                            break;
                                        case 5:
                                            dl_Prod4.Items.Insert(1, "1"); dl_Prod4.Items.Insert(2, "2"); dl_Prod4.Items.Insert(3, "3"); dl_Prod4.Items.Insert(4, "4"); dl_Prod4.Items.Insert(5, "5");
                                            break;
                                        case 6:
                                            dl_Prod4.Items.Insert(1, "1"); dl_Prod4.Items.Insert(2, "2"); dl_Prod4.Items.Insert(3, "3"); dl_Prod4.Items.Insert(4, "4"); dl_Prod4.Items.Insert(5, "5"); dl_Prod4.Items.Insert(6, "6");
                                            break;
                                    }
                                    ++ban;
                                    break;
                                case 5:
                                    val4 = 5;
                                    img_btn_Prod4.ImageUrl = "/Content/Hamburguesa.jpg";
                                    img_btn_Prod4.Visible = true;
                                    btn_Mod4.Visible = true;
                                    dl_Prod4.Visible = true;
                                    lbl_Head4.Visible = true;
                                   
                                    suma += value.CostoTotal;
                                    switch (value.Cantidad)
                                    {
                                        case 1:
                                            dl_Prod4.Items.Insert(1, "1");
                                            break;
                                        case 2:
                                            dl_Prod4.Items.Insert(1, "1"); dl_Prod4.Items.Insert(2, "2");
                                            break;
                                        case 3:
                                            dl_Prod4.Items.Insert(1, "1"); dl_Prod4.Items.Insert(2, "2"); dl_Prod4.Items.Insert(3, "3");
                                            break;
                                        case 4:
                                            dl_Prod4.Items.Insert(1, "1"); dl_Prod4.Items.Insert(2, "2"); dl_Prod4.Items.Insert(3, "3"); dl_Prod4.Items.Insert(4, "4");
                                            break;
                                        case 5:
                                            dl_Prod4.Items.Insert(1, "1"); dl_Prod4.Items.Insert(2, "2"); dl_Prod4.Items.Insert(3, "3"); dl_Prod4.Items.Insert(4, "4"); dl_Prod4.Items.Insert(5, "5");
                                            break;
                                        case 6:
                                            dl_Prod4.Items.Insert(1, "1"); dl_Prod4.Items.Insert(2, "2"); dl_Prod4.Items.Insert(3, "3"); dl_Prod4.Items.Insert(4, "4"); dl_Prod4.Items.Insert(5, "5"); dl_Prod4.Items.Insert(6, "6");
                                            break;
                                    }
                                    ++ban;
                                    break;
                                case 6:
                                    val4 = 6;
                                    img_btn_Prod4.ImageUrl = "/Content/Doradita.jpg";
                                    img_btn_Prod4.Visible = true;
                                    btn_Mod4.Visible = true;
                                    dl_Prod4.Visible = true;
                                    lbl_Head4.Visible = true;
                                    
                                    suma += value.CostoTotal;
                                    switch (value.Cantidad)
                                    {
                                        case 1:
                                            dl_Prod4.Items.Insert(1, "1");
                                            break;
                                        case 2:
                                            dl_Prod4.Items.Insert(1, "1"); dl_Prod4.Items.Insert(2, "2");
                                            break;
                                        case 3:
                                            dl_Prod4.Items.Insert(1, "1"); dl_Prod4.Items.Insert(2, "2"); dl_Prod4.Items.Insert(3, "3");
                                            break;
                                        case 4:
                                            dl_Prod4.Items.Insert(1, "1"); dl_Prod4.Items.Insert(2, "2"); dl_Prod4.Items.Insert(3, "3"); dl_Prod4.Items.Insert(4, "4");
                                            break;
                                        case 5:
                                            dl_Prod4.Items.Insert(1, "1"); dl_Prod4.Items.Insert(2, "2"); dl_Prod4.Items.Insert(3, "3"); dl_Prod4.Items.Insert(4, "4"); dl_Prod4.Items.Insert(5, "5");
                                            break;
                                        case 6:
                                            dl_Prod4.Items.Insert(1, "1"); dl_Prod4.Items.Insert(2, "2"); dl_Prod4.Items.Insert(3, "3"); dl_Prod4.Items.Insert(4, "4"); dl_Prod4.Items.Insert(5, "5"); dl_Prod4.Items.Insert(6, "6");
                                            break;
                                    }
                                    ++ban;
                                    break;
                            }
                            break;
                        case 4:
                            switch (value.IdProducto)
                            {
                                case 1:
                                    val5 = 1;
                                    img_btn_Prod5.ImageUrl = "/Content/Chalupa.jpg";
                                    img_btn_Prod5.Visible = true;
                                    btn_Mod5.Visible = true;
                                    dl_Prod5.Visible = true;
                                    lbl_Head5.Visible = true;
                                    
                                    suma += value.CostoTotal;
                                    switch (value.Cantidad)
                                    {
                                        case 1:
                                            dl_Prod5.Items.Insert(1, "1");
                                            break;
                                        case 2:
                                            dl_Prod5.Items.Insert(1, "1"); dl_Prod5.Items.Insert(2, "2");
                                            break;
                                        case 3:
                                            dl_Prod5.Items.Insert(1, "1"); dl_Prod5.Items.Insert(2, "2"); dl_Prod5.Items.Insert(3, "3");
                                            break;
                                        case 4:
                                            dl_Prod5.Items.Insert(1, "1"); dl_Prod5.Items.Insert(2, "2"); dl_Prod5.Items.Insert(3, "3"); dl_Prod5.Items.Insert(4, "4");
                                            break;
                                        case 5:
                                            dl_Prod5.Items.Insert(1, "1"); dl_Prod5.Items.Insert(2, "2"); dl_Prod5.Items.Insert(3, "3"); dl_Prod5.Items.Insert(4, "4"); dl_Prod5.Items.Insert(5, "5");
                                            break;
                                        case 6:
                                            dl_Prod5.Items.Insert(1, "1"); dl_Prod5.Items.Insert(2, "2"); dl_Prod5.Items.Insert(3, "3"); dl_Prod5.Items.Insert(4, "4"); dl_Prod5.Items.Insert(5, "5"); dl_Prod5.Items.Insert(6, "6");
                                            break;
                                    }
                                    ++ban;
                                    break;
                                case 2:
                                    val5 = 2;
                                    img_btn_Prod5.ImageUrl = "/Content/TacoPapa.jpg";
                                    img_btn_Prod5.Visible = true;
                                    btn_Mod5.Visible = true;
                                    dl_Prod5.Visible = true;
                                    lbl_Head5.Visible = true;
                                    
                                    suma += value.CostoTotal;
                                    switch (value.Cantidad)
                                    {
                                        case 1:
                                            dl_Prod5.Items.Insert(1, "1");
                                            break;
                                        case 2:
                                            dl_Prod5.Items.Insert(1, "1"); dl_Prod5.Items.Insert(2, "2");
                                            break;
                                        case 3:
                                            dl_Prod5.Items.Insert(1, "1"); dl_Prod5.Items.Insert(2, "2"); dl_Prod5.Items.Insert(3, "3");
                                            break;
                                        case 4:
                                            dl_Prod5.Items.Insert(1, "1"); dl_Prod5.Items.Insert(2, "2"); dl_Prod5.Items.Insert(3, "3"); dl_Prod5.Items.Insert(4, "4");
                                            break;
                                        case 5:
                                            dl_Prod5.Items.Insert(1, "1"); dl_Prod5.Items.Insert(2, "2"); dl_Prod5.Items.Insert(3, "3"); dl_Prod5.Items.Insert(4, "4"); dl_Prod5.Items.Insert(5, "5");
                                            break;
                                        case 6:
                                            dl_Prod5.Items.Insert(1, "1"); dl_Prod5.Items.Insert(2, "2"); dl_Prod5.Items.Insert(3, "3"); dl_Prod5.Items.Insert(4, "4"); dl_Prod5.Items.Insert(5, "5"); dl_Prod5.Items.Insert(6, "6");
                                            break;
                                    }
                                    ++ban;
                                    break;
                                case 3:
                                    val5 = 3;
                                    img_btn_Prod5.ImageUrl = "/Content/Wings.jpg";
                                    img_btn_Prod5.Visible = true;
                                    btn_Mod5.Visible = true;
                                    dl_Prod5.Visible = true;
                                    lbl_Head5.Visible = true;
                                    
                                    suma += value.CostoTotal;
                                    switch (value.Cantidad)
                                    {
                                        case 1:
                                            dl_Prod5.Items.Insert(1, "1");
                                            break;
                                        case 2:
                                            dl_Prod5.Items.Insert(1, "1"); dl_Prod5.Items.Insert(2, "2");
                                            break;
                                        case 3:
                                            dl_Prod5.Items.Insert(1, "1"); dl_Prod5.Items.Insert(2, "2"); dl_Prod5.Items.Insert(3, "3");
                                            break;
                                        case 4:
                                            dl_Prod5.Items.Insert(1, "1"); dl_Prod5.Items.Insert(2, "2"); dl_Prod5.Items.Insert(3, "3"); dl_Prod5.Items.Insert(4, "4");
                                            break;
                                        case 5:
                                            dl_Prod5.Items.Insert(1, "1"); dl_Prod5.Items.Insert(2, "2"); dl_Prod5.Items.Insert(3, "3"); dl_Prod5.Items.Insert(4, "4"); dl_Prod5.Items.Insert(5, "5");
                                            break;
                                        case 6:
                                            dl_Prod5.Items.Insert(1, "1"); dl_Prod5.Items.Insert(2, "2"); dl_Prod5.Items.Insert(3, "3"); dl_Prod5.Items.Insert(4, "4"); dl_Prod5.Items.Insert(5, "5"); dl_Prod5.Items.Insert(6, "6");
                                            break;
                                    }
                                    ++ban;
                                    break;
                                case 4:
                                    val5 = 4;
                                    img_btn_Prod5.ImageUrl = "/Content/Lapiz.jpg";
                                    img_btn_Prod5.Visible = true;
                                    btn_Mod5.Visible = true;
                                    dl_Prod5.Visible = true;
                                    lbl_Head5.Visible = true;
                                    
                                    suma += value.CostoTotal;
                                    switch (value.Cantidad)
                                    {
                                        case 1:
                                            dl_Prod5.Items.Insert(1, "1");
                                            break;
                                        case 2:
                                            dl_Prod5.Items.Insert(1, "1"); dl_Prod5.Items.Insert(2, "2");
                                            break;
                                        case 3:
                                            dl_Prod5.Items.Insert(1, "1"); dl_Prod5.Items.Insert(2, "2"); dl_Prod5.Items.Insert(3, "3");
                                            break;
                                        case 4:
                                            dl_Prod5.Items.Insert(1, "1"); dl_Prod5.Items.Insert(2, "2"); dl_Prod5.Items.Insert(3, "3"); dl_Prod5.Items.Insert(4, "4");
                                            break;
                                        case 5:
                                            dl_Prod5.Items.Insert(1, "1"); dl_Prod5.Items.Insert(2, "2"); dl_Prod5.Items.Insert(3, "3"); dl_Prod5.Items.Insert(4, "4"); dl_Prod5.Items.Insert(5, "5");
                                            break;
                                        case 6:
                                            dl_Prod5.Items.Insert(1, "1"); dl_Prod5.Items.Insert(2, "2"); dl_Prod5.Items.Insert(3, "3"); dl_Prod5.Items.Insert(4, "4"); dl_Prod5.Items.Insert(5, "5"); dl_Prod5.Items.Insert(6, "6");
                                            break;
                                    }
                                    ++ban;
                                    break;
                                case 5:
                                    val5 = 5;
                                    img_btn_Prod5.ImageUrl = "/Content/Hamburguesa.jpg";
                                    img_btn_Prod5.Visible = true;
                                    btn_Mod5.Visible = true;
                                    dl_Prod5.Visible = true;
                                    lbl_Head5.Visible = true;
                                    
                                    suma += value.CostoTotal;
                                    switch (value.Cantidad)
                                    {
                                        case 1:
                                            dl_Prod5.Items.Insert(1, "1");
                                            break;
                                        case 2:
                                            dl_Prod5.Items.Insert(1, "1"); dl_Prod5.Items.Insert(2, "2");
                                            break;
                                        case 3:
                                            dl_Prod5.Items.Insert(1, "1"); dl_Prod5.Items.Insert(2, "2"); dl_Prod5.Items.Insert(3, "3");
                                            break;
                                        case 4:
                                            dl_Prod5.Items.Insert(1, "1"); dl_Prod5.Items.Insert(2, "2"); dl_Prod5.Items.Insert(3, "3"); dl_Prod5.Items.Insert(4, "4");
                                            break;
                                        case 5:
                                            dl_Prod5.Items.Insert(1, "1"); dl_Prod5.Items.Insert(2, "2"); dl_Prod5.Items.Insert(3, "3"); dl_Prod5.Items.Insert(4, "4"); dl_Prod5.Items.Insert(5, "5");
                                            break;
                                        case 6:
                                            dl_Prod5.Items.Insert(1, "1"); dl_Prod5.Items.Insert(2, "2"); dl_Prod5.Items.Insert(3, "3"); dl_Prod5.Items.Insert(4, "4"); dl_Prod5.Items.Insert(5, "5"); dl_Prod5.Items.Insert(6, "6");
                                            break;
                                    }
                                    ++ban;
                                    break;
                                case 6:
                                    val5 = 6;
                                    img_btn_Prod5.ImageUrl = "/Content/Doradita.jpg";
                                    img_btn_Prod5.Visible = true;
                                    btn_Mod5.Visible = true;
                                    dl_Prod5.Visible = true;
                                    lbl_Head5.Visible = true;
                                    
                                    suma += value.CostoTotal;
                                    switch (value.Cantidad)
                                    {
                                        case 1:
                                            dl_Prod5.Items.Insert(1, "1");
                                            break;
                                        case 2:
                                            dl_Prod5.Items.Insert(1, "1"); dl_Prod5.Items.Insert(2, "2");
                                            break;
                                        case 3:
                                            dl_Prod5.Items.Insert(1, "1"); dl_Prod5.Items.Insert(2, "2"); dl_Prod5.Items.Insert(3, "3");
                                            break;
                                        case 4:
                                            dl_Prod5.Items.Insert(1, "1"); dl_Prod5.Items.Insert(2, "2"); dl_Prod5.Items.Insert(3, "3"); dl_Prod5.Items.Insert(4, "4");
                                            break;
                                        case 5:
                                            dl_Prod5.Items.Insert(1, "1"); dl_Prod5.Items.Insert(2, "2"); dl_Prod5.Items.Insert(3, "3"); dl_Prod5.Items.Insert(4, "4"); dl_Prod5.Items.Insert(5, "5");
                                            break;
                                        case 6:
                                            dl_Prod5.Items.Insert(1, "1"); dl_Prod5.Items.Insert(2, "2"); dl_Prod5.Items.Insert(3, "3"); dl_Prod5.Items.Insert(4, "4"); dl_Prod5.Items.Insert(5, "5"); dl_Prod5.Items.Insert(6, "6");
                                            break;
                                    }
                                    ++ban;
                                    break;

                            }
                            break;
                        case 5:
                            switch (value.IdProducto)
                            {
                                case 1:
                                    val6 = 1;
                                    img_btn_Prod6.ImageUrl = "/Content/Chalupa.jpg";
                                    img_btn_Prod6.Visible = true;
                                    dl_Prod6.Visible = true;
                                    lbl_Head6.Visible = true;
                                    btn_Mod6.Visible = true;
                                    suma += value.CostoTotal;
                                    switch (value.Cantidad)
                                    {
                                        case 1:
                                            dl_Prod6.Items.Insert(1, "1");
                                            break;
                                        case 2:
                                            dl_Prod6.Items.Insert(1, "1"); dl_Prod6.Items.Insert(2, "2");
                                            break;
                                        case 3:
                                            dl_Prod6.Items.Insert(1, "1"); dl_Prod6.Items.Insert(2, "2"); dl_Prod6.Items.Insert(3, "3");
                                            break;
                                        case 4:
                                            dl_Prod6.Items.Insert(1, "1"); dl_Prod6.Items.Insert(2, "2"); dl_Prod6.Items.Insert(3, "3"); dl_Prod6.Items.Insert(4, "4");
                                            break;
                                        case 5:
                                            dl_Prod6.Items.Insert(1, "1"); dl_Prod6.Items.Insert(2, "2"); dl_Prod6.Items.Insert(3, "3"); dl_Prod6.Items.Insert(4, "4"); dl_Prod6.Items.Insert(5, "5");
                                            break;
                                        case 6:
                                            dl_Prod6.Items.Insert(1, "1"); dl_Prod6.Items.Insert(2, "2"); dl_Prod6.Items.Insert(3, "3"); dl_Prod6.Items.Insert(4, "4"); dl_Prod6.Items.Insert(5, "5"); dl_Prod6.Items.Insert(6, "6");
                                            break;
                                    }
                                    ++ban;
                                    break;
                                case 2:
                                    val6 = 2;
                                    img_btn_Prod6.ImageUrl = "/Content/TacoPapa.jpg";
                                    img_btn_Prod6.Visible = true;
                                    dl_Prod6.Visible = true;
                                    lbl_Head6.Visible = true;
                                    btn_Mod6.Visible = true;
                                    suma += value.CostoTotal;
                                    switch (value.Cantidad)
                                    {
                                        case 1:
                                            dl_Prod6.Items.Insert(1, "1");
                                            break;
                                        case 2:
                                            dl_Prod6.Items.Insert(1, "1"); dl_Prod6.Items.Insert(2, "2");
                                            break;
                                        case 3:
                                            dl_Prod6.Items.Insert(1, "1"); dl_Prod6.Items.Insert(2, "2"); dl_Prod6.Items.Insert(3, "3");
                                            break;
                                        case 4:
                                            dl_Prod6.Items.Insert(1, "1"); dl_Prod6.Items.Insert(2, "2"); dl_Prod6.Items.Insert(3, "3"); dl_Prod6.Items.Insert(4, "4");
                                            break;
                                        case 5:
                                            dl_Prod6.Items.Insert(1, "1"); dl_Prod6.Items.Insert(2, "2"); dl_Prod6.Items.Insert(3, "3"); dl_Prod6.Items.Insert(4, "4"); dl_Prod6.Items.Insert(5, "5");
                                            break;
                                        case 6:
                                            dl_Prod6.Items.Insert(1, "1"); dl_Prod6.Items.Insert(2, "2"); dl_Prod6.Items.Insert(3, "3"); dl_Prod6.Items.Insert(4, "4"); dl_Prod6.Items.Insert(5, "5"); dl_Prod6.Items.Insert(6, "6");
                                            break;
                                    }
                                    ++ban;
                                    break;
                                case 3:
                                    val6 = 3;
                                    img_btn_Prod6.ImageUrl = "/Content/Wings.jpg";
                                    img_btn_Prod6.Visible = true;
                                    dl_Prod6.Visible = true;
                                    lbl_Head6.Visible = true;
                                    btn_Mod6.Visible = true;
                                    suma += value.CostoTotal;
                                    switch (value.Cantidad)
                                    {
                                        case 1:
                                            dl_Prod6.Items.Insert(1, "1");
                                            break;
                                        case 2:
                                            dl_Prod6.Items.Insert(1, "1"); dl_Prod6.Items.Insert(2, "2");
                                            break;
                                        case 3:
                                            dl_Prod6.Items.Insert(1, "1"); dl_Prod6.Items.Insert(2, "2"); dl_Prod6.Items.Insert(3, "3");
                                            break;
                                        case 4:
                                            dl_Prod6.Items.Insert(1, "1"); dl_Prod6.Items.Insert(2, "2"); dl_Prod6.Items.Insert(3, "3"); dl_Prod6.Items.Insert(4, "4");
                                            break;
                                        case 5:
                                            dl_Prod6.Items.Insert(1, "1"); dl_Prod6.Items.Insert(2, "2"); dl_Prod6.Items.Insert(3, "3"); dl_Prod6.Items.Insert(4, "4"); dl_Prod6.Items.Insert(5, "5");
                                            break;
                                        case 6:
                                            dl_Prod6.Items.Insert(1, "1"); dl_Prod6.Items.Insert(2, "2"); dl_Prod6.Items.Insert(3, "3"); dl_Prod6.Items.Insert(4, "4"); dl_Prod6.Items.Insert(5, "5"); dl_Prod6.Items.Insert(6, "6");
                                            break;
                                    }
                                    ++ban;
                                    break;
                                case 4:
                                    val6 = 4;
                                    img_btn_Prod6.ImageUrl = "/Content/Lapiz.jpg";
                                    img_btn_Prod6.Visible = true;
                                    dl_Prod6.Visible = true;
                                    lbl_Head6.Visible = true;
                                    btn_Mod6.Visible = true;
                                    suma += value.CostoTotal;
                                    switch (value.Cantidad)
                                    {
                                        case 1:
                                            dl_Prod6.Items.Insert(1, "1");
                                            break;
                                        case 2:
                                            dl_Prod6.Items.Insert(1, "1"); dl_Prod6.Items.Insert(2, "2");
                                            break;
                                        case 3:
                                            dl_Prod6.Items.Insert(1, "1"); dl_Prod6.Items.Insert(2, "2"); dl_Prod6.Items.Insert(3, "3");
                                            break;
                                        case 4:
                                            dl_Prod6.Items.Insert(1, "1"); dl_Prod6.Items.Insert(2, "2"); dl_Prod6.Items.Insert(3, "3"); dl_Prod6.Items.Insert(4, "4");
                                            break;
                                        case 5:
                                            dl_Prod6.Items.Insert(1, "1"); dl_Prod6.Items.Insert(2, "2"); dl_Prod6.Items.Insert(3, "3"); dl_Prod6.Items.Insert(4, "4"); dl_Prod6.Items.Insert(5, "5");
                                            break;
                                        case 6:
                                            dl_Prod6.Items.Insert(1, "1"); dl_Prod6.Items.Insert(2, "2"); dl_Prod6.Items.Insert(3, "3"); dl_Prod6.Items.Insert(4, "4"); dl_Prod6.Items.Insert(5, "5"); dl_Prod6.Items.Insert(6, "6");
                                            break;
                                    }
                                    ++ban;
                                    break;
                                case 5:
                                    val6 = 5;
                                    img_btn_Prod6.ImageUrl = "/Content/Hamburguesa.jpg";
                                    img_btn_Prod6.Visible = true;
                                    dl_Prod6.Visible = true;
                                    lbl_Head6.Visible = true;
                                    btn_Mod6.Visible = true;
                                    suma += value.CostoTotal;
                                    switch (value.Cantidad)
                                    {
                                        case 1:
                                            dl_Prod6.Items.Insert(1, "1");
                                            break;
                                        case 2:
                                            dl_Prod6.Items.Insert(1, "1"); dl_Prod6.Items.Insert(2, "2");
                                            break;
                                        case 3:
                                            dl_Prod6.Items.Insert(1, "1"); dl_Prod6.Items.Insert(2, "2"); dl_Prod6.Items.Insert(3, "3");
                                            break;
                                        case 4:
                                            dl_Prod6.Items.Insert(1, "1"); dl_Prod6.Items.Insert(2, "2"); dl_Prod6.Items.Insert(3, "3"); dl_Prod6.Items.Insert(4, "4");
                                            break;
                                        case 5:
                                            dl_Prod6.Items.Insert(1, "1"); dl_Prod6.Items.Insert(2, "2"); dl_Prod6.Items.Insert(3, "3"); dl_Prod6.Items.Insert(4, "4"); dl_Prod6.Items.Insert(5, "5");
                                            break;
                                        case 6:
                                            dl_Prod6.Items.Insert(1, "1"); dl_Prod6.Items.Insert(2, "2"); dl_Prod6.Items.Insert(3, "3"); dl_Prod6.Items.Insert(4, "4"); dl_Prod6.Items.Insert(5, "5"); dl_Prod6.Items.Insert(6, "6");
                                            break;
                                    }
                                    ++ban;
                                    break;
                                case 6:
                                    val6 = 6;
                                    img_btn_Prod6.ImageUrl = "/Content/Doradita.jpg";
                                    img_btn_Prod6.Visible = true;
                                    dl_Prod6.Visible = true;
                                    lbl_Head6.Visible = true;
                                    btn_Mod6.Visible = true;
                                    suma += value.CostoTotal;
                                    switch (value.Cantidad)
                                    {
                                        case 1:
                                            dl_Prod6.Items.Insert(1, "1");
                                            break;
                                        case 2:
                                            dl_Prod6.Items.Insert(1, "1"); dl_Prod6.Items.Insert(2, "2");
                                            break;
                                        case 3:
                                            dl_Prod6.Items.Insert(1, "1"); dl_Prod6.Items.Insert(2, "2"); dl_Prod6.Items.Insert(3, "3");
                                            break;
                                        case 4:
                                            dl_Prod6.Items.Insert(1, "1"); dl_Prod6.Items.Insert(2, "2"); dl_Prod6.Items.Insert(3, "3"); dl_Prod6.Items.Insert(4, "4");
                                            break;
                                        case 5:
                                            dl_Prod6.Items.Insert(1, "1"); dl_Prod6.Items.Insert(2, "2"); dl_Prod6.Items.Insert(3, "3"); dl_Prod6.Items.Insert(4, "4"); dl_Prod6.Items.Insert(5, "5");
                                            break;
                                        case 6:
                                            dl_Prod6.Items.Insert(1, "1"); dl_Prod6.Items.Insert(2, "2"); dl_Prod6.Items.Insert(3, "3"); dl_Prod6.Items.Insert(4, "4"); dl_Prod6.Items.Insert(5, "5"); dl_Prod6.Items.Insert(6, "6");
                                            break;
                                    }
                                    ++ban;
                                    break;

                            }
                            break;
                    }
                }
                txt_costototal.Text = suma.ToString();   
            }
            // foreach recorrido tabla, adentro el switch, cada uno de los cases nombre del producto, 
        }
        protected void gridPedido_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                string nombre = gridPedido.Rows[e.RowIndex].Cells[0].Text.TrimEnd();
                proxy.EliminarPedido(nombre, Contact.idPedido, Loging.idCarrito);
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());
            }
            finally
            {
                //gridPedido.DataSource = proxy.ObtenerProductoPer(Loging.idCarrito, Contact.idPedido);
                gridPedido.DataBind();
            }
        }

        protected void btn_Mod1_Click(object sender, EventArgs e)
        {
            try
            {
                //proxy.ModificarCantidad(Contact.idPedido, Loging.idCarrito, gridPedido.SelectedIndex, dl_Prod2.SelectedIndex);
                proxy.ModificarCantidad(1, 1, gridPedido.SelectedIndex, ind1);
                gridPedido.DataSource = proxy.EditProductoPer(Loging.idCarrito, Contact.idPedido,val1, ind1);
                gridPedido.DataBind();
            }
            catch(Exception exe)
            {
                Id_TacoPapas.Text = "Elija el número de producto a editar";
                exe.ToString();
            }
        }

        protected void btn_Mod2_Click(object sender, EventArgs e)
            {
                try
                {
                    //proxy.ModificarCantidad(Contact.idPedido, Loging.idCarrito, gridPedido.SelectedIndex, dl_Prod2.SelectedIndex);
                    proxy.ModificarCantidad(1, 1, gridPedido.SelectedIndex, dl_Prod2.SelectedIndex);
                    gridPedido.DataSource = proxy.EditProductoPer(Loging.idCarrito, Contact.idPedido, val2, ind2);
                    gridPedido.DataBind();
                }
                catch (Exception exe)
                {
                    Id_AlasPollo.Text = "Elija el número de producto a editar";
                    exe.ToString();
                }
        }

        protected void btn_Mod3_Click(object sender, EventArgs e)
        {                
            try
            {
                //proxy.ModificarCantidad(Contact.idPedido, Loging.idCarrito, gridPedido.SelectedIndex, dl_Prod3.SelectedIndex);
                proxy.ModificarCantidad(1, 1, gridPedido.SelectedIndex, dl_Prod3.SelectedIndex);
                gridPedido.DataSource = proxy.EditProductoPer(Loging.idCarrito, Contact.idPedido,val3, ind3);
                gridPedido.DataBind();
            }
            catch (Exception exe)
            {
                Id_Chalupas.Text = "Elija el número de producto a editar";
                exe.ToString();
            }
        }

        protected void btn_Mod4_Click(object sender, EventArgs e)
        {                
            try
            {
                //proxy.ModificarCantidad(Contact.idPedido, Loging.idCarrito,gridPedido.SelectedIndex, dl_Prod4.SelectedIndex);
                proxy.ModificarCantidad(1, 1,gridPedido.SelectedIndex, dl_Prod4.SelectedIndex);
                gridPedido.DataSource = proxy.EditProductoPer(Loging.idCarrito, Contact.idPedido,val4, ind4);
               gridPedido.DataBind();
            }
            catch (Exception exe)
            {
                Id_Lapiz.Text = "Elija el número de producto a editar";
               exe.ToString();
            }
        }

        protected void btn_Mod5_Click(object sender, EventArgs e)
        {                
            try
            {
                //proxy.ModificarCantidad(Contact.idPedido, Loging.idCarrito, gridPedido.SelectedIndex, dl_Prod5.SelectedIndex);
                proxy.ModificarCantidad(1, 1, gridPedido.SelectedIndex, dl_Prod5.SelectedIndex);
                gridPedido.DataSource = proxy.EditProductoPer(Loging.idCarrito, Contact.idPedido,val5,ind5);
                gridPedido.DataBind();
            }
            catch (Exception exe)
            {
                Id_Hamburguesa.Text = "Elija el número de producto a editar";
                exe.ToString();
            }
        }

        protected void btn_Mod6_Click(object sender, EventArgs e)
            {                
                try
                {
                    //proxy.ModificarCantidad(Contact.idPedido, Loging.idCarrito, gridPedido.SelectedIndex, dl_Prod6.SelectedIndex);
                    proxy.ModificarCantidad(1, 1, gridPedido.SelectedIndex, dl_Prod6.SelectedIndex);
                    gridPedido.DataSource = proxy.EditProductoPer(Loging.idCarrito, Contact.idPedido,val6, ind6);
                    gridPedido.DataBind();
                }
                catch (Exception exe)
                {
                    Id_Doraditas.Text = "Elija el número de producto a editar";
                    exe.ToString();
                }
        }

        protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
        {
            
            gridPedido.DataSource = proxy.ObtenerProductoPer(Loging.idCarrito, Contact.idPedido, val1, ind1);
            gridPedido.DataBind();
        }

        protected void Id_Pago_Click(object sender, EventArgs e)
        {

            Contact.idPedido++;
            About.ban = 0;
        }

        protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                //gridPedido.DataSource = proxy.ObtenerProductoPer(Loging.idCarrito, Contact.idPedido,val2,dl_Prod2.SelectedIndex);
                gridPedido.DataSource = proxy.ObtenerProductoPer(Loging.idCarrito, Contact.idPedido, val2,ind2);
                gridPedido.DataBind();
            }
            catch(Exception exe)
            {
                Id_AlasPollo.Text = "Elija el número de producto a editar";
                exe.ToString();
            }
        }

        protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                //gridPedido.DataSource = proxy.ObtenerProductoPer(Loging.idCarrito, Contact.idPedido,val3,dl_Prod3.SelectedIndex);
                gridPedido.DataSource = proxy.ObtenerProductoPer(Loging.idCarrito, Contact.idPedido, val3,ind3);
                gridPedido.DataBind();
            }
            catch(Exception exe)
            {
                Id_Chalupas.Text = "Elija el número de producto a editar";
                exe.ToString();
            }
        }

        protected void ImageButton10_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                //gridPedido.DataSource = proxy.ObtenerProductoPer(Loging.idCarrito, Contact.idPedido,val4,dl_Prod4.SelectedIndex);
                gridPedido.DataSource = proxy.ObtenerProductoPer(Loging.idCarrito, Contact.idPedido, val4,ind4);
                gridPedido.DataBind();
            }
            catch(Exception exe)
            {
                Id_Lapiz.Text = "Elija el número de producto a editar";
                exe.ToString();
            }
        }

        protected void ImageButton11_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                //gridPedido.DataSource = proxy.ObtenerProductoPer(Loging.idCarrito, Contact.idPedido,val5,dl_Prod5.SelectedIndex);
                gridPedido.DataSource = proxy.ObtenerProductoPer(Loging.idCarrito, Contact.idPedido, val5,ind5);
                gridPedido.DataBind();
            }
            catch(Exception exe)
            {
                Id_Hamburguesa.Text = "Elija el número de producto a editar";
                exe.ToString();
            }
        }

        protected void ImageButton12_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                //gridPedido.DataSource = proxy.ObtenerProductoPer(Loging.idCarrito, Contact.idPedido, val6, dl_Prod6.SelectedIndex);
                gridPedido.DataSource = proxy.ObtenerProductoPer(Loging.idCarrito, Contact.idPedido, val6, ind6);
                gridPedido.DataBind();
            }
            catch(Exception exe)
            {
                Id_Doraditas.Text = "Elija el número de producto a editar";
                exe.ToString();
            }
        }

        protected void dl_Prod1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ind1 = int.Parse(dl_Prod1.SelectedItem.Value);
        }

        protected void dl_Prod2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ind2 = int.Parse(dl_Prod2.SelectedItem.Value);
        }

        protected void dl_Prod3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ind3 = int.Parse(dl_Prod3.SelectedItem.Value); ;
        }

        protected void dl_Prod4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ind4 = int.Parse(dl_Prod4.SelectedItem.Value);
        }

        protected void dl_Prod5_SelectedIndexChanged(object sender, EventArgs e)
        {
            ind5 = int.Parse(dl_Prod5.SelectedItem.Value);
        }

        protected void dl_Prod6_SelectedIndexChanged(object sender, EventArgs e)
        {
            ind6 = int.Parse(dl_Prod6.SelectedItem.Value);
        }
    }
}