 <%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SREX.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container" style="margin-top: 5%;margin-bottom:10%;">
        <div class="row">
            <div class="col-md-6 col-md-offset-3">
                <div class="panel panel-login">
                    <div class="panel-heading">
                        <div class="row">
                            <div class="col-xs-6">
                                <a href="#" class="active" id="login-form-link">Login</a>
                            </div>
                            <div class="col-xs-6">
                                <a href="#" id="register-form-link">Register</a>
                            </div>
                        </div>
                        <hr>
                    </div>
                    <div class="text-center" id="hideInfo">
                        <asp:Label ID="showInfo" runat="server"></asp:Label>
                    </div>
                    <div class="panel-body">
                        <div class="row">
                            <div class="col-lg-12">
                                <div id="login-form">
                                    <div role="form" style="display: block;">
                                        <div class="form-group">
                                            <asp:TextBox runat="server" TabIndex="1" CssClass="form-control" placeholder="Email" ID="Email" />
                                        </div>
                                        <div class="form-group">
                                            <asp:TextBox runat="server" TabIndex="2" CssClass="form-control" placeholder="Password" ID="loginPassword" />
                                        </div>
                                        <div class="form-group text-center">
                                            <asp:CheckBox runat="server" TabIndex="3" ID="remember" />
                                            <label for="remember">Remember Me</label>
                                        </div>
                                        <div class="form-group">
                                            <div class="row">
                                                <div class="col-sm-6 col-sm-offset-3">
                                                    <asp:Button Text="Login" ID="btnnLogin" runat="server" TabIndex="4" CssClass="form-control btn btn-login" OnClick="btnnLogin_Click"/>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <div class="row">
                                                <div class="col-lg-12">
                                                    <div class="text-center">
                                                        <a href="https://phpoll.com/recover" tabindex="5" class="forgot-password">Forgot Password?</a>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                                <div id="register-form" role="form" style="display: none;">
                                    <div class="form-group">
                                        <asp:TextBox runat="server" TabIndex="1" ID="registerUsername" CssClass="form-control" placeholder="Username" />
                                    </div>
                                    <div class="form-group">
                                        <asp:TextBox runat="server" TabIndex="1" ID="emailAddress" Type="email" CssClass="form-control" placeholder="Email Address" />
                                    </div>
                                    <div class="form-group">
                                        <asp:DropDownList ID="ddlGender" runat="server" TabIndex="1" CssClass="form-control" placeholder="Gender">
                                            <asp:ListItem>Male</asp:ListItem>
                                            <asp:ListItem>Female</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="form-group">
                                        <asp:TextBox runat="server" TabIndex="1" CssClass="form-control" placeholder="Passport ID" ID="passportId" />
                                    </div>
                                    <div class="form-group">
                                        <asp:TextBox runat="server" TabIndex="1" CssClass="form-control" Type="Date" placeholder="Date of Birth" ID="dob"/>
                                    </div>
                                    <div class="form-group">
                                        <asp:TextBox runat="server" TabIndex="2" CssClass="form-control" placeholder="Password" ID="registerPassword" TextMode="Password"/>
                                    </div>
                                    <div class="form-group">
                                        <asp:TextBox runat="server" TabIndex="2" CssClass="form-control" placeholder="Confirm Password" ID="confirmPassowrd" TextMode="Password" />
                                    </div>
                                    <div class="form-group">
                                        <div class="row">
                                            <div class="col-sm-6 col-sm-offset-3">
                                                <asp:Button Text="Register Now" ID="registerSubmit" runat="server" TabIndex="4" CssClass="form-control btn btn-register" OnClick="registerSubmit_Click" />
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
