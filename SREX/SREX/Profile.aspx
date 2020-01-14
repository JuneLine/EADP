<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="SREX.Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <div class="row">
            <div class="col-lg-4 col-md-12 col-sm-6">
                <div>
                    <img src="https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_960_720.png" style="height: 90%; width: 90%;" />
                </div>
                <div>
                </div>
            </div>
            <div class="col-lg-8 col-md-12 col-sm-12">
                <table style="margin-top: 10%; margin-left: 20%; font-size: 1.5em;">
                    <tr>
                        <td style="font-weight: bold;">Name:
                        </td>
                        <td>&nbsp Marcus Chua
                        </td>
                    </tr>
                    <tr>
                        <td style="font-weight: bold;">Email:
                        </td>
                        <td>&nbsp HackerGod123@gmail.com
                        </td>
                    </tr>
                    <tr>
                        <td style="font-weight: bold;">Date Of Birth:
                        </td>
                        <td>&nbsp 06/08/2001
                        </td>
                    </tr>
                    <tr>
                        <td style="font-weight: bold;">Passport Number:
                        </td>
                        <td>&nbsp K0123456E
                        </td>
                    </tr>
                    <tr>
                        <td style="padding-top: 5%;">
                            <input type="button" class="btn btn-primary" value="Change Email" data-toggle="modal" data-target="#ChangeEmail" />
                        </td>
                        <td style="padding-top: 5%;">
                            <input type="button" class="btn btn-primary" value="Change Password" data-toggle="modal" data-target="#ChangePassword" />
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
    <div class="modal fade" id="ChangeEmail" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" style="margin-top: 10%;" role="document">
            <div class="modal-content form">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                    <h3 class="modal-title" id="exampleModalLabel">Change Email</h3>
                </div>
                <div class="modal-body" style="width: 80%; margin: auto;">
                    <div class="form-group">
                        <label for="tbOldEmail">Old Email Name: </label>
                        <asp:TextBox runat="server" ID="tbOldEmail" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="tbNewEmail">New Email Name: </label>
                        <asp:TextBox runat="server" ID="tbNewEmail" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="tbConfirmNewEmail">Confirm New Email Name: </label>
                        <asp:TextBox runat="server" ID="tbConfirmNewEmail" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                    <asp:Button runat="server" ID="ConfirmChangeEmail" Text="Confirm" CssClass="btn btn-primary" />
                </div>
            </div>
        </div>
    </div>

    <div class="modal fade" id="ChangePassword" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" style="margin-top: 10%;" role="document">
            <div class="modal-content form">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                    <h3 class="modal-title">Change Password</h3>
                </div>
                <div class="modal-body" style="width: 80%; margin: auto;">
                    <div class="form-group">
                        <label for="tbOldPW">Old Password: </label>
                        <asp:TextBox runat="server" ID="tbOldPW" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="tbNewPW">New Password: </label>
                        <asp:TextBox runat="server" ID="tbNewPW" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="tbConfirmNewPW">Confirm New Password: </label>
                        <asp:TextBox runat="server" ID="tbConfirmNewPW" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                    <asp:Button runat="server" ID="Button1" Text="Confirm" CssClass="btn btn-primary" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
