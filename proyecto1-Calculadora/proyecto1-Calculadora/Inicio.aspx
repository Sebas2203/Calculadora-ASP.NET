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
                <asp:Button ID="btnSqur" runat="server" Text="√" Height="40px" Width="40px" />
                <asp:Button ID="Button2" runat="server" Text="C" Height="40px" Width="40px" />
                <asp:Button ID="Button3" runat="server" Text="⌫" Height="40px" Width="40px" />
                <asp:Button ID="Button4" runat="server" Text="n!" Height="40px" Width="40px" />
                <asp:Button ID="btnDivision" runat="server" Text="÷" Height="40px" Width="40px" />
                <br />
                <asp:Button ID="Button6" runat="server" Text="xy" Height="40px" Width="40px" />
                <asp:Button ID="btnSeven" runat="server" Text="7" Height="40px" Width="40px" />
                <asp:Button ID="btnEight" runat="server" Text="8" Height="40px" Width="40px" />
                <asp:Button ID="btnNine" runat="server" Text="9" Height="40px" Width="40px"  />
                <asp:Button ID="btnMultiplication" runat="server" Text="x" Height="40px" Width="40px" />
                <br />
                <asp:Button ID="Button11" runat="server" Text="10^" Height="40px" Width="40px" />
                <asp:Button ID="btnFour" runat="server" Text="4" Height="40px" Width="40px"  />
                <asp:Button ID="btnFive" runat="server" Text="5" Height="40px" Width="40px" />
                <asp:Button ID="btnSix" runat="server" Text="6" Height="40px" Width="40px" />
                <asp:Button ID="btnSubtraction" runat="server" Text="-" Height="40px" Width="40px" />
                <br />
                <asp:Button ID="Button16" runat="server" Text="log" Height="40px" Width="40px" />
                <asp:Button ID="btnOne" runat="server" Text="1" Height="40px" Width="40px" />
                <asp:Button ID="btnTwo" runat="server" Text="2" Height="40px" Width="40px"  />
                <asp:Button ID="btnThree" runat="server" Text="3" Height="40px" Width="40px" />
                <asp:Button ID="btnAddition" runat="server" Text="+" Height="40px" Width="40px" />
                <br />
                <asp:Button ID="Button21" runat="server" Text="x²" Height="40px" Width="40px" />
                <asp:Button ID="Button22" runat="server" Text="+/-" Height="40px" Width="40px" />
                <asp:Button ID="btnZero" runat="server" Text="0" Height="40px" Width="40px" />
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
