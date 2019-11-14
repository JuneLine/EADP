﻿<%@ Page Title="Shopping History" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShoppingHistory.aspx.cs" Inherits="SREX.ShoppingHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="well" style="margin-top: 20px;">
        <h3 class="text-center">Purchase History Review</h3>
    </div>
    <table id="mytable" class="table table-bordred table-striped body-container-own">
        <thead>
            <th class="text-center">Product Name</th>
            <th class="text-center">Purchase Date</th>
            <th class="text-center">Quantity</th>
            <th class="text-center">Cost</th>
            <th class="text-center">Buyer Info</th>
            <th class="text-center">QR Code</th>
        </thead>
        <tbody>
            <tr>
                <td class="text-center">Air Force 1 "17</td>
                <td class="text-center">2019/04/30</td>
                <td class="text-center">3</td>
                <td class="text-center">$300</td>
                <td class="text-center">
                    <p data-placement="top" class="text-center" data-toggle="tooltip" title="View">
                        <button class="btn btn-primary btn-xs"><span class="glyphicon glyphicon-eye-open"></span></button>
                    </p>
                </td>
                <td>
                    <p data-placement="top" class="text-center" data-toggle="tooltip" title="Proof">
                        <button class="btn btn-info btn-xs"><span class="glyphicon glyphicon-qrcode"></span></button>
                    </p>
                </td>
            </tr>
            <tr>
                <td class="text-center">Air Force 1 "17</td>
                <td class="text-center">2019/04/30</td>
                <td class="text-center">3</td>
                <td class="text-center">$300</td>
                <td class="text-center">
                    <p data-placement="top" class="text-center" data-toggle="tooltip" title="View">
                        <button class="btn btn-primary btn-xs"><span class="glyphicon glyphicon-eye-open"></span></button>
                    </p>
                </td>
                <td>
                    <p data-placement="top" class="text-center" data-toggle="tooltip" title="Proof">
                        <button class="btn btn-info btn-xs"><span class="glyphicon glyphicon-qrcode"></span></button>
                    </p>
                </td>
            </tr>
            <tr>
                <td class="text-center">Air Force 1 "17</td>
                <td class="text-center">2019/04/30</td>
                <td class="text-center">3</td>
                <td class="text-center">$300</td>
                <td class="text-center">
                    <p data-placement="top" class="text-center" data-toggle="tooltip" title="View">
                        <button class="btn btn-primary btn-xs"><span class="glyphicon glyphicon-eye-open"></span></button>
                    </p>
                </td>
                <td>
                    <p data-placement="top" class="text-center" data-toggle="tooltip" title="Proof">
                        <button class="btn btn-info btn-xs"><span class="glyphicon glyphicon-qrcode"></span></button>
                    </p>
                </td>
            </tr>
            <tr>
                <td class="text-center">Air Force 1 "17</td>
                <td class="text-center">2019/04/30</td>
                <td class="text-center">3</td>
                <td class="text-center">$300</td>
                <td class="text-center">
                    <p data-placement="top" class="text-center" data-toggle="tooltip" title="View">
                        <button class="btn btn-primary btn-xs"><span class="glyphicon glyphicon-eye-open"></span></button>
                    </p>
                </td>
                <td>
                    <p data-placement="top" class="text-center" data-toggle="tooltip" title="Proof">
                        <button class="btn btn-info btn-xs"><span class="glyphicon glyphicon-qrcode"></span></button>
                    </p>
                </td>
            </tr>
            <tr>
                <td class="text-center">Air Force 1 "17</td>
                <td class="text-center">2019/04/30</td>
                <td class="text-center">3</td>
                <td class="text-center">$300</td>
                <td class="text-center">
                    <p data-placement="top" class="text-center" data-toggle="tooltip" title="View">
                        <button class="btn btn-primary btn-xs"><span class="glyphicon glyphicon-eye-open"></span></button>
                    </p>
                </td>
                <td>
                    <p data-placement="top" class="text-center" data-toggle="tooltip" title="Proof">
                        <button class="btn btn-info btn-xs"><span class="glyphicon glyphicon-qrcode"></span></button>
                    </p>
                </td>
            </tr>
        </tbody>
    </table>

</asp:Content>