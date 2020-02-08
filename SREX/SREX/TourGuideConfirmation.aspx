<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TourGuideConfirmation.aspx.cs" Inherits="SREX.TourGuideConfirmation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="col-sm-4 col-lg-4 border border-secondary rounded">
        <div class="d-flex w-100 justify-content-between">
            <h1> <asp:Label ID="LabelUserName" runat="server"></asp:Label></h1>
                <h5 class="mb-1"><asp:Label ID="LabelTitle" runat="server"></asp:Label></h5>
            <small>Date: <asp:Label ID="LabelDate" runat="server"></asp:Label></small>
            </div>
    </div>
    <div class="col-sm-8 col-lg-8 list-group-item list-group-item-action flex-column align-items-start" style="margin-bottom:100px;">
            <div class="row rounded">
                    <table class="table" style="padding: 5px">
                        <thead class="thead-dark">
                            <tr>
                                <th scope="col" class="col-sm-4 col-lg-4">Timings</th>
                                <th scope="col" class="col-sm-8 col-lg-8">Activities</th>
                            </tr>
                        </thead>
                        <tbody>
                        <tr>
                            <th scope="row">10am - 11am</th>
                            <td colspan="4">
                                <p>
                                    <asp:Label ID="LabelTiming1" runat="server"></asp:Label>
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <th scope="row">11am - 12am</th>
                            <td colspan="4">
                                <p>
                                    <asp:Label ID="LabelTiming2" runat="server"></asp:Label>
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <th scope="row">12am - 1pm</th>
                            <td colspan="4">
                                <p>
                                    <asp:Label ID="LabelTiming3" runat="server"></asp:Label>
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <th scope="row">1pm - 2pm</th>
                            <td colspan="4">
                                <p>
                                    <asp:Label ID="LabelTiming4" runat="server"></asp:Label>
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <th scope="row">2pm - 3pm</th>
                            <td colspan="4">
                                <p>
                                    <asp:Label ID="LabelTiming5" runat="server"></asp:Label>
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <th scope="row">3pm - 4pm</th>
                            <td colspan="4">
                                <p>
                                   <asp:Label ID="LabelTiming6" runat="server"></asp:Label>
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <th scope="row">4pm - 5pm</th>
                            <td colspan="4">
                                <p>
                                    <asp:Label ID="LabelTiming7" runat="server"></asp:Label>
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <th scope="row">5pm - 6pm</th>
                            <td colspan="4">
                                <p>
                                    <asp:Label ID="LabelTiming8" runat="server"></asp:Label>
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <th scope="row">6pm - 7pm</th>
                            <td colspan="4">
                                <p>
                                    <asp:Label ID="LabelTiming9" runat="server"></asp:Label>
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <th scope="row">7pm - 8pm</th>
                            <td colspan="4">
                                <p>
                                    <asp:Label ID="LabelTiming10" runat="server"></asp:Label>
                                </p>
                            </td>
                        </tr>
                        </tbody>
                    </table>
                <asp:Button ID="ConfirmButton" CssClass="btn btn-primary" style="float:right; margin-right:10px;" runat="server" Text="Confirm" OnClick="ConfirmButton_Click"/>&nbsp&nbsp
                <asp:Button ID="BtnBack" class="btn btn-primary" style="float:left;margin-left:10px;" runat="server" Text="Back" OnClick="BtnBack_Click1" />&nbsp&nbsp
                </div>
        </div>
</asp:Content>
