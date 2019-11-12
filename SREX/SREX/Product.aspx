<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="SREX.Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <div class="row" style="margin-top:50px;">
            <div class="col-lg-4 col-md-6 col-sm-12">
                <img src="https://images-na.ssl-images-amazon.com/images/I/91mqp0z-TiL._SX679_.jpg" style="max-height:500px;max-width:500px;width:100%;height:100%;margin-top:50px;"/>
            </div>
            <div class="col-lg-8 col-md-6 col-sm-12">
                <span style="font-size:21px;">TCL 55" Class 5-Series 4K UHD Dolby Vision HDR Roku Smart TV - 55S525</span>
                <br />
                <span style="color:green;font-size:15px;">In Stock</span>
                <br />
                <br />
                Price: <span style="color:darkred">S$5,065.07</span>
                <br />
                <br />
                Size: <span style="font-weight:bold">55 Inch</span>
                <br />
                <br />
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Selected="True">55 Inch &nbsp&nbsp</asp:ListItem>
                    <asp:ListItem>60 Inch &nbsp&nbsp</asp:ListItem>
                    <asp:ListItem>65 Inch</asp:ListItem>
                </asp:RadioButtonList>
                <br />
                <ul>
                    <li style="list-style:disc !important">Smart functionality offers access to thousands of streaming channels featuring more than 500,000 movies and TV episodes via Roku TV</li>
                    <li style="list-style:disc !important">Pairs 4K Ultra HD picture clarity with the contrast, color and detail of Dolby Vision high dynamic range (HDR) for the most lifelike picture</li>
                    <li style="list-style:disc !important">Full View design provides a clean, contemporary edge-to-edge glass display that blends seamlessly into your viewing experience</li>
                    <li style="list-style:disc !important">Auto Game Mode automatically enhances performance by offering the smoothest action, lowest latency and the best picture settings for gaming</li>
                    <li style="list-style:disc !important">Inputs: 4 HDMI 2.0 with HDCP 2.2 (one with HDMI ARC), 1 USB (media player), RF, Composite, Headphone Jack, Optical Audio Out, Ethernet</li>
                    <li style="list-style:disc !important">Dimensions (W x H x D): TV without stand: 48.4 inch X 28.1 inch X 3.0 inch, TV with stand: 48.4 inch X 30.6 inch X 10.0 inch</li>
                    <li style="list-style:disc !important">Easy Voice Control with Alexa and Google Assistant compatibility</li>
                </ul>
                <div style="float:right;margin-right:160px;margin-top:30px;">
                    <asp:Button ID="ButtonBuyNow" runat="server" Text="Buy Now"/>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
