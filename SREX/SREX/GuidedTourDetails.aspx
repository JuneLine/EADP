<%@ Page Title="Tour Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GuidedTourDetails.aspx.cs" Inherits="SREX.GuidedTourDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Guide.css" rel="stylesheet" />
    <div class="container-fluid">
        <div class="row body-container-own">
            <br />
            <div class="row">
                <asp:DataList runat="server" ID="DataListNameOnly" RepeatLayout="Flow">
                    <ItemTemplate>
                        <div class="well text-center">
                            <h2><b><%#Eval("tourName")%></b></h2>
                        </div>
                        <div style="font-size: large;">
                            <div class="col-sm-5 well">
                                <asp:Image runat="server" ImageUrl='<%# String.Format("Pictures/{0}", Eval("tourPic") ) %>' Height="250px" Width="800px" />
                            </div>                            
                            <div class="col-sm-7" style="margin-top:1%;">                                
                                <table>
                                    <tr>
                                        <td class="col-sm-4">MeetUp: </td>
                                        <td><h3><b><%#Eval("meetUpTime") %></b> at <b><%#Eval("meetUpLocation")%></b></h3></td>                                        
                                    </tr>                                    
                                    <tr>
                                        <td class="col-sm-4">Date Of Tour:</td>
                                        <td><h3> <b><%#Eval("Date") %></b></h3></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-4">Tickets Left:</td>
                                        <td><h3><b> <%#Eval("Limit") %> </b></h3></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-4">Cost: <br />(Per Pax ++)</td>
                                        <td>
                                            <br />
                                            <table class="table">
                                                <tr>
                                                    <td>Adult: </td>
                                                    <td><h3>SGD<b><%#Eval("AdultCost") %></b></h3></td>
                                                </tr>
                                                <tr>
                                                    <td>Children: </td>
                                                    <td><h3>SGD<b><%#Eval("ChildCost") %></b></h3></td>
                                                </tr>
                                                <tr>
                                                    <td>Senior Citizens:</td>
                                                    <td><h3>SGD<b><%#Eval("SeniorCost") %></b></h3></td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>                                                                                              
                            </div>
                        </div>
                        <%--<br /><h3> Adult: SGD<b><%#Eval("AdultCost") %></b>,<br /> Children: SGD<b><%#Eval("ChildCost") %></b>,<br /> Senior Citizens: SGD<b><%#Eval("SeniorCost") %></b></h3>--%>
                    </ItemTemplate>
                </asp:DataList>
            </div>
            <br />
            <div class="row">
                <h2><span class="input-lg"><b>Day Schedule</b></span><asp:Button runat="server" ID="EditTour" OnClick="EditTour_Click" CssClass="btn btn-secondary" Style="float: right;" Text="Edit" Visible="false" /></h2>
                <asp:DataList ID="DataListInfo" runat="server" RepeatLayout="Table" CssClass="table">
                    <ItemTemplate>
                        <tr>
                            <th class="col-sm-2 text-center">Time</th>
                            <th class="col-sm-10 text-center">Activity</th>
                        </tr>
                        <tr>
                            <td class="col-sm-2 text-center"><%# Eval("Time1") %></td>
                            <td class="col-sm-10 text-center"><%# Eval("Activity1") %></td>
                        </tr>
                        <tr>
                            <td class="col-sm-2 text-center"><%# Eval("Time2") %></td>
                            <td class="col-sm-10 text-center"><%# Eval("Activity2") %></td>
                        </tr>
                        <tr>
                            <td class="col-sm-2 text-center"><%# Eval("Time3") %></td>
                            <td class="col-sm-10 text-center"><%# Eval("Activity3") %></td>
                        </tr>
                        <tr>
                            <td class="col-sm-2 text-center"><%# Eval("Time4") %></td>
                            <td class="col-sm-10 text-center"><%# Eval("Activity4") %></td>
                        </tr>
                        <tr>
                            <td class="col-sm-2 text-center"><%# Eval("Time5") %></td>
                            <td class="col-sm-10 text-center"><%# Eval("Activity5") %></td>
                        </tr>
                        <tr>
                            <td class="col-sm-2 text-center"><%# Eval("Time6") %></td>
                            <td class="col-sm-10 text-center"><%# Eval("Activity6") %></td>
                        </tr>
                        <tr>
                            <td class="col-sm-2 text-center"><%# Eval("Time7") %></td>
                            <td class="col-sm-10 text-center"><%# Eval("Activity7") %></td>
                        </tr>
                    </ItemTemplate>
                </asp:DataList>
            </div>
            <div class="text-center">
                <asp:Button ID="BtnPurchaseTicks" runat="server" CssClass="btn btn-primary" OnClick="BtnPurchaseTicks_Click" Text="Buy" />
                <asp:Label runat="server" ID="OutOfTickets" CssClass="input-lg" Visible="false">Tickets had been sold out</asp:Label>
            </div>
        </div>
    </div>
</asp:Content>


