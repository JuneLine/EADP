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
            float:right;
            right:5%;
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
                    <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" ErrorMessage="Invalid Email!" ControlToValidate="tbEmail"></asp:RegularExpressionValidator>
                </div>
                <br />
                <div id="codebox" style="display: none" runat="server">
                    <label for="tbCode" style="margin-left: 5%;">Enter Code:</label>
                    <asp:TextBox ID="tbCode" runat="server" CssClass="form-control tbadjustment"></asp:TextBox>
                </div>                
                <asp:Label runat="server" CssClass="input-group lblRight"></asp:Label>
            </div>
            <div class="row">
                <asp:Button runat="server" ID="btnCfmEmail" CssClass="btn btn-success btnRight" Text="Confirm" OnClick="btnCfmEmail_Click" />
                <%--<asp:Button runat="server" ID="btnCfmCode"  CssClass="btn btn-success"/>--%>
            </div>
        </form>
    </div>
</body>
</html>
