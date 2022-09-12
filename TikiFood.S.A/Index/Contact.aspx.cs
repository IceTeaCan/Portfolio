using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Index
{
    public partial class Contact : Page
    {
        //Variables globales para uso entre ventanas 
        public static int negocio     { get; set; }
        public static int ban         { get; set; }
        public static int idPedido    { get; set; }
        public static int prod1       { get; set; }
        public static int prod2       { get; set; }
        public static int prod3       { get; set; }
        public static int cant = 0;
        public static decimal MontPed { get; set; }

        private int[] ingAr = new int[10];

        ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (ban == 0)
            {
                ProdData();
                Image3.Visible = true;
                lblChalupas.Visible = true;
                Image4.Visible = true;
                lblDoraditas.Visible = true;
                Image5.Visible = true;
                lblHamburguesa.Visible = true;
                Image6.Visible = true;
                lblLapiz.Visible = true;
                lbl3.Visible = true;
                lbl4.Visible = true;
                lbl5.Visible = true;
                lbl6.Visible = true;
                lblMontoDor.Visible = true;
                lblMontoHam.Visible = true;
                lblMontoLa.Visible = true;
                lblMontoCha.Visible = true;
            }
            else
            {
                Soda(negocio, ban);
            }
        }

        public void Soda(int id, int Bandera)
        {
            try
            {
                // recorrido de la información que es contenida en el metodo obtenido por el WCF 
                foreach (var value in proxy.ConsultarData(id))
                {
                    if (value != null && Bandera == 1)
                    {
                        prod1 = value.IdProducto;
                        switch (value.Nombre)
                        {
                            case "Chalupa":
                                Image1.ImageUrl = "/Content/Chalupa.jpg";
                                lblTacoPapas.Text = value.Nombre;
                                lblMontoTaco.Text = value.CostoUnitario.ToString();
                                Bandera++;
                                break;
                            case "Taco con papas":
                                Image1.ImageUrl = "/Content/TacoPapa.jpg";
                                lblTacoPapas.Text = value.Nombre;
                                lblMontoTaco.Text = value.CostoUnitario.ToString();
                                Bandera++;
                                break;
                            case "Alas de Pollo":
                                Image1.ImageUrl = "/Content/Wings.jpg";
                                lblTacoPapas.Text = value.Nombre;
                                lblMontoTaco.Text = value.CostoUnitario.ToString();
                                Bandera++;
                                break;
                            case "Lapiz":
                                Image1.ImageUrl = "/Content/Lapiz.jpg";
                                lblTacoPapas.Text = value.Nombre;
                                lblMontoTaco.Text = value.CostoUnitario.ToString();
                                Bandera++;
                                break;
                            case "Hamburguesa":
                                Image1.ImageUrl = "/Content/Hamburguesa.jpg";
                                lblTacoPapas.Text = value.Nombre;
                                lblMontoTaco.Text = value.CostoUnitario.ToString();
                                Bandera++;
                                break;
                            case "Doraditas":
                                Image1.ImageUrl = "/Content/Doradita.jpg";
                                lblTacoPapas.Text = value.Nombre;
                                lblMontoTaco.Text = value.CostoUnitario.ToString();
                                Bandera++;
                                break;
                            default:
                                break;
                        }
                        Hide();
                    }
                    else if (value != null && Bandera == 2)
                    {
                        prod2 = value.IdProducto;
                        switch (value.Nombre)
                        {
                            case "Chalupa":
                                Image2.ImageUrl = "/Content/Chalupa.jpg";
                                lblAlasPollo.Text = value.Nombre;
                                lblMontoPollo.Text = value.CostoUnitario.ToString();
                                Bandera++;
                                break;
                            case "Taco con papas":
                                Image2.ImageUrl = "/Content/TacoPapa.jpg";
                                lblAlasPollo.Text = value.Nombre;
                                lblMontoPollo.Text = value.CostoUnitario.ToString();
                                Bandera++;
                                break;
                            case "Alas de Pollo":
                                Image2.ImageUrl = "/Content/Wings.jpg";
                                lblAlasPollo.Text = value.Nombre;
                                lblMontoPollo.Text = value.CostoUnitario.ToString();
                                Bandera++;
                                break;
                            case "Lapiz":
                                Image2.ImageUrl = "/Content/Lapiz.jpg";
                                lblAlasPollo.Text = value.Nombre;
                                lblMontoPollo.Text = value.CostoUnitario.ToString();
                                Bandera++;
                                break;
                            case "Hamburguesa":
                                Image2.ImageUrl = "/Content/Hamburguesa.jpg";
                                lblAlasPollo.Text = value.Nombre;
                                lblMontoPollo.Text = value.CostoUnitario.ToString();
                                Bandera++;
                                break;
                            case "Doraditas":
                                Image2.ImageUrl = "/Content/Doradita.jpg";
                                lblAlasPollo.Text = value.Nombre;
                                lblMontoPollo.Text = value.CostoUnitario.ToString();
                                Bandera++;
                                break;
                            default:
                                break;
                        }
                        Hide();
                    }
                }
            }
            catch (LinqDataSourceValidationException exe)
            {
                Response.Write(exe.Message.ToString());
            }
            catch (Exception exe)
            {
                Response.Write(exe.Message.ToString());
            }
            finally
            {
                Bandera = 0;
            }
        }
        public void Hide()
        {
            Image3.Visible = false;
            lblChalupas.Visible = false;
            Image4.Visible = false;
            lblDoraditas.Visible = false;
            Image5.Visible = false;
            lblHamburguesa.Visible = false;
            Image6.Visible = false;
            lblLapiz.Visible = false;
            lbl3.Visible = false;
            lbl4.Visible = false;
            lbl5.Visible = false;
            lbl6.Visible = false;
            lblMontoDor.Visible = false;
            lblMontoHam.Visible = false;
            lblMontoLa.Visible = false;
            lblMontoCha.Visible = false;
        }

        public void ProdData()
        {
            try
            {
                // recorrido de la información que es contenida en el metodo obtenido por el WCF 
                foreach (var value in proxy.ConsProduct())
                {
                    if (value != null)
                    {
                        switch (value.IdProducto)
                        {
                            case 1:
                                Image1.ImageUrl = "/Content/Chalupa.jpg";
                                lblTacoPapas.Text = value.Nombre;
                                lblMontoTaco.Text = value.CostoUnitario.ToString();
                                prod1 = 1;
                                break;
                            case 2:
                                Image2.ImageUrl = "/Content/TacoPapa.jpg";
                                lblAlasPollo.Text = value.Nombre;
                                lblMontoPollo.Text = value.CostoUnitario.ToString();
                                prod2 = 2;
                                break;
                            case 3:
                                Image3.ImageUrl = "/Content/Wings.jpg";
                                lblChalupas.Text = value.Nombre;
                                lblMontoCha.Text = value.CostoUnitario.ToString();
                                break;
                            case 4:
                                Image4.ImageUrl = "/Content/Lapiz.jpg";
                                lblLapiz.Text = value.Nombre;
                                lblMontoLa.Text = value.CostoUnitario.ToString();
                                break;
                            case 5:
                                Image5.ImageUrl = "/Content/Hamburguesa.jpg";
                                lblHamburguesa.Text = value.Nombre;
                                lblMontoHam.Text = value.CostoUnitario.ToString();
                                break;
                            case 6:
                                Image6.ImageUrl = "/Content/Doradita.jpg";
                                lblDoraditas.Text = value.Nombre;
                                lblMontoDor.Text = value.CostoUnitario.ToString();
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            catch (LinqDataSourceValidationException exe)
            {
                Response.Write(exe.Message.ToString());
            }
            catch (Exception exe)
            {
                Response.Write(exe.Message.ToString());
            }
        }

        protected void Prod1_Click(object sender, ImageClickEventArgs e)
        {
            if(ban!=0)//condicion para mostrar toda la lista de producto o un producto en especifico 
            {
                switch (prod1)
                {
                    case 1:
                        cbIngre1.Visible = true;
                        cbIngre2.Visible = true;
                        cbIngre3.Visible = true;
                        cbIngre4.Visible = true;
                        cbIngre1.Text = proxy.ConsultContProd(7);
                        cbIngre2.Text = proxy.ConsultContProd(4);
                        cbIngre3.Text = proxy.ConsultContProd(14);
                        cbIngre4.Text = proxy.ConsultContProd(5);
                        cbIngre5.Visible = false;
                        cbIngre6.Visible = false;
                        cbIngre7.Visible = false;
                        cbIngre8.Visible = false;
                        cbIngre9.Visible = false;
                        ingAr[0] = 7;
                        ingAr[1] = 4;
                        ingAr[2] = 14;
                        ingAr[3] = 5;
                        prod3 = 1;
                        break;
                    case 2:
                        cbIngre1.Visible = true;
                        cbIngre2.Visible = true;
                        cbIngre3.Visible = true;
                        cbIngre4.Visible = true;
                        cbIngre5.Visible = true;
                        cbIngre1.Text = proxy.ConsultContProd(2);
                        cbIngre2.Text = proxy.ConsultContProd(11);
                        cbIngre3.Text = proxy.ConsultContProd(12);
                        cbIngre4.Text = proxy.ConsultContProd(8);
                        cbIngre5.Text = proxy.ConsultContProd(9);
                        cbIngre6.Visible = false;
                        cbIngre7.Visible = false;
                        cbIngre8.Visible = false;
                        cbIngre9.Visible = false;
                        ingAr[0] = 2;
                        ingAr[1] = 11;
                        ingAr[2] = 12;
                        ingAr[3] = 8;
                        ingAr[4] = 9;
                        prod3 = 2;
                        break;
                    case 3:
                        cbIngre1.Visible = true;
                        cbIngre2.Visible = true;
                        cbIngre3.Visible = true;
                        cbIngre4.Visible = true;
                        cbIngre1.Text = proxy.ConsultContProd(15);
                        cbIngre2.Text = proxy.ConsultContProd(16);
                        cbIngre3.Text = proxy.ConsultContProd(17);
                        cbIngre4.Text = proxy.ConsultContProd(18);
                        cbIngre5.Visible = false;
                        cbIngre6.Visible = false;
                        cbIngre7.Visible = false;
                        cbIngre8.Visible = false;
                        cbIngre9.Visible = false;
                        ingAr[0] = 15;
                        ingAr[1] = 16;
                        ingAr[2] = 17;
                        ingAr[3] = 18;
                        prod3 = 3;
                        break;
                    case 4:
                        cbIngre1.Visible = true;
                        cbIngre2.Visible = true;
                        cbIngre3.Visible = true;
                        cbIngre4.Visible = true;
                        cbIngre5.Visible = true;
                        cbIngre1.Text = proxy.ConsultContProd(21);
                        cbIngre2.Text = proxy.ConsultContProd(7);
                        cbIngre3.Text = proxy.ConsultContProd(12);
                        cbIngre4.Text = proxy.ConsultContProd(13);
                        cbIngre5.Text = proxy.ConsultContProd(20);
                        cbIngre6.Visible = false;
                        cbIngre7.Visible = false;
                        cbIngre8.Visible = false;
                        cbIngre9.Visible = false;
                        ingAr[0] = 21;
                        ingAr[1] = 7;
                        ingAr[2] = 12;
                        ingAr[3] = 13;
                        ingAr[4] = 20;
                        prod3 = 4;
                        break;
                    case 5:
                        cbIngre1.Visible = true;
                        cbIngre2.Visible = true;
                        cbIngre3.Visible = true;
                        cbIngre4.Visible = true;
                        cbIngre5.Visible = true;
                        cbIngre6.Visible = true;
                        cbIngre7.Visible = true;
                        cbIngre8.Visible = true;
                        cbIngre9.Visible = true;
                        cbIngre1.Text = proxy.ConsultContProd(6);
                        cbIngre2.Text = proxy.ConsultContProd(20);
                        cbIngre3.Text = proxy.ConsultContProd(4);
                        cbIngre4.Text = proxy.ConsultContProd(5);
                        cbIngre5.Text = proxy.ConsultContProd(3);
                        cbIngre6.Text = proxy.ConsultContProd(13);
                        cbIngre7.Text = proxy.ConsultContProd(8);
                        cbIngre8.Text = proxy.ConsultContProd(9);
                        cbIngre9.Text = proxy.ConsultContProd(1);
                        ingAr[0] = 6;
                        ingAr[1] = 20;
                        ingAr[2] = 4;
                        ingAr[3] = 5;
                        ingAr[4] = 13;
                        ingAr[5] = 6;
                        ingAr[6] = 20;
                        ingAr[7] = 4;
                        ingAr[8] = 5;
                        ingAr[9] = 3;
                        prod3 = 5;
                        break;
                    case 6:
                        cbIngre1.Visible = true;
                        cbIngre2.Visible = true;
                        cbIngre3.Visible = true;
                        cbIngre1.Text = proxy.ConsultContProd(10);
                        cbIngre2.Text = proxy.ConsultContProd(9);
                        cbIngre3.Text = proxy.ConsultContProd(8);
                        cbIngre4.Visible = false;
                        cbIngre5.Visible = false;
                        cbIngre6.Visible = false;
                        cbIngre7.Visible = false;
                        cbIngre8.Visible = false;
                        cbIngre9.Visible = false;
                        ingAr[0] = 10;
                        ingAr[1] = 9;
                        ingAr[2] = 8;
                        prod3 = 6;
                        break;

                    default:
                        break;

                }
            }
            else
            {
                cbIngre1.Visible = true;
                cbIngre2.Visible = true;
                cbIngre3.Visible = true;
                cbIngre4.Visible = true;
                cbIngre1.Text = proxy.ConsultContProd(7);
                cbIngre2.Text = proxy.ConsultContProd(4);
                cbIngre3.Text = proxy.ConsultContProd(14);
                cbIngre4.Text = proxy.ConsultContProd(5);
                cbIngre5.Visible = false;
                cbIngre6.Visible = false;
                cbIngre7.Visible = false;
                cbIngre8.Visible = false;
                cbIngre9.Visible = false;
                ingAr[0] = 7;
                ingAr[1] = 4;
                ingAr[2] = 14;
                ingAr[3] = 5;
                prod3 = 1;
            }
        }

        protected void Prod2_Click(object sender, ImageClickEventArgs e)
        {
            switch (prod2)
            {
                case 1:
                    cbIngre1.Visible = true;
                    cbIngre2.Visible = true;
                    cbIngre3.Visible = true;
                    cbIngre4.Visible = true;
                    cbIngre1.Text = proxy.ConsultContProd(7);
                    cbIngre2.Text = proxy.ConsultContProd(4);
                    cbIngre3.Text = proxy.ConsultContProd(14);
                    cbIngre4.Text = proxy.ConsultContProd(5);
                    cbIngre5.Visible = false;
                    cbIngre6.Visible = false;
                    cbIngre7.Visible = false;
                    cbIngre8.Visible = false;
                    cbIngre9.Visible = false;
                    ingAr[0] = 7;
                    ingAr[1] = 4;
                    ingAr[2] = 14;
                    ingAr[3] = 5;
                    prod3 = 1;
                    break;
                case 2:
                    cbIngre1.Visible = true;
                    cbIngre2.Visible = true;
                    cbIngre3.Visible = true;
                    cbIngre4.Visible = true;
                    cbIngre5.Visible = true;
                    cbIngre1.Text = proxy.ConsultContProd(2);
                    cbIngre2.Text = proxy.ConsultContProd(11);
                    cbIngre3.Text = proxy.ConsultContProd(12);
                    cbIngre4.Text = proxy.ConsultContProd(8);
                    cbIngre5.Text = proxy.ConsultContProd(9);
                    cbIngre6.Visible = false;
                    cbIngre7.Visible = false;
                    cbIngre8.Visible = false;
                    cbIngre9.Visible = false;
                    ingAr[0] = 2;
                    ingAr[1] = 11;
                    ingAr[2] = 12;
                    ingAr[3] = 8;
                    ingAr[4] = 9;
                    prod3 = 2;
                    break;
                case 3:
                    cbIngre1.Visible = true;
                    cbIngre2.Visible = true;
                    cbIngre3.Visible = true;
                    cbIngre4.Visible = true;
                    cbIngre1.Text = proxy.ConsultContProd(15);
                    cbIngre2.Text = proxy.ConsultContProd(16);
                    cbIngre3.Text = proxy.ConsultContProd(17);
                    cbIngre4.Text = proxy.ConsultContProd(18);
                    cbIngre5.Visible = false;
                    cbIngre6.Visible = false;
                    cbIngre7.Visible = false;
                    cbIngre8.Visible = false;
                    cbIngre9.Visible = false;
                    ingAr[0] = 15;
                    ingAr[1] = 16;
                    ingAr[2] = 17;
                    ingAr[3] = 18;
                    prod3 = 3;
                    break;
                case 4:
                    cbIngre1.Visible = true;
                    cbIngre2.Visible = true;
                    cbIngre3.Visible = true;
                    cbIngre4.Visible = true;
                    cbIngre5.Visible = true;
                    cbIngre1.Text = proxy.ConsultContProd(21);
                    cbIngre2.Text = proxy.ConsultContProd(7);
                    cbIngre3.Text = proxy.ConsultContProd(12);
                    cbIngre4.Text = proxy.ConsultContProd(13);
                    cbIngre5.Text = proxy.ConsultContProd(20);
                    cbIngre6.Visible = false;
                    cbIngre7.Visible = false;
                    cbIngre8.Visible = false;
                    cbIngre9.Visible = false;
                    ingAr[0] = 21;
                    ingAr[1] = 7;
                    ingAr[2] = 12;
                    ingAr[3] = 13;
                    ingAr[4] = 20;
                    prod3 = 4;
                    break;
                case 5:
                    cbIngre1.Visible = true;
                    cbIngre2.Visible = true;
                    cbIngre3.Visible = true;
                    cbIngre4.Visible = true;
                    cbIngre5.Visible = true;
                    cbIngre6.Visible = true;
                    cbIngre7.Visible = true;
                    cbIngre8.Visible = true;
                    cbIngre9.Visible = true;
                    cbIngre1.Text = proxy.ConsultContProd(6);
                    cbIngre2.Text = proxy.ConsultContProd(20);
                    cbIngre3.Text = proxy.ConsultContProd(4);
                    cbIngre4.Text = proxy.ConsultContProd(5);
                    cbIngre5.Text = proxy.ConsultContProd(3);
                    cbIngre6.Text = proxy.ConsultContProd(13);
                    cbIngre7.Text = proxy.ConsultContProd(8);
                    cbIngre8.Text = proxy.ConsultContProd(9);
                    cbIngre9.Text = proxy.ConsultContProd(1);
                    ingAr[0] = 6;
                    ingAr[1] = 20;
                    ingAr[2] = 4;
                    ingAr[3] = 5;
                    ingAr[4] = 13;
                    ingAr[5] = 6;
                    ingAr[6] = 20;
                    ingAr[7] = 4;
                    ingAr[8] = 5;
                    ingAr[9] = 3;
                    prod3 = 5;
                    break;
                case 6:
                    cbIngre1.Visible = true;
                    cbIngre2.Visible = true;
                    cbIngre3.Visible = true;
                    cbIngre1.Text = proxy.ConsultContProd(10);
                    cbIngre2.Text = proxy.ConsultContProd(9);
                    cbIngre3.Text = proxy.ConsultContProd(8);
                    cbIngre4.Visible = false;
                    cbIngre5.Visible = false;
                    cbIngre6.Visible = false;
                    cbIngre7.Visible = false;
                    cbIngre8.Visible = false;
                    cbIngre9.Visible = false;
                    ingAr[0] = 10;
                    ingAr[1] = 9;
                    ingAr[2] = 8;
                    prod3 = 6;
                    break;

                default:
                    break;

            }
        }

        protected void Prod3_Click(object sender, ImageClickEventArgs e)
        {
            cbIngre1.Visible = true;
            cbIngre2.Visible = true;
            cbIngre3.Visible = true;
            cbIngre4.Visible = true;
            cbIngre1.Text = proxy.ConsultContProd(15);
            cbIngre2.Text = proxy.ConsultContProd(16);
            cbIngre3.Text = proxy.ConsultContProd(17);
            cbIngre4.Text = proxy.ConsultContProd(18);
            cbIngre5.Visible = false;
            cbIngre6.Visible = false;
            cbIngre7.Visible = false;
            cbIngre8.Visible = false;
            cbIngre9.Visible = false;
            ingAr[0] = 15;
            ingAr[1] = 16;
            ingAr[2] = 17;
            ingAr[3] = 18;
            prod3 = 3;
        }

        protected void Prod4_Click(object sender, ImageClickEventArgs e)
        {
            cbIngre1.Visible = true;
            cbIngre2.Visible = true;
            cbIngre3.Visible = true;
            cbIngre4.Visible = true;
            cbIngre5.Visible = true;
            cbIngre1.Text = proxy.ConsultContProd(21);
            cbIngre2.Text = proxy.ConsultContProd(7);
            cbIngre3.Text = proxy.ConsultContProd(12);
            cbIngre4.Text = proxy.ConsultContProd(13);
            cbIngre5.Text = proxy.ConsultContProd(20);
            cbIngre6.Visible = false;
            cbIngre7.Visible = false;
            cbIngre8.Visible = false;
            cbIngre9.Visible = false;
            ingAr[0] = 21;
            ingAr[1] = 7;
            ingAr[2] = 12;
            ingAr[3] = 13;
            ingAr[4] = 20;
            prod3 = 4;
        }

        protected void Prod5_Click(object sender, ImageClickEventArgs e)
        {
            cbIngre1.Visible = true;
            cbIngre2.Visible = true;
            cbIngre3.Visible = true;
            cbIngre4.Visible = true;
            cbIngre5.Visible = true;
            cbIngre6.Visible = true;
            cbIngre7.Visible = true;
            cbIngre8.Visible = true;
            cbIngre9.Visible = true;
            cbIngre1.Text = proxy.ConsultContProd(6);
            cbIngre2.Text = proxy.ConsultContProd(20);
            cbIngre3.Text = proxy.ConsultContProd(4);
            cbIngre4.Text = proxy.ConsultContProd(5);
            cbIngre5.Text = proxy.ConsultContProd(3);
            cbIngre6.Text = proxy.ConsultContProd(13);
            cbIngre7.Text = proxy.ConsultContProd(8);
            cbIngre8.Text = proxy.ConsultContProd(9);
            cbIngre9.Text = proxy.ConsultContProd(1);
            ingAr[0] = 6;
            ingAr[1] = 20;
            ingAr[2] = 4;
            ingAr[3] = 5;
            ingAr[4] = 13;
            ingAr[5] = 6;
            ingAr[6] = 20;
            ingAr[7] = 4;
            ingAr[8] = 5;
            ingAr[9] = 3;
            prod3 = 5;
        }

        protected void Prod6_Click(object sender, ImageClickEventArgs e)
        {
            cbIngre1.Visible = true;
            cbIngre2.Visible = true;
            cbIngre3.Visible = true;
            cbIngre1.Text = proxy.ConsultContProd(10);
            cbIngre2.Text = proxy.ConsultContProd(9);
            cbIngre3.Text = proxy.ConsultContProd(8);
            cbIngre4.Visible = false;
            cbIngre5.Visible = false;
            cbIngre6.Visible = false;
            cbIngre7.Visible = false;
            cbIngre8.Visible = false;
            cbIngre9.Visible = false;
            ingAr[0] = 10;
            ingAr[1] = 9;
            ingAr[2] = 8;
            prod3 = 6;
        }

        public static void Refresh(int ban1)
        {
            if(ban1==0)
            {
                ban = 0;
                negocio = 0;
                SiteMaster.ban1++;
            }
        }

        protected void Most_prod_Click(object sender, EventArgs e)
        {
            SiteMaster.ban1 = 0;
        }

        protected void btnProduct_Click(object sender, EventArgs e)
        {
            idPedido = 1;
            About.ban = 0;
        }

        protected void cbIngre1_CheckedChanged(object sender, EventArgs e)
        {
            cant = 0;
        }

        protected void cbIngre2_CheckedChanged(object sender, EventArgs e)
        {
            cant = 0;
        }

        protected void cbIngre3_CheckedChanged(object sender, EventArgs e)
        {
            cant = 0;
        }

        protected void cbIngre4_CheckedChanged(object sender, EventArgs e)
        {
            cant = 0;
        }

        protected void cbIngre5_CheckedChanged(object sender, EventArgs e)
        {
            cant = 0;
        }

        protected void cbIngre6_CheckedChanged(object sender, EventArgs e)
        {
            cant = 0;
        }

        protected void cbIngre7_CheckedChanged(object sender, EventArgs e)
        {
            cant = 0;
        }

        protected void cbIngre8_CheckedChanged(object sender, EventArgs e)
        {
            cant = 0;
        }

        protected void cbIngre9_CheckedChanged(object sender, EventArgs e)
        {
            cant = 0;
        }
    }
}