<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ControlPanel.aspx.cs" Inherits="SREX.ControlPanel" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Product.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/sweetalert2@9"></script>
    <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
    <script>
        google.charts.load('current', { 'packages': ['corechart'] });

        google.charts.setOnLoadCallback(drawChart);

        function drawChart() {
            var options = {
                'title': "Recent Sales",
                'sliceVisibilityThreshold': .05,
                'width': '100%',
            };
            $.ajax({
                type: "POST",
                url: "ControlPanel.aspx/GetPieChartData",
                data: '{}',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (r) {
                    var data = google.visualization.arrayToDataTable(r.d);
                    var chart = new google.visualization.PieChart($("#chart_div")[0]);
                    chart.draw(data, options);
                },
                failure: function (r) {
                    alert(r.d);
                },
                error: function (r) {
                    alert(r.d);
                }
            });

            var BarOptions = {
                'title': "Total Sales Revenue",
                'subtitle': "Not Including Taxes",
                'bar.groupWidth': 61.8,
                'chartArea.left': 0,
                'chartArea.top': '5%',
                'width': '100%',
                'legend': {
                    'position': 'none',
                }
            };

            $.ajax({
                type: "POST",
                url: "ControlPanel.aspx/GetBarChartData",
                data: '{}',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (r) {
                    var data = google.visualization.arrayToDataTable(r.d);
                    var chart = new google.visualization.BarChart($("#Bar_Chart")[0]);
                    chart.draw(data, BarOptions);
                },
                failure: function (r) {
                    alert(r.d);
                },
                error: function (r) {
                    alert(r.d);
                }
            });
        }

        function alert() {
            Swal.fire({
                title: 'Restocked!',
                text: 'Successfully Added Stocks',
                icon: 'success',
                confirmButtonText: 'Confirm',
                showConfirmButton: false,
            })
            setTimeout(function () { window.location.replace("/controlpanel") }, 1000)
        }
    </script>
    <div class="row">
        <div class="col-lg-6 col-md-12 col-sm-12" style="height: 300px">
            <div id="chart_div" style="height: 100%; margin-top: 5%;">
            </div>
        </div>
        <div class="col-lg-6 col-md-12 col-sm-12" style="height: 300px">
            <div id="Bar_Chart" style="height: 100%; margin-top: 5%;">
            </div>
        </div>
    </div>
    <div class="row body-container-own" style="margin-top: 5%;">
        <div class="col-lg-12 col-md-12 col-sm-12">
            <asp:DataList ID="DataListStock" runat="server" RepeatLayout="Table" CssClass="table table-striped body-container-own">
                <HeaderTemplate>
                    <th class="text-center" style="height: 38px">Category:</th>
                    <th class="text-center" style="height: 38px">Item:</th>
                    <th class="text-center" style="height: 38px">Quantity:</th>
                    <th class="text-center" style="height: 38px">Options:</th>
                </HeaderTemplate>
                <ItemTemplate>
                    <td class="text-center"><%#Eval("Category") %></td>
                    <td class="text-center"><%#Eval("Name") %></td>
                    <td class="text-center"><%#Eval("InStock") %></td>
                    <td class="text-center">
                        <asp:Button ID="ButtonToPage" runat="server" Text="Go To Page" class="btn btn-primary" OnClick="ButtonToPage_Click" Value='<%#Eval("Id") %>' />&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Button ID="ButtonToRestock" Stuff='<%#Eval("Id") %>' runat="server" Text="Restock" class="btn btn-primary" OnClick="ButtonToRestock_Click" />
                    </td>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </div>
    <asp:Panel ID="Panel1" runat="server" CssClass="modalPanel2" Visible="false">
        <div class="modal-content">
            <button class="close" onclick='document.getElementById("MainContent_Panel1").style.display = "none"; return false;'><span>&times</span></button>
            <div class="row" style="margin-top: 10px">
                <div class="col-lg-3" style="margin: 2%">
                    <asp:Image ID="Image" runat="server" Style="max-height: 300px; max-width: 600px; margin: auto" />
                </div>
                <div class="col-lg-8">
                    <p>
                        <asp:Label ID="LabelTitle" runat="server" Text="Default Title" Font-Size="Medium"></asp:Label>
                    </p>
                    <p style="margin-top: 5%">
                        <asp:Label ID="LabelOverview" runat="server" Text="Default Description"></asp:Label>
                    </p>
                    <hr />
                    <div class="row" style="margin-top: 2%">
                        <div class="col-lg-2">
                            Sold:<br />
                            <asp:Label ID="LabelSold" runat="server" Text="Sold Amount"></asp:Label>
                        </div>
                        <div class="col-lg-2">
                            In Stock:<br />
                            <asp:Label ID="LabelStock" runat="server" Text="Stock Amount"></asp:Label>
                        </div>
                        <div class="col-lg-5">                            
                            Amount To Restock:
                            <asp:TextBox ID="RestockAmount" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="col-lg-3">
                            <asp:Button ID="ButtonSubmit" runat="server" Text="Confirm" CssClass="btn btn-primary" OnClick="ButtonSubmit_Click" style="float:right;"/>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorRestock" runat="server" ControlToValidate="RestockAmount"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidatorRestock" runat="server" ControlToValidate="RestockAmount" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </asp:Panel>
</asp:Content>
