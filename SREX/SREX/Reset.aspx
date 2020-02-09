<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reset.aspx.cs" Inherits="SREX.Reset" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Password Reset</title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/bootstrap-theme.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <link href="Content/core-style.css" rel="stylesheet" />
</head>
<body>
    <style>
        .btnRight {
            float: right;
            margin-bottom: 3%;
            margin-right: 3%;
        }

        .lblRight{
            float:left;
            left:5%;
        }

        .tbadjustment {
            width: 90%;
            margin: auto;
        }
    </style>
    <div class="well" style="height: 64%; width: 36%; margin: auto;">
        <div class="text-center">
            <asp:Image runat="server" ImageUrl="Profile.png" Height="20%" Width="20%" />
        </div>
        <div class="text-center">
            <label>SREX</label>
        </div>

        <form runat="server">
            <div class="row" style="margin-bottom: 40%;">
                <div id="emailbox" runat="server">
                    <label for="tbEmail" style="margin-left: 5%;" class="control-label">Enter Email:</label>
                    <asp:TextBox ID="tbEmail" runat="server" CssClass="form-control tbadjustment"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server" ErrorMessage="Required" ForeColor="Red" ControlToValidate="tbEmail" Display="None"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" ErrorMessage="Invalid Email!" ForeColor="Red" ControlToValidate="tbEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="None"></asp:RegularExpressionValidator>
                </div>
                <br />
                <div id="codebox" runat="server" visible="false">
                    <label for="tbCode" style="margin-left: 5%;">Enter Code:</label>
                    <asp:TextBox ID="tbCode" runat="server" CssClass="form-control tbadjustment"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorCode" runat="server" ErrorMessage="Invalid Code!" ForeColor="Red" ControlToValidate="tbCode" Enabled="false" Display="None"></asp:RequiredFieldValidator>
                </div>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="BulletList" ForeColor="Red" CssClass="input-group lblRight"/>
            </div>
            <div class="row">
                <asp:Button runat="server" ID="btnCfmEmail" CssClass="btn btn-success btnRight" Text="Confirm" OnClick="btnCfmEmail_Click" />
                <%--<asp:Button runat="server" ID="btnCfmCode"  CssClass="btn btn-success"/>--%>
            </div>
        </form>
    </div>
</body>
</html>
