<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditAttraction.aspx.cs" Inherits="SREX.EditAttraction" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Guide.css" rel="stylesheet" />
    <br />
    <div class="body-container-own">
        <div class="well text-center">
            <h2><b>Edit Tour</b></h2>
        </div>
        <div class="container" style="padding: 5%;">
            <fieldset>
                <div class="col-sm-5">
                    <div class="form-group">
                        <label for="AttractionName">Name: </label>
                        <asp:TextBox runat="server" ID="AttractionName" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="row">                      
                        <div class="col-sm-8">
                            <label for="AttractionPicture">Picture: </label>
                            <asp:FileUpload runat="server" ID="AttractionPicture" CssClass="form-control"/>
                        </div>
                        <div class="col-sm-4">
                            <br />
                            <asp:Button runat="server" ID="ChangePicture" OnClick="ChangePicture_Click" CssClass="btn btn-primary" Text="Upload"/>
                        </div>
                    </div>
                    <br />
                    <div class="form-group">
                        <label for="AttractionURL">Website URL: </label>
                        <asp:TextBox runat="server" ID="AttractionsURL" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="AttractionDescription">Description: </label>
                        <asp:TextBox runat="server" ID="AttractionDescription" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="col-sm-7">
                    <asp:Image runat="server" ID="AttractionImage" Height="300px" Width="550px"/>
                </div>
            </fieldset>
        </div>
        <br />
        <div style="text-align: center">
            <asp:Button runat="server" Text="Confirm" CssClass="btn btn-primary" ID="UpdateAttraction" OnClick="UpdateAttraction_Click"/>
        </div>
    </div>
</asp:Content>
