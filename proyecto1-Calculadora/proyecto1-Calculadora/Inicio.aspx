<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="proyecto1_Calculadora.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculadora Grupo 4</title>
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
            <h1 class="auto-style1">CALCULADORA GRUPO 4</h1>
            <hr />
            <p class="auto-style1">&nbsp;</p>
            <p class="auto-style1">
                <strong>
                    <asp:TextBox ID="TextBox1" runat="server" Height="34px" Width="196px"></asp:TextBox>
                </strong>
            </p>
            <p class="auto-style1">
                <asp:Button ID="btnSqur" runat="server" Text="√" Height="40px" Width="40px" OnClick="btnSqur_Click" />
                <asp:Button ID="btnClear" runat="server" Text="C" Height="40px" Width="40px" OnClick="btnClear_Click" />
                <asp:Button ID="btnBackSpace" runat="server" Text="⌫" Height="40px" Width="40px" OnClick="btnBackSpace_Click" />
                <asp:Button ID="btnFactorial" runat="server" Text="n!" Height="40px" Width="40px" OnClick="btnFactorial_Click" />
                <asp:Button ID="btnDivision" runat="server" Text="÷" Height="40px" Width="40px" OnClick="btnDivision_Click" />
                <br />
                <asp:Button ID="Button6" runat="server" Text="xy" Height="40px" Width="40px" OnClick="Button6_Click" />
                <asp:Button ID="btnSeven" runat="server" Text="7" Height="40px" Width="40px" OnClick="btnSeven_Click" />
                <asp:Button ID="btnEight" runat="server" Text="8" Height="40px" Width="40px" OnClick="btnEight_Click" />
                <asp:Button ID="btnNine" runat="server" Text="9" Height="40px" Width="40px" OnClick="btnNine_Click" />
                <asp:Button ID="btnMultiplication" runat="server" Text="x" Height="40px" Width="40px" OnClick="btnMultiplication_Click" />
                <br />
                <asp:Button ID="Button11" runat="server" Text="10^" Height="40px" Width="40px" OnClick="Button11_Click" />
                <asp:Button ID="btnFour" runat="server" Text="4" Height="40px" Width="40px" OnClick="btnFour_Click" />
                <asp:Button ID="btnFive" runat="server" Text="5" Height="40px" Width="40px" OnClick="btnFive_Click" />
                <asp:Button ID="btnSix" runat="server" Text="6" Height="40px" Width="40px" OnClick="btnSix_Click" />
                <asp:Button ID="btnSubtraction" runat="server" Text="-" Height="40px" Width="40px" OnClick="btnSubtraction_Click" />
                <br />
                <asp:Button ID="btnLog" runat="server" Text="log" Height="40px" Width="40px" OnClick="btnLog_Click" />
                <asp:Button ID="btnOne" runat="server" Text="1" Height="40px" Width="40px" OnClick="btnOne_Click1" />
                <asp:Button ID="btnTwo" runat="server" Text="2" Height="40px" Width="40px" OnClick="btnTwo_Click" />
                <asp:Button ID="btnThree" runat="server" Text="3" Height="40px" Width="40px" OnClick="btnThree_Click" />
                <asp:Button ID="btnAddition" runat="server" Text="+" Height="40px" Width="40px" OnClick="btnAddition_Click" />
                <br />
                <asp:Button ID="btnPow" runat="server" Text="x²" Height="40px" Width="40px" OnClick="btnPow_Click" />
                <asp:Button ID="btnPositiveNegative" runat="server" Text="+/-" Height="40px" Width="40px" OnClick="btnPositiveNegative_Click" />
                <asp:Button ID="btnZero" runat="server" Text="0" Height="40px" Width="40px" OnClick="btnZero_Click" />
                <asp:Button ID="btnComaDecimal" runat="server" Text="," Height="40px" Width="40px" OnClick="btnComaDecimal_Click" />
                <asp:Button ID="btnEqual" runat="server" Text="=" Height="40px" Width="40px" OnClick="btnEqual_Click" />
            </p>
            <br />
            <hr />
            <p>Estudiantes:</p>
            <ul>
                <li>Sebastian Mora Rodríguez</li>
                <li>Andrey Josue Murillo Badilla</li>
                <li>Karla Rodríguez Valverde</li>
                <li>Ileana Lizeth Romero Gonzalez</li>
            </ul>
        </div>
    </form>
</body>
</html>
