<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Index.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="Productos Carrito">

        <div class="col-md-4" style="color:white">
           <h2 style="color: #ff0000">
               <asp:Label ID="lbl1" runat="server" Text="#1"></asp:Label>
            </h2>
           <h2><asp:ImageButton ID="Image1" runat="server" Height="162px" Width="195px" ImageUrl="/Content/TacoPapa.jpg" OnClick="Prod1_Click" />
            </h2>
           <h2>
               <asp:Label ID="lblTacoPapas" runat="server" Text=""></asp:Label>
               <br/><asp:Label ID="lblMontoTaco" runat="server" Text=""></asp:Label>

            </h2>
        </div>

        <div class="col-md-4" style="color:white">
           <h2 style="color:#ff0000">
               <asp:Label ID="lbl2" runat="server" Text="#2"></asp:Label>
            </h2>
           <h2> <asp:ImageButton ID="Image2" runat="server" Height="161px" Width="195px" ImageUrl="/Content/Wings.jpg" OnClick="Prod2_Click"/>
            </h2>
           <h2>
               <asp:Label ID="lblAlasPollo" runat="server" Text=""></asp:Label>
               <br/><asp:Label ID="lblMontoPollo" runat="server" Text=""></asp:Label>
            </h2>
        </div>

        <div class="table">
           <div style="display: table-cell; font-style:oblique;color:#ff0000">
            <h2>
                <asp:Label ID="lbl3" runat="server" Text="#3"></asp:Label>
               </h2>
               <h2><asp:ImageButton ID="Image3" runat="server" Height="162px" Width="195px" ImageUrl="/Content/Chalupa.jpg" OnClick="Prod3_Click" />
               </h2>
           <h2 style="color:white">
               <asp:Label ID="lblChalupas" runat="server" Text=""></asp:Label>
               <br/><asp:Label ID="lblMontoCha" runat="server" Text=""></asp:Label>
               </h2>
           </div>
        </div>
   </div>

            <div class="Productos Carrito">

        <div class="col-md-4" style="color:white">
           <h2 style="color: #ff0000">
               <asp:Label ID="lbl4" runat="server" Text="#4"></asp:Label>
            </h2>
           <h2><asp:ImageButton ID="Image4" runat="server" Height="162px" Width="195px" ImageUrl="/Content/Lapiz.jpg" OnClick="Prod4_Click" />
            </h2>
           <h2>
               <asp:Label ID="lblLapiz" runat="server" Text=""></asp:Label>
               <br/><asp:Label ID="lblMontoLa" runat="server" Text=""></asp:Label>
            </h2>
        </div>

        <div class="col-md-4" style="color:white">
           <h2 style="color: #ff0000">
               <asp:Label ID="lbl5" runat="server" Text="#5"></asp:Label>
            </h2>
           <h2> <asp:ImageButton ID="Image5" runat="server" Height="161px" Width="195px" ImageUrl="/Content/Hamburguesa.jpg" OnClick="Prod5_Click" />
            </h2>
           <h2>
               <asp:Label ID="lblHamburguesa" runat="server" Text=""></asp:Label>
               <br/><asp:Label ID="lblMontoHam" runat="server" Text=""></asp:Label>
            </h2>
        </div>

        <div class="table">
           <div style="display: table-cell; font-style:oblique;color:#ff0000">
            <h2>
                <asp:Label ID="lbl6" runat="server" Text="#6"></asp:Label>
               </h2>
               <h2><asp:ImageButton ID="Image6" runat="server" Height="162px" Width="195px" ImageUrl="/Content/Doradita.jpg" OnClick="Prod6_Click" />
               </h2>
           <h2 style="color:white">
               <asp:Label ID="lblDoraditas" runat="server" Text=""></asp:Label>
               <br/><asp:Label ID="lblMontoDor" runat="server" Text=""></asp:Label>
               </h2>
           </div>
        </div>
    </div>



    
</asp:Content>
<asp:Content ID="ContentMenu" ContentPlaceHolderID="ContentMenu" runat="server">
    <div class="container" style="float:right; width:250px; background-color:rgba(0,0, 0, 0.3); height: 677px; padding-top:20px">
            <div  style="height:100px;background-color:black;">
                
                <br />
                <br />
&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;
                                
            </div>
            <ul></ul>
            <div style="height:476px; background-color:black;">

                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Most_prod" runat="server" OnClick="Most_prod_Click" Text="Mostrar Todos los productos" Width="211px" />
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:CheckBox ID="cbIngre1" runat="server" Checked="True" ForeColor="White" OnCheckedChanged="cbIngre1_CheckedChanged"/>
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:CheckBox ID="cbIngre2" runat="server" Checked="True" ForeColor="White" OnCheckedChanged="cbIngre2_CheckedChanged" />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:CheckBox ID="cbIngre3" runat="server" Checked="True" ForeColor="White" OnCheckedChanged="cbIngre3_CheckedChanged" />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:CheckBox ID="cbIngre4" runat="server" Checked="True" ForeColor="White" OnCheckedChanged="cbIngre4_CheckedChanged" />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:CheckBox ID="cbIngre5" runat="server" Checked="True" ForeColor="White" OnCheckedChanged="cbIngre5_CheckedChanged" />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:CheckBox ID="cbIngre6" runat="server" Checked="True" ForeColor="White" OnCheckedChanged="cbIngre6_CheckedChanged" />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:CheckBox ID="cbIngre7" runat="server" Checked="True" ForeColor="White" OnCheckedChanged="cbIngre7_CheckedChanged" />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:CheckBox ID="cbIngre8" runat="server" Checked="True" ForeColor="White" OnCheckedChanged="cbIngre8_CheckedChanged" />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:CheckBox ID="cbIngre9" runat="server" Checked="True" ForeColor="White" OnCheckedChanged="cbIngre9_CheckedChanged" />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <br />
&nbsp;<ul>
                    <asp:Button ID="btnProduct" runat="server" Text="Pedir" OnClick="btnProduct_Click" />
                </ul>
                
            </div>
        </div>
    </asp:Content>
