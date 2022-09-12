<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Index._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div id="myCarousel" class="carousel slide" data-ride="carousel">
        <!-- Indicators -->
        <ol class="carousel-indicators">
            <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
            <li data-target="#myCarousel" data-slide-to="1"></li>
            <li data-target="#myCarousel" data-slide-to="2"></li>
        </ol>

        <!-- Wrapper for slides -->
        <div class="carousel-inner">
            <div class="item active">
                <img src="/Content/Soda1.jpg" height="242" width="289">
                <div class="carousel-caption">
                    <br />
                    <br />
                    <br /><asp:Label ID="lblSoda1" runat="server" Text=""></asp:Label>
                    <br /><asp:Label ID="lblTelSo1" runat="server" Text=""></asp:Label>
                    <br /><asp:Label ID="lblLocSo1" runat="server" Text=""></asp:Label>
                    <br /><asp:Label ID="lblDesSo1" runat="server" Text=""></asp:Label>
                    <br /><asp:Label ID="lblApSo1" runat="server" Text=""></asp:Label>
                    <br /><asp:Label ID="lblCiSo1" runat="server" Text=""></asp:Label>
                    <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:ImageButton ID="btnProduct1" runat="server" ImageUrl="/Content/Dots.png" Height="24px" Width="24px" OnClick="btnProduct1_Click"/>
                </div>
            </div>
  
            <div class="item">
                <img src="/Content/Soda2.jpg"  height="242" width="289">
                <div class="carousel-caption">
                    <br /> <asp:Label ID="lblSoda2" runat="server" Text=""></asp:Label>
                    <br /> <asp:Label ID="lblTelSo2" runat="server" Text=""></asp:Label>
                    <br /> <asp:Label ID="lblLocSo2" runat="server" Text=""></asp:Label>
                    <br /> <asp:Label ID="lblDesSo2" runat="server" Text=""></asp:Label>
                    <br /> <asp:Label ID="lblApSo2" runat="server" Text=""></asp:Label>
                    <br /> <asp:Label ID="lblCiSo2" runat="server" Text=""></asp:Label>
                    <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label20" runat="server" Text=""></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:ImageButton ID="btnProduct2" runat="server" ImageUrl="/Content/Dots.png" Height="24px" Width="24px" OnClick="btnProduct2_Click"/>
                </div>
            </div>
        
            <div class="item"> 
                <img src="/Content/SodaTapia.jpg"  height="242" width="289">
                <div class="carousel-caption">
                    <br /> <asp:Label ID="lblSoda3" runat="server" Text=""></asp:Label>
                    <br /> <asp:Label ID="lblTelSo3" runat="server" Text=""></asp:Label>
                    <br /> <asp:Label ID="lblLocSo3" runat="server" Text=""></asp:Label>
                    <br /> <asp:Label ID="lblDesSo3" runat="server" Text=""></asp:Label>
                    <br /> <asp:Label ID="lblApSo3" runat="server" Text=""></asp:Label>
                    <br /> <asp:Label ID="lblCiSo3" runat="server" Text=""></asp:Label>
                    <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:ImageButton ID="btnProduct3" runat="server" ImageUrl="/Content/Dots.png" Height="24px" Width="24px" OnClick="btnProduct3_Click" />
                </div>
            </div>
        </div>

        <!-- Controls -->
        <a class="left carousel-control" href="#myCarousel" data-slide="prev">
            <span class="glyphicon glyphicon-chevron-left"></span>
            <span class="sr-only">Previous</span>
        </a>
        <a class="right carousel-control" href="#myCarousel" data-slide="next">
            <span class="glyphicon glyphicon-chevron-right"></span>
            <span class="sr-only">Next</span>
        </a>
    </div>
    <h2>

    </h2>
    <div class="display">
        <div style="display: table-row; height: 502px; width: 1626px;">
                <div style="width: 290px; display: inline-block; margin:10px; padding:10px; padding-left:20px; background-color: white"> 
                    <asp:ImageButton ID="btnSoda1" runat="server" ImageUrl="/Content/Soda1.jpg" Width="251px" Height="181px" OnClientClick="window.open('Contact.aspx', 'Productos');" OnClick="btnSoda1_Click"  />
                    <br />
                    <br />                    
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;<asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="/Content/Dots.png" Height="24px" Width="24px" OnClick="btnProduct1_Click"/>
                    <br /><asp:Label ID="lblSodaDis1" runat="server" Text=""></asp:Label>
                    <br /><asp:Label ID="lblSodaDis2" runat="server" Text=""></asp:Label>
                    <br /><asp:Label ID="lblSodaDis3" runat="server" Text=""></asp:Label>
                    <br /><asp:Label ID="lblSodaDis4" runat="server" Text=""></asp:Label>
                    <br /><asp:Label ID="lblSodaDis5" runat="server" Text=""></asp:Label>
                    <br /><asp:Label ID="lblSodaDis6" runat="server" Text=""></asp:Label>
                </div>
                <div style="display: inline-block; width: 290px; margin:10px;padding:10px; padding-left:20px; background-color: white">
                    &nbsp;<asp:ImageButton ID="btnSoda2" runat="server" ImageUrl="/Content/Soda2.jpg" Height="181px" Width="251px" OnClientClick="window.open('Contact.aspx', 'Productos');" OnClick="btnSoda2_Click" />
                    <br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="/Content/Dots.png" Height="24px" Width="24px" OnClick="btnProduct2_Click"/>
                    <br /> <asp:Label ID="lblSodaDis7" runat="server" Text=""></asp:Label>
                    <br /> <asp:Label ID="lblSodaDis8" runat="server" Text=""></asp:Label>
                    <br /> <asp:Label ID="lblSodaDis9" runat="server" Text=""></asp:Label>
                    <br /> <asp:Label ID="lblSodaDis10" runat="server" Text=""></asp:Label>
                    <br /> <asp:Label ID="lblSodaDis11" runat="server" Text=""></asp:Label>
                    <br /> <asp:Label ID="lblSodaDis12" runat="server" Text=""></asp:Label>
                </div>
                <div style="display: inline-block;width: 290px; margin:10px; padding:10px; padding-left:20px; background-color: white">
                    &nbsp;<asp:ImageButton ID="btnSoda3" runat="server" ImageUrl="/Content/SodaTapia.jpg" Height="181px" Width="251px" OnClick="btnSoda3_Click" OnClientClick="window.open('Contact.aspx', 'Productos')" />
                    <br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:ImageButton ID="ImageButton6" runat="server" ImageUrl="/Content/Dots.png" Height="24px" Width="24px" OnClick="btnProduct3_Click" />
                    <br /> <asp:Label ID="lblSodaDis13" runat="server" Text=""></asp:Label>
                    <br /> <asp:Label ID="lblSodaDis14" runat="server" Text=""></asp:Label>
                    <br /> <asp:Label ID="lblSodaDis15" runat="server" Text=""></asp:Label>
                    <br /> <asp:Label ID="lblSodaDis16" runat="server" Text=""></asp:Label>
                    <br /> <asp:Label ID="lblSodaDis17" runat="server" Text=""></asp:Label>
                    <br /> <asp:Label ID="lblSodaDis18" runat="server" Text=""></asp:Label>
                </div>
            </div>
    </div>

    <div class="row" style="color:white">
        <div class="col-md-4">
            <h2>Como usar</h2>
            <p>
                Dependiendo de lo necesitado puedes acceder a diferentes opciones:
                                
            </p>
            <p>
                En la parte superior tienes el botón home el cual te permite volver a inicio de el menú.
                
            </p>
            <p>
                Siguiente a él tienes un acceso a la parte de productos, donde podrá mirar todos los productos estrella de cada soda o una vista de productos de cada soda al hacer acción en la imagen de la soda.                
            </p>
            <p>
                También cuentas con un boton de acceso a carrito donde podras visualizar todo lo realcionado con tu pedido..</p>
            <p>
                En cada soda cuentas con una acción de 3 puntos los cuales te brindarán un pre-view de los productos pertenecientes a esta en la parte derecha de la pagina.</p>
        </div>
    </div>

</asp:Content>

<asp:Content ID="ContentMenu" ContentPlaceHolderID="ContentMenu" runat="server">
    <div class="container" style="float:right; width:150px; background-color:rgba(0,0, 0, 0.3); height: 732px;padding-top:10px">
            <div  style="height:75px;background-color:black;">
            <br />
&nbsp;
                <asp:Label ID="Label1" runat="server" Font-Size="Medium" ForeColor="White" Text="Hola:"></asp:Label>
&nbsp;<asp:Label ID="Nombre" runat="server" ForeColor="White" Font-Size="Medium"></asp:Label>          
            </div>
            <ul></ul>
            <div style="height:300px;background-color:black; color:white">

                <asp:GridView ID="GridView1" runat="server" Width="130px" AutoGenerateColumns="false">
                    <columns>
                        <asp:BoundField HeaderText="Productos" DataField="Nombre" /> 
                    </columns>
                </asp:GridView>

            </div>
        </div>
</asp:Content>

