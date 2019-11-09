<%@ Page Title="SelfPlanner" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SelfPlanMain.aspx.cs" Inherits="SREX.SelfPlanMain" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
            <div class="page-header">
                <h1 class="text-center">Self plan</h1>
                <div class="row">
                    <button type="button" class="btn btn-primary" style="float:right;margin: 1%" onclick="window.location.href='PlanningHistory.aspx'">History</button>
                </div>
            </div>
    </div>
    <div class="container">
        <div class="row">
            <div class="col-sm-3 col-lg-3">
                <div class="list-group">
                    <a href="https://www.youtube.com/watch?v=kJQP7kiw5Fk" class="list-group-item list-group-item-action" draggable="true" ondragstart="dragStart(event)">
                        Despacito
                    </a>
                    <a href="#" class="list-group-item list-group-item-action" draggable="true" ondragstart="dragStart(event)">Singapore Zoological Garen</a>
                    <a href="#" class="list-group-item list-group-item-action" draggable="true" ondragstart="dragStart(event)">Resort World Senna</a>
                    <a href="#" class="list-group-item list-group-item-action" draggable="true" ondragstart="dragStart(event)">Science Pantheon</a>
                    <a href="#" class="list-group-item list-group-item-action" draggable="true" ondragstart="dragStart(event)">Sennasa</a>
                </div>

            </div>
            <div class="col-sm-9 col-lg-9">
                <div class="row">
                    <input type="date" value="">
                </div>
                <div class="row">
                    <table class="table">
                        <thead class="thead-dark">
                            <tr>
                                <th scope="col" class="col-sm-2 col-lg-2">Timings</th>
                                <th scope="col" class="col-sm-10 col-lg-10">Activities</th>
                            </tr>
                        </thead>
                        <tbody>
                        <tr>
                            <th scope="row">1pm - 12pm</th>
                            <td colspan="3" ondrop="drop(event)" ondragover="allowDrop(event)" >Eat</td>
                        </tr>
                        <tr>
                            <th scope="row">12pm - 100am</th>
                            <td colspan="3" ondrop="drop(event)" ondragover="allowDrop(event)"><p>Eat</p></td>
                        </tr>
                        <tr>
                            <th scope="row">200am - 300am</th>
                            <td colspan="3" ondrop="drop(event)" ondragover="allowDrop(event)"><p>Eat</p></td>
                        </tr>
                        <tr>
                            <th scope="row">300am - 300am</th>
                            <td colspan="3" ondrop="drop(event)" ondragover="allowDrop(event)"><p>Eat</p></td>
                        </tr>
                        <tr>
                            <th scope="row">400am - 300am</th>
                            <td colspan="3" ondrop="drop(event)" ondragover="allowDrop(event)"><p>Eat</p></td>
                        </tr>
                        <tr>
                            <th scope="row">500am - 300am</th>
                            <td colspan="3" ondrop="drop(event)" ondragover="allowDrop(event)"><p>Eat</p></td>
                        </tr>
                        <tr>
                            <th scope="row">600am - 300am</th>
                            <td colspan="3" ondrop="drop(event)" ondragover="allowDrop(event)"><p>Eat</p></td>
                        </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
    <script>
        function dragStart(event) {
            event.dataTransfer.setData("Text", event.target.id);
        }

        function allowDrop(event) {
            event.preventDefault();
        }
        function drop(event) {
            event.preventDefault();
            var data = event.dataTransfer.getData("Text");
            event.target.appendChild(document.getElementById(data));
        }
    </script>
</asp:Content>
