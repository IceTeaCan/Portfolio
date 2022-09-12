<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Index.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 dir="ltr" style="color: white; font-family:'Copperplate Gothic'; background-color: transparent; width: 432px; margin-left:400px; height: 52px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Productos de pedido</h2>

    <div class="Productos Carrito">

        <div class="col-md-4" style="color:white">
           <h2 style="color: #ff0000">
               <asp:Label ID="lbl_Head1" runat="server" Text="#1" Visible="False"></asp:Label>
            </h2>
           <h2>
               <asp:ImageButton ID="img_btn_Prod1" runat="server" Height="162px" OnClick="ImageButton7_Click" Width="195px" Visible="False" />
               <asp:DropDownList ID="dl_Prod1" runat="server" BackColor="#FFFF99" ForeColor="Black" Height="35px" Width="102px" Visible="False" OnSelectedIndexChanged="dl_Prod1_SelectedIndexChanged">  
                    <asp:ListItem >Seleccione</asp:ListItem>
               </asp:DropDownList>
            </h2>
            <h2>
                <asp:Button ID="btn_Mod1" runat="server" Font-Size="Small" ForeColor="Black" OnClick="btn_Mod1_Click" Text="Modificar" Visible="False" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </h2>
           <h2>
               <asp:Label ID="Id_TacoPapas" runat="server" Text="Label" Visible="False"></asp:Label>
            </h2>
        </div>

        <div class="col-md-4" style="color:white">
           <h2 style="color:#ff0000">
               <asp:Label ID="lbl_Head2" runat="server" Text="#2" Visible="False"></asp:Label>
            </h2>
           <h2> 
               <asp:ImageButton ID="img_btn_Prod2" runat="server" Height="162px" OnClick="ImageButton8_Click" Width="195px" Visible="False" />
               <asp:DropDownList ID="dl_Prod2" runat="server" BackColor="#FFFF99" ForeColor="Black" Height="35px" Width="102px" Visible="False" OnSelectedIndexChanged="dl_Prod2_SelectedIndexChanged"> 
                   <asp:ListItem >Seleccione</asp:ListItem>
               </asp:DropDownList>
            </h2>
            <h2> 
                <asp:Button ID="btn_Mod2" runat="server" Font-Size="Small" ForeColor="Black" Text="Modificar" OnClick="btn_Mod2_Click" Visible="False" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </h2>
           <h2>
               <asp:Label ID="Id_AlasPollo" runat="server" Text="Label" Visible="False"></asp:Label>
            </h2>
        </div>

        <div class="table">
           <div style="display: table-cell; font-style:oblique;color:#ff0000">
            <h2>
                <asp:Label ID="lbl_Head3" runat="server" Text="#3" Visible="False"></asp:Label>
               </h2>
               <h2>
                   <asp:ImageButton ID="img_btn_Prod3" runat="server" Height="162px" OnClick="ImageButton9_Click" Width="195px" Visible="False" />
                   <asp:DropDownList ID="dl_Prod3" runat="server" BackColor="#FFFF99" ForeColor="Black" Height="35px" Width="102px" Visible="False" OnSelectedIndexChanged="dl_Prod3_SelectedIndexChanged"> 
                       <asp:ListItem>Seleccione</asp:ListItem>
                   </asp:DropDownList>
               </h2>
               <h2>
                   <asp:Button ID="btn_Mod3" runat="server" Font-Size="Small" ForeColor="Black" Text="Modificar" OnClick="btn_Mod3_Click" Visible="False" />
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   </h2>
           <h2 style="color:white">
               <asp:Label ID="Id_Chalupas" runat="server" Text="Label" Visible="False"></asp:Label>
               </h2>
           </div>
        </div>
   </div>

            <div class="Productos Carrito">

        <div class="col-md-4" style="color:white">
           <h2 style="color: #ff0000">
               <asp:Label ID="lbl_Head4" runat="server" Text="#4" Visible="False"></asp:Label>
            </h2>
           <h2>
               <asp:ImageButton ID="img_btn_Prod4" runat="server" Height="162px" OnClick="ImageButton10_Click" Width="195px" Visible="False" />
               <asp:DropDownList ID="dl_Prod4" runat="server" BackColor="#FFFF99" ForeColor="Black" Height="35px" Width="102px" Visible="False" OnSelectedIndexChanged="dl_Prod4_SelectedIndexChanged">  
                   <asp:ListItem >Seleccione</asp:ListItem>
               </asp:DropDownList>
            </h2>
            <h2>
                <asp:Button ID="btn_Mod4" runat="server" Font-Size="Small" ForeColor="Black" Text="Modificar" OnClick="btn_Mod4_Click" Visible="False" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                </h2>
           <h2>
               <asp:Label ID="Id_Lapiz" runat="server" Text="Label" Visible="False"></asp:Label>
            </h2>
        </div>

        <div class="col-md-4" style="color:white">
           <h2 style="color: #ff0000">
               <asp:Label ID="lbl_Head5" runat="server" Text="#5" Visible="False"></asp:Label>
            </h2>
           <h2> 
               <asp:ImageButton ID="img_btn_Prod5" runat="server" Height="162px" OnClick="ImageButton11_Click" Width="195px" Visible="False" />
               <asp:DropDownList ID="dl_Prod5" runat="server" BackColor="#FFFF99" ForeColor="Black" Height="35px" Width="102px" Visible="False" OnSelectedIndexChanged="dl_Prod5_SelectedIndexChanged">
                   <asp:ListItem >Seleccione</asp:ListItem>
               </asp:DropDownList>
            </h2>
            <h2> 
                <asp:Button ID="btn_Mod5" runat="server" Font-Size="Small" ForeColor="Black" Text="Modificar" OnClick="btn_Mod5_Click" Visible="False" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </h2>
           <h2>
               <asp:Label ID="Id_Hamburguesa" runat="server" Text="Label" Visible="False"></asp:Label>
            </h2>
        </div>

        <div class="table">
           <div style="display: table-cell; font-style:oblique;color:#ff0000">
            <h2>
                <asp:Label ID="lbl_Head6" runat="server" Text="#6" Visible="False"></asp:Label>
               </h2>
               <h2>
                   <asp:ImageButton ID="img_btn_Prod6" runat="server" Height="162px" OnClick="ImageButton12_Click" Width="195px" Visible="False" />
                   <asp:DropDownList ID="dl_Prod6" runat="server" BackColor="#FFFF99" ForeColor="Black" Height="35px" Width="102px" Visible="False" OnSelectedIndexChanged="dl_Prod6_SelectedIndexChanged">
                       <asp:ListItem >Seleccione</asp:ListItem>
                   </asp:DropDownList>
               </h2>
               <h2>
                   <asp:Button ID="btn_Mod6" runat="server" Font-Size="Small" ForeColor="Black" Text="Modificar" OnClick="btn_Mod6_Click" Visible="False" />
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   </h2>
           <h2 style="color:white">
               <asp:Label ID="Id_Doraditas" runat="server" Text="Label" Visible="False"></asp:Label>
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
                <asp:Label ID="Label1" runat="server" Font-Size="Large" ForeColor="White" Text="Total:"></asp:Label>
&nbsp;&nbsp;
                <asp:TextBox ID="txt_costototal" runat="server" Font-Size="X-Small"></asp:TextBox>
                
            </div>
            <ul></ul>
            <div style="height:476px; background-color:black;">

                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" BorderStyle="None" Font-Size="Large" ForeColor="White" Text="Descripción Pedido"></asp:Label>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:GridView ID="gridPedido" AutoGenerateColumns="false" runat="server" OnRowDeleting="gridPedido_RowDeleting" ForeColor="White">
                    <columns>
                        <asp:BoundField HeaderText="idContenido" DataField="IdContenido" /> 
                        <asp:BoundField HeaderText="Contenido" DataField="ContNomb" /> 
                        <asp:BoundField HeaderText="Cantidad" DataField="Cantidad" /> 
                    </columns>
                </asp:GridView>
                <br />
&nbsp;
                <br />
                <br />
&nbsp;
                <br />
                <br />
&nbsp;
                <br />
                <br />
&nbsp;

&nbsp;

&nbsp;

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Id_Pago" runat="server" BackColor="#66FF33" Font-Size="Large" Text="Pagar" OnClick="Id_Pago_Click" />

            </div>
        </div>
    </asp:Content>
