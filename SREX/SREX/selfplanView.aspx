<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="selfplanView.aspx.cs" Inherits="SREX.selfplanView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="list-group-item list-group-item-action flex-column align-items-start">
            <div class="d-flex w-100 justify-content-between">
                <h5 class="mb-1"><asp:Label ID="LabelTitle" runat="server"></asp:Label></h5>
                <small style="color: red;">Guided: <asp:Label ID="LabelHire" runat="server"></asp:Label></small>
                <br />
                <small>Date: <asp:Label ID="LabelDate" runat="server"></asp:Label></small>
            </div>
                    <hr />
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
                            <tr>
                                <td colspan="10">
                                    <p>
                                    <asp:Button ID="BtnBack" style="float:right" runat="server" OnClick="BtnBack_Click" Text="Back" />&nbsp&nbsp
                                        </p>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <br />
                <br />
                <br />
                <br />
                </div>
</asp:Content>
