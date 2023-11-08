<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="proyecto1_Calculadora.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculadora</title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }

        </style>
    <link href="css/main.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 class="auto-style1">CALCULADORA </h1>
            <hr />
            <p class="auto-style1">&nbsp;</p>
            <p class="auto-style1">
                <strong>
                    <asp:TextBox ID="TextBox1" runat="server" Height="34px" Width="196px"></asp:TextBox>
                </strong>
            </p>
            <p class="auto-style1">
                <asp:Button ID="Button1" runat="server" Text="√" Height="40px" Width="40px" />
                <asp:Button ID="Button2" runat="server" Text="C" Height="40px" Width="40px" />
                <asp:Button ID="Button3" runat="server" Text="⌫" Height="40px" Width="40px" />
                <asp:Button ID="Button4" runat="server" Text="n!" Height="40px" Width="40px" />
                <asp:Button ID="Button5" runat="server" Text="÷" Height="40px" Width="40px" />
                <br />
                <asp:Button ID="Button6" runat="server" Text="xy" Height="40px" Width="40px" />
                <asp:Button ID="Button7" runat="server" Text="7" Height="40px" Width="40px" OnClick="Button7_Click" />
                <asp:Button ID="Button8" runat="server" Text="8" Height="40px" Width="40px" OnClick="Button8_Click" />
                <asp:Button ID="Button9" runat="server" Text="9" Height="40px" Width="40px" OnClick="Button9_Click" />
                <asp:Button ID="Button10" runat="server" Text="x" Height="40px" Width="40px" />
                <br />
                <asp:Button ID="Button11" runat="server" Text="10^" Height="40px" Width="40px" />
                <asp:Button ID="Button12" runat="server" Text="4" Height="40px" Width="40px" OnClick="Button12_Click" />
                <asp:Button ID="Button13" runat="server" Text="5" Height="40px" Width="40px" OnClick="Button13_Click" />
                <asp:Button ID="Button14" runat="server" Text="6" Height="40px" Width="40px" OnClick="Button14_Click" />
                <asp:Button ID="Button15" runat="server" Text="-" Height="40px" Width="40px" />
                <br />
                <asp:Button ID="Button16" runat="server" Text="log" Height="40px" Width="40px" />
                <asp:Button ID="Button17" runat="server" Text="1" Height="40px" Width="40px" />
                <asp:Button ID="Button18" runat="server" Text="2" Height="40px" Width="40px" OnClick="Button18_Click" />
                <asp:Button ID="Button19" runat="server" Text="3" Height="40px" Width="40px" OnClick="Button19_Click" />
                <asp:Button ID="Button20" runat="server" Text="+" Height="40px" Width="40px" />
                <br />
                <asp:Button ID="Button21" runat="server" Text="x²" Height="40px" Width="40px" />
                <asp:Button ID="Button22" runat="server" Text="+/-" Height="40px" Width="40px" />
                <asp:Button ID="Button23" runat="server" Text="0" Height="40px" Width="40px" />
                <asp:Button ID="Button24" runat="server" Text="," Height="40px" Width="40px" />
                <asp:Button ID="Button25" runat="server" Text="=" Height="40px" Width="40px" />


            </p>
        </div>
    </form>
</body>
<footer>
    <p class="auto-style1">Grupo 4</p>
</footer>
</html>
