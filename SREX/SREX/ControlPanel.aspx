<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ControlPanel.aspx.cs" Inherits="SREX.ControlPanel" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Product.css" rel="stylesheet" />
    <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
    <script>
        // Load the Visualization API and the corechart package.
        google.charts.load('current', { 'packages': ['corechart'] });

        // Set a callback to run when the Google Visualization API is loaded.
        google.charts.setOnLoadCallback(drawChart);

        // Callback that creates and populates a data table,
        // instantiates the pie chart, passes in the data and
        // draws it.
        function drawChart() {

            //// Create the data table.
            //var data = new google.visualization.arrayToDataTable([
            //    ["Items", "Quantity"],
            //    ["Samsung S10+", 30],
            //    ['LG 55" TV', 20],
            //    ["Nvidia 2080ti", 17],
            //    ["Sony WF1000 XM3", 5],
            //    ["Cup", 2],
            //    ["Bottle", 2],
            //    ["Laser", 2],
            //    ["Water", 2],
            //    ["Pills", 1],
            //]);

            // Set chart options
            var options = {
                'title': "Recent Sales",
                'sliceVisibilityThreshold': .1,
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

            //var BarData = new google.visualization.arrayToDataTable([
            //    ["Date", "Amount"],
            //    ["6 Days Ago", 200],
            //    ["5 Days Ago", 300],
            //    ["4 Days Ago", 280],
            //    ["3 Days Ago", 600],
            //    ["2 Days Ago", 350],
            //    ["1 Days Ago", 280],
            //    ["Today", 600],
            //]);

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
                    chart.draw(data, options);
                },
                failure: function (r) {
                    alert(r.d);
                },
                error: function (r) {
                    alert(r.d);
                }
            });
        }
    </script>
    <div class="row">
        <div class="col-lg-5 col-md-12 col-sm-12" style="height: 300px">
            <div id="chart_div" style="height: 100%; margin-top: 5%;">
            </div>
        </div>
        <div class="col-lg-7 col-md-12 col-sm-12" style="height: 300px">
            <div id="Bar_Chart" style="height: 100%; margin-top: 5%;">
            </div>
        </div>
    </div>
    <br />
    <br />
    <div class="row body-container-own">
        <div class="col-lg-12 col-md-12 col-sm-12">
            <table class="table table-striped table-hover" style="margin-left: auto; margin-right: auto;">
                <thead>
                    <tr>
                        <th>Item:
                        </th>
                        <th>Quantity:
                        </th>
                        <th>Status
                        </th>
                        <th>Options:
                        </th>
                    </tr>
                </thead>
                <tr>
                    <td>TCL 55" OLED TV
                    </td>
                    <td>5
                    </td>
                    <td>WARNING LOW ON STOCK
                    </td>
                    <td>
                        <asp:Button ID="ButtonToPage" runat="server" Text="Go To Page" class="btn btn-primary" />&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Button ID="ButtonToRestock" runat="server" Text="Restock" class="btn btn-primary" />
                    </td>
                </tr>
                <tr>
                    <td>Nike Random Shoe
                    </td>
                    <td>2
                    </td>
                    <td>WARNING EXTREMELY LOW ON STOCK
                    </td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Go To Page" class="btn btn-primary" />&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Button ID="Button2" runat="server" Text="Restock" class="btn btn-primary" />
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
