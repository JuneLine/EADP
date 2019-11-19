<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ControlPanel.aspx.cs" Inherits="SREX.ControlPanel" %>

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

            // Create the data table.
            var data = new google.visualization.arrayToDataTable([
                ["Items", "Quantity"],
                ["Samsung S10+", 30],
                ["LG 55&quot; TV", 20],
                ["Nvidia 2080ti", 17],
                ["Sony WF1000 XM3", 5],
                ["Cup", 2],
                ["Bottle", 2],
                ["Laser", 2],
                ["Water", 2],
                ["Pills", 1],
            ]);

            // Set chart options
            var options = {
                'title': "Recent Sales",
                'sliceVisibilityThreshold': .1,
                'width': '100%',
            };

            var BarData = new google.visualization.arrayToDataTable([
                ["Date", "Amount"],
                ["6 Days Ago", 200],
                ["5 Days Ago", 300],
                ["4 Days Ago", 280],
                ["3 Days Ago", 600],
                ["2 Days Ago", 350],
                ["1 Days Ago", 280],
                ["Today", 600],
            ]);

            var BarOptions = {
                'title': "Total Sales Revenue",
                'subtitle': "Not Including Taxes",
                'bar.groupWidth': 61.8,
                'chartArea.left': 0,
                'width': '100%',
                'legend': {
                    'position': 'none',
                }
            };

            // Instantiate and draw our chart, passing in some options.
            var chart = new google.visualization.PieChart(document.getElementById('chart_div'));
            chart.draw(data, options);
            var BarChart = new google.visualization.BarChart(document.getElementById("Bar_Chart"))
            BarChart.draw(BarData, BarOptions)
        }
    </script>
    <div class="row">
        <div class="col-lg-5 col-md-12 col-sm-12" style="height: 300px">
            <div id="chart_div" style="height: 100%"></div>
        </div>
        <div class="col-lg-7 col-md-12 col-sm-12" style="height: 300px">
            <div id="Bar_Chart" style="height: 100%"></div>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-12 col-md-12 col-sm-12">
            <table class="OrderTable" style="margin-left:auto;margin-right:auto;">
                <tr>
                    <th style="padding-right:40%">Item:
                    </th>
                    <th style="padding-right:10%">Quantity:
                    </th>
                    <th style="padding-right:30%">Status
                    </th>
                    <th>Options:
                    </th>
                </tr>
                <tr>
                    <td>TCL 55" OLED TV
                    </td>
                    <td>5
                    </td>
                    <td>WARNING LOW STOCK
                    </td>
                    <td>
                        <asp:Button ID="ButtonToPage" runat="server" Text="Go To Page" />&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Button ID="ButtonToRestock" runat="server" Text="Restock" />
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
