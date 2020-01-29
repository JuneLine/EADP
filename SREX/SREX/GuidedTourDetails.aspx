<%@ Page Title="Tour Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GuidedTourDetails.aspx.cs" Inherits="SREX.GuidedTourDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Guide.css" rel="stylesheet" />
    <div class="container-fluid">
        <div class="row body-container-own">
            <br />
            <asp:DataList runat="server" ID="DataListNameOnly" RepeatLayout="Flow">
                <ItemTemplate>
                    <div class="well text-center">
                        <h2><b><%#Eval("tourName")%></b></h2>
                    </div>
                    <div style="font-size: large;">
                        <div class="col-sm-4" style="margin-bottom: 1%;">
                            MeetUp: <b><%#Eval("meetUpTime") %></b> at <b><%#Eval("meetUpLocation")%></b><br />
                        </div>
                        <div class="col-sm-8">
                            Date Of Tour: <%#Eval("Date") %>
                        </div>
                        <div class="col-sm-12" style="margin-bottom: 1%;">
                            Estimated Cost: Adult: SGD<b><%#Eval("AdultCost") %></b>, Children: SGD<b><%#Eval("ChildCost") %></b>, Senior Citizens: SGD<b><%#Eval("SeniorCost") %></b>(Per Pax) 
                        </div>
                    </div>
                </ItemTemplate>
            </asp:DataList>

            <h3>Day Schedule</h3>
            <asp:DataList ID="DataListInfo" runat="server" RepeatLayout="Table" CssClass="table table-bordered">
                <ItemTemplate>
                    <tr>
                        <th class="col-sm-3 text-center">Time</th>
                        <th class="col-sm-9 text-center">Activity</th>
                    </tr>
                    <tr>
                        <td class="col-sm-3 text-center"><%# Eval("Time1") %></td>
                        <td class="col-sm-9 text-center"><%# Eval("Activity1") %></td>
                    </tr>
                    <tr>
                        <td class="col-sm-3 text-center"><%# Eval("Time2") %></td>
                        <td class="col-sm-9 text-center"><%# Eval("Activity2") %></td>
                    </tr>
                    <tr>
                        <td class="col-sm-3 text-center"><%# Eval("Time3") %></td>
                        <td class="col-sm-9 text-center"><%# Eval("Activity3") %></td>
                    </tr>
                    <tr>
                        <td class="col-sm-3 text-center"><%# Eval("Time4") %></td>
                        <td class="col-sm-9 text-center"><%# Eval("Activity4") %></td>
                    </tr>
                    <tr>
                        <td class="col-sm-3 text-center"><%# Eval("Time5") %></td>
                        <td class="col-sm-9 text-center"><%# Eval("Activity5") %></td>
                    </tr>
                    <tr>
                        <td class="col-sm-3 text-center"><%# Eval("Time6") %></td>
                        <td class="col-sm-9 text-center"><%# Eval("Activity6") %></td>
                    </tr>
                    <tr>
                        <td class="col-sm-3 text-center"><%# Eval("Time7") %></td>
                        <td class="col-sm-9 text-center"><%# Eval("Activity7") %></td>
                    </tr>
                </ItemTemplate>
            </asp:DataList>
            <div style="text-align: center">
                <asp:Button ID="BtnPurchaseTicks" runat="server" CssClass="btn btn-primary" OnClick="BtnPurchaseTicks_Click" Text="Buy" />
            </div>
        </div>
    </div>
</asp:Content>


