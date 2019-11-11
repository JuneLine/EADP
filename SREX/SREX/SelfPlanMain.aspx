<%@ Page Title="SelfPlanner" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SelfPlanMain.aspx.cs" Inherits="SREX.SelfPlanMain" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/selfPlan.css" rel="stylesheet" />
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
                <div class="row">
                    <div class="md-form active-cyan active-cyan-2 mb-3 col-sm-12 col-lg-12">
                      <input class="form-control" type="text" placeholder="Search" aria-label="Search">
                    </div>
                </div>
                <br />
                <div class="list-group">
                    <div class="destinationOne">
                        <a href="#" class="list-group-item list-group-item-action firstLocation" draggable="true" ondragstart="dragStart(event)">
                            Botanic Gardens
                            <div class="row extra">
                                <div class="extraDes">
                                    Description: A place with flowers
                                </div>
                                <div class="extraCost">
                                    Price: F.O.C
                                </div>
                                <div class="extraTags">
                                    <h6><span class="badge badge-secondary">Outdoors</span></h6>
                                </div>
                            </div>
                        </a>
                    </div>
                    <div class="destinationTwo">
                        <a href="#" class="list-group-item list-group-item-action firstLocation" draggable="true" ondragstart="dragStart(event)">
                            Singapore Zoological Gardens
                            <div class="row extra">
                                <div class="extraDes">
                                    Description: A place with Animals
                                </div>
                                <div class="extraCost">
                                    Price: $30 per pax
                                </div>
                                <div class="extraTags">
                                    <h6><span class="badge badge-secondary">Animals</span></h6>
                                </div>
                            </div>
                        </a>
                    </div>
                    <div class="destinationThree">
                        <a href="#" class="list-group-item list-group-item-action firstLocation" draggable="true" ondragstart="dragStart(event)">
                            Resort World Sentosa
                            <div class="row extra">
                                <div class="extraDes">
                                    Description: A place with Sentosas
                                </div>
                                <div class="extraCost">
                                    Price: F.O.C
                                </div>
                                <div class="extraTags">
                                    <h6><span class="badge badge-secondary">Indoors</span></h6>
                                </div>
                            </div>
                        </a>
                    </div>
                    <div class="destinationOne">
                        <a href="#" class="list-group-item list-group-item-action firstLocation" draggable="true" ondragstart="dragStart(event)">
                            Science Centre
                            <div class="row extra">
                                <div class="extraDes">
                                    Description: A place with Science
                                </div>
                                <div class="extraCost">
                                    Price: $10
                                </div>
                                <div class="extraTags">
                                    <h6><span class="badge badge-secondary">Indoors</span></h6>
                                </div>
                            </div>
                        </a>
                    </div>
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
                            <th scope="row">10am - 11am</th>
                            <td colspan="3" ondrop="drop(event)" ondragover="allowDrop(event)" >Eat</td>
                        </tr>
                        <tr>
                            <th scope="row">11am - 12am</th>
                            <td colspan="3" ondrop="drop(event)" ondragover="allowDrop(event)"><p>Eat</p></td>
                        </tr>
                        <tr>
                            <th scope="row">12am - 1pm</th>
                            <td colspan="3" ondrop="drop(event)" ondragover="allowDrop(event)"><p>Eat</p></td>
                        </tr>
                        <tr>
                            <th scope="row">1pm - 2pm</th>
                            <td colspan="3" ondrop="drop(event)" ondragover="allowDrop(event)"><p>Eat</p></td>
                        </tr>
                        <tr>
                            <th scope="row">2pm - 3pm</th>
                            <td colspan="3" ondrop="drop(event)" ondragover="allowDrop(event)"><p>Eat</p></td>
                        </tr>
                        <tr>
                            <th scope="row">3pm - 4pm</th>
                            <td colspan="3" ondrop="drop(event)" ondragover="allowDrop(event)"><p>Eat</p></td>
                        </tr>
                        <tr>
                            <th scope="row">4pm - 5pm</th>
                            <td colspan="3" ondrop="drop(event)" ondragover="allowDrop(event)"><p>Eat</p></td>
                        </tr>
                        <tr>
                            <th scope="row">5pm - 6pm</th>
                            <td colspan="3" ondrop="drop(event)" ondragover="allowDrop(event)"><p>Eat</p></td>
                        </tr>
                        <tr>
                            <th scope="row">6pm - 7pm</th>
                            <td colspan="3" ondrop="drop(event)" ondragover="allowDrop(event)"><p>Eat</p></td>
                        </tr>
                        <tr>
                            <th scope="row">7pm - 8pm</th>
                            <td colspan="3" ondrop="drop(event)" ondragover="allowDrop(event)"><p>Eat</p></td>
                        </tr>
                        </tbody>
                    </table>
                    <button type="button" class="btn btn-primary" style="float:right;margin: 1%" onclick="window.location.href='#'">Submit</button>
                </div>
            </div>
        </div>
    </div>
    <br />
    <br />
    <br />
    <br />
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
