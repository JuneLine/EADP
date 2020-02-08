<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminApplication.aspx.cs" Inherits="SREX.AdminApplication" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <nav class="navbar navbar-inverse bg-light" style="margin-bottom:0px;">
        <a class="navbar-brand active" href="AdminApplication">View current tour guide applications</a>
        <a class="navbar-brand" href="existingTourGuides">View existing tour guides</a>
    </nav>
    <div class="jumbotron" style="margin: 0px;">
                <h1 class="text-center">Tour guide applications</h1>
        <p class="lead text-center">Here are the tour guides that are currently under review</p>
    </div>
    <div id="confirmModal" class="modal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel2" runat="server" visible="false" style="display:block;">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel2">Confirmation</h5>
                </div>
                <div class="modal-body">
                    Please review the applicant by viewing his/her resume down below
                    <br />
                    <asp:Label for="LabelName" runat="server" Text="Username: "></asp:Label> <asp:Label ID="LabelName" runat="server"></asp:Label>
                    <br />
                    <asp:Label for="LabelUniqueId" runat="server" Text="ID: "></asp:Label> <asp:Label ID="LabelUniqueId" runat="server"></asp:Label>
                    <br />
                    <asp:Label for="LabelEmailAddr" runat="server" Text="Email: "></asp:Label> <asp:Label ID="LabelEmailAddr" runat="server"></asp:Label>
                    <br />
                    <asp:Label for="LabelResumePath" runat="server" Text="FileName: "></asp:Label>
                    <asp:Label ID="LabelResumePath" runat="server" Visible="true"></asp:Label>
                    <br />
                    <label>Resume: </label>
                    <br />
                    <asp:Button runat="server" ID="downloadResume" CssClass="btn btn-primary" Text="Download" OnClick="downloadResume_Click"/>
                </div>
                <div class="modal-footer">
                    <asp:Button runat="server"  ID="Close" CssClass="btn btn-seconday" Text="Close" OnClick="Close_Click" />
                    <asp:Button runat="server"  ID="Deny" CssClass="btn btn-danger" Text="Decline" OnClick="Deny_Click"/>
                    <asp:Button runat="server" ID="ConfirmApplication" CssClass="btn btn-primary" Text="Confirm" OnClick="ConfirmApplication_Click"/>
                </div>
            </div>
        </div>
    </div>

    <div class="col-sm-12 col-lg-12 text-center" style="padding:2%;" runat="server">
        <asp:GridView ID="GvTD" runat="server" AutoGenerateColumns="False" Height="120px" Width="100%" CssClass="table table-striped" OnSelectedIndexChanged="GvTD_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="UniqueId" HeaderText="ID"/>
                        <asp:BoundField DataField="UserName" HeaderText="Username"/>
                        <asp:BoundField DataField="Gender" HeaderText="Gender" />
                        <asp:BoundField DataField="EmailAddr" HeaderText="EmailAddr"/>
                        <asp:BoundField DataField="UploadFile" visible="true" HeaderText="File Name"/>
                        <asp:CommandField ShowSelectButton="True" SelectText="View" />
                    </Columns>
                </asp:GridView>
     </div>
    <asp:Label class="text-centered" ID="LabelConfirm" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
