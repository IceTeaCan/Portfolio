<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GUI.aspx.cs" Inherits="WebClient.GUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style =" background-color:black">
    <form id="form1" runat="server">
        <div style="color:white">
            ID :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:TextBox ID="tb_ID" runat="server" style="margin-left: 0px" ForeColor="Black"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_Action" runat="server" OnClick="Button1_Click" Text="Consultar" />
        </div>
        <p style="color:white">
            LogID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="tb_Login" runat="server" style="margin-left: 0px" ForeColor="Black"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;</p>
        <p style="color:white">
            &nbsp;Tipo de trabajo:&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="tb_JobTitle" runat="server" style="margin-left: 0px" ForeColor="Black"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;</p>
        <p style="color:white">
            &nbsp; Fecha de cumpleaños: &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tb_BirthDate" runat="server" style="margin-left: 0px" ForeColor="Black"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;</p>
        <p style="color:white">
            Estado civil:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tb_MaritalStatus" runat="server" style="margin-left: 0px" ForeColor="Black"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;</p>
        <p style="color:white">
            Género:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tb_Gender" runat="server" style="margin-left: 0px" ForeColor="Black"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;</p>
        <p style="color:white">
            <asp:Label ID="lbl_Salida" runat="server" ForeColor="White" Text="&lt;&gt;"></asp:Label>
        </p>
        <asp:Label ID="lbl_Out" runat="server" ForeColor="White" Text=" "></asp:Label>
    </form>
</body>
</html>
