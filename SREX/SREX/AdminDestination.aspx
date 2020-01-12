<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminDestination.aspx.cs" Inherits="SREX.AdminDestination" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
            <div class="page-header well">
                <h1 class="text-center">Add/ edit destinations</h1>
            </div>
    </div>
    <br />
    <br />
        <div class="row">
            <div class="col-sm-12">
                <asp:Label ID="LabelError" runat="server" Text=""></asp:Label>
                <div class="panel panel-info" style="width: 100%">
                    <div class="panel-heading">
                        <h3 class="panel-title">Add new destination</h3>
                    </div>
                    <div class="panel-body">
                        <div class="form-group">
                            <asp:Label ID="lbDestination" runat="server" Text="Destination:"></asp:Label>
                            <asp:TextBox ID="TbDestination" runat="server" CssClass="form-control" ></asp:TextBox>
                            <asp:Label ID="LbPictureLocation" runat="server" Text="Picture:"></asp:Label>
                            <div class="custom-file">
                                <asp:FileUpload runat="server" CssClass="custom-file-input" ID="FileLocation" />
                            </div>
                            <asp:Label ID="LabelDescription" runat="server" Text="Description:"></asp:Label>
                            <asp:TextBox ID="TbDescription" runat="server" CssClass="form-control" ></asp:TextBox>
                            <asp:Label ID="LbPrice" runat="server" Text="Price:"></asp:Label>
                            <asp:TextBox ID="TbPrice" runat="server" CssClass="form-control" ></asp:TextBox>
                            <asp:Label ID="LbTag" runat="server" Text="Tag:"></asp:Label>
                            <asp:TextBox ID="TbTag" runat="server" CssClass="form-control" ></asp:TextBox>
                        </div>
                        <asp:Button ID="BtnInsertDestination" runat="server" CssClass="btn btn-default" Text="Insert" style="float:right;" OnClick="BtnInsertDestination_Click"/>

                    </div>
                </div>
                <br />
                <div class="panel panel-info" style="width: 100%">
                    <div class="panel-heading">
                        <h3 class="panel-title">Existing destinations</h3>
                    </div>
                    <div class="panel-body">
                        <asp:GridView ID="GvTD" runat="server" AutoGenerateColumns="False" Height="120px" Width="100%" CssClass="table table-striped" OnSelectedIndexChanged="GvTD_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="uniqueId" HeaderText="Id" />
                        <asp:BoundField DataField="destinationName" HeaderText="Name" />
                        <asp:BoundField DataField="pictureName" HeaderText="Name" />
                        <asp:BoundField DataField="description" HeaderText="Description"/>
                        <asp:BoundField DataField="price" HeaderText="Price"/>
                        <asp:BoundField DataField="tag" HeaderText="Tag"/>
                        <asp:CommandField ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    <br />
    <br />
    <br />
</asp:Content>
