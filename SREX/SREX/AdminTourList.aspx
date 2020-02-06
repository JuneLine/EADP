<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminTourList.aspx.cs" Inherits="SREX.AdminTourList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="body-container-own">
        <br />
        <div class="well text-center">
            <h2>List Of Tour</h2>
        </div>
        <div class="container">
            <div class="input-group col-sm-12 col-lg-12">
                <asp:TextBox ID="SearchTour" class="form-control" placeholder="Search For Tour Name" runat="server"></asp:TextBox>
                <span class="input-group-btn">
                    <asp:Button ID="ButtonSearchName" runat="server" class="btn btn-default" Text="Search" OnClick="ButtonSearchName_Click"/>
                </span>
            </div>
            <br />
            <asp:DataList runat="server" ID="dlListofTour" RepeatLayout="Table" CssClass="table table-hover">
                <HeaderTemplate>
                    <th>Name</th>
                    <th>Contact</th>
                    <th>Email</th>
                    <th>Date Bought</th>
                    <th>Tickets Bought</th>
                    <th>Tour Joined</th>
                </HeaderTemplate>
                <ItemTemplate>
                    <td><%#Eval("UserName") %></td>
                    <td><%#Eval("UserContact") %></td>
                    <td><%#Eval("UserEmail") %></td>
                    <td><%#Eval("Date") %></td>
                    <td><%#Eval("AdultQuantity")%> Adults, <%#Eval("ChildQuantity")%> Child, <%#Eval("SeniorQuantity")%> Senior</td>
                    <td><%#Eval("tourName") %></td>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </div>
</asp:Content>
