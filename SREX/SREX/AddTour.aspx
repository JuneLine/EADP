<%@ Page Title="Add Tour" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddTour.aspx.cs" Inherits="SREX.AddTour" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Guide.css" rel="stylesheet" />
    <br />
    <div class="body-container-own">
        <div class="well text-center">
            <h2><b>Add Tour</b></h2>
        </div>
        <div class="container">
            <fieldset>
                <div class="row text-center">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red"/>
                </div>
                <div class="col-sm-6">
                    <div class="form-group">
                        <label for="AttractionName">Tour Name: <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please fill the required field" ControlToValidate="tbTourName" ForeColor="Red">*</asp:RequiredFieldValidator></label>
                        <asp:TextBox runat="server" ID="tbTourName" CssClass="form-control"></asp:TextBox>                        
                    </div>
                    <div class="form-group row">
                        <div class="col-sm-8">
                            <label for="tbDateOfTour">Date Of Tour: <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbDateOfTour" ForeColor="Red">*</asp:RequiredFieldValidator></label>
                            <asp:TextBox runat="server" ID="tbDateOfTour" CssClass="form-control" placeholder="DD/MM/YYYY" TextMode="Date"></asp:TextBox>                            
                        </div>
                        <div class="col-sm-4">
                            <label for="Limit">Limit: <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="Limit" ForeColor="Red">*</asp:RequiredFieldValidator> </label>
                            <input type="number" runat="server" ID="Limit" class="form-control" min="1" max="1000"/>
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="TourPicture">Picture: <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="FileTourPicture" ForeColor="Red">*</asp:RequiredFieldValidator> </label>
                        <asp:FileUpload runat="server" ID="FileTourPicture" CssClass="form-control" />                        
                    </div>
                    <div class="form-group">
                        <label for="TourCaption">Tour Caption: <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="tbTourCaption" ForeColor="Red">*</asp:RequiredFieldValidator></label>
                        <asp:TextBox runat="server" ID="tbTourCaption" CssClass="form-control"></asp:TextBox>                        
                    </div>
                    <div class="row form-group">
                        <div class="col-sm-4">
                            <label for="DropDownListTime">Meet Up Time: <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ForeColor="red" ControlToValidate="DropDownListmeetTime" InitialValue="NIL">*</asp:RequiredFieldValidator></label>
                            <asp:DropDownList ID="DropDownListmeetTime" runat="server" CssClass="form-control">
                                <asp:ListItem Text="-Select" Value="NIL">-Select-</asp:ListItem>
                                <asp:ListItem>0000</asp:ListItem>
                                <asp:ListItem>0100</asp:ListItem>
                                <asp:ListItem>0200</asp:ListItem>
                                <asp:ListItem>0300</asp:ListItem>
                                <asp:ListItem>0400</asp:ListItem>
                                <asp:ListItem>0500</asp:ListItem>
                                <asp:ListItem>0600</asp:ListItem>
                                <asp:ListItem>0700</asp:ListItem>
                                <asp:ListItem>0800</asp:ListItem>
                                <asp:ListItem>0900</asp:ListItem>
                                <asp:ListItem>1000</asp:ListItem>
                                <asp:ListItem>1100</asp:ListItem>
                                <asp:ListItem>1200</asp:ListItem>
                                <asp:ListItem>1300</asp:ListItem>
                                <asp:ListItem>1400</asp:ListItem>
                                <asp:ListItem>1500</asp:ListItem>
                                <asp:ListItem>1600</asp:ListItem>
                                <asp:ListItem>1700</asp:ListItem>
                                <asp:ListItem>1800</asp:ListItem>
                                <asp:ListItem>1900</asp:ListItem>
                                <asp:ListItem>2000</asp:ListItem>
                                <asp:ListItem>2100</asp:ListItem>
                                <asp:ListItem>2200</asp:ListItem>
                                <asp:ListItem>2300</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-8">
                            <label for="tbMeetUpLocation">Meet Up Location: <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="tbLocation" ForeColor="Red">*</asp:RequiredFieldValidator></label>
                            <asp:TextBox runat="server" ID="tbLocation" CssClass="form-control" placeholder="E.g Khatib MRT"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row form-group">
                        <div class="col-sm-4">
                            <label for="tbAdultCost">Adult Price: <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="tbAdultCost" ForeColor="Red">*</asp:RequiredFieldValidator></label>
                            <asp:TextBox runat="server" ID="tbAdultCost" CssClass="form-control" TextMode="Number"></asp:TextBox>
                        </div>
                        <div class="col-sm-4">
                            <label for="tbChildCost">Child Price: <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="tbChildCost" ForeColor="Red">*</asp:RequiredFieldValidator></label>
                            <asp:TextBox runat="server" ID="tbChildCost" CssClass="form-control" TextMode="Number"></asp:TextBox>
                        </div>
                        <div class="col-sm-4">
                            <label for="tbSeniorCost">Senior Price: <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="tbSeniorCost" ForeColor="Red">*</asp:RequiredFieldValidator></label>
                            <asp:TextBox runat="server" ID="tbSeniorCost" CssClass="form-control" TextMode="Number"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="col-sm-6">
                    <label>Time Schedule</label>
                    <asp:Table runat="server" CssClass="table table-bordered table-hover">
                        <asp:TableHeaderRow>
                            <asp:TableCell>
                            Time
                            </asp:TableCell>
                            <asp:TableCell>
                            Activity
                            </asp:TableCell>
                        </asp:TableHeaderRow>
                        <asp:TableRow>
                            <asp:TableCell CssClass="col-sm-3">
                                <asp:DropDownList ID="DropDownListTime1" runat="server" CssClass="form-control">
                                    <asp:ListItem Text="-Select" Value="NIL">-Select-</asp:ListItem>
                                    <asp:ListItem>0000</asp:ListItem>
                                    <asp:ListItem>0100</asp:ListItem>
                                    <asp:ListItem>0200</asp:ListItem>
                                    <asp:ListItem>0300</asp:ListItem>
                                    <asp:ListItem>0400</asp:ListItem>
                                    <asp:ListItem>0500</asp:ListItem>
                                    <asp:ListItem>0600</asp:ListItem>
                                    <asp:ListItem>0700</asp:ListItem>
                                    <asp:ListItem>0800</asp:ListItem>
                                    <asp:ListItem>0900</asp:ListItem>
                                    <asp:ListItem>1000</asp:ListItem>
                                    <asp:ListItem>1100</asp:ListItem>
                                    <asp:ListItem>1200</asp:ListItem>
                                    <asp:ListItem>1300</asp:ListItem>
                                    <asp:ListItem>1400</asp:ListItem>
                                    <asp:ListItem>1500</asp:ListItem>
                                    <asp:ListItem>1600</asp:ListItem>
                                    <asp:ListItem>1700</asp:ListItem>
                                    <asp:ListItem>1800</asp:ListItem>
                                    <asp:ListItem>1900</asp:ListItem>
                                    <asp:ListItem>2000</asp:ListItem>
                                    <asp:ListItem>2100</asp:ListItem>
                                    <asp:ListItem>2200</asp:ListItem>
                                    <asp:ListItem>2300</asp:ListItem>
                                </asp:DropDownList>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" CssClass="form-control" ID="tbActivity1"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell CssClass="col-sm-3">
                                <asp:DropDownList ID="DropDownListTime2" runat="server" CssClass="form-control">
                                    <asp:ListItem Text="-Select" Value="NIL">-Select-</asp:ListItem>
                                    <asp:ListItem>0000</asp:ListItem>
                                    <asp:ListItem>0100</asp:ListItem>
                                    <asp:ListItem>0200</asp:ListItem>
                                    <asp:ListItem>0300</asp:ListItem>
                                    <asp:ListItem>0400</asp:ListItem>
                                    <asp:ListItem>0500</asp:ListItem>
                                    <asp:ListItem>0600</asp:ListItem>
                                    <asp:ListItem>0700</asp:ListItem>
                                    <asp:ListItem>0800</asp:ListItem>
                                    <asp:ListItem>0900</asp:ListItem>
                                    <asp:ListItem>1000</asp:ListItem>
                                    <asp:ListItem>1100</asp:ListItem>
                                    <asp:ListItem>1200</asp:ListItem>
                                    <asp:ListItem>1300</asp:ListItem>
                                    <asp:ListItem>1400</asp:ListItem>
                                    <asp:ListItem>1500</asp:ListItem>
                                    <asp:ListItem>1600</asp:ListItem>
                                    <asp:ListItem>1700</asp:ListItem>
                                    <asp:ListItem>1800</asp:ListItem>
                                    <asp:ListItem>1900</asp:ListItem>
                                    <asp:ListItem>2000</asp:ListItem>
                                    <asp:ListItem>2100</asp:ListItem>
                                    <asp:ListItem>2200</asp:ListItem>
                                    <asp:ListItem>2300</asp:ListItem>
                                </asp:DropDownList>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" CssClass="form-control" ID="tbActivity2"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell CssClass="col-sm-3">
                                <asp:DropDownList ID="DropDownListTime3" runat="server" CssClass="form-control">
                                    <asp:ListItem Text="-Select" Value="NIL">-Select-</asp:ListItem>
                                    <asp:ListItem>0000</asp:ListItem>
                                    <asp:ListItem>0100</asp:ListItem>
                                    <asp:ListItem>0200</asp:ListItem>
                                    <asp:ListItem>0300</asp:ListItem>
                                    <asp:ListItem>0400</asp:ListItem>
                                    <asp:ListItem>0500</asp:ListItem>
                                    <asp:ListItem>0600</asp:ListItem>
                                    <asp:ListItem>0700</asp:ListItem>
                                    <asp:ListItem>0800</asp:ListItem>
                                    <asp:ListItem>0900</asp:ListItem>
                                    <asp:ListItem>1000</asp:ListItem>
                                    <asp:ListItem>1100</asp:ListItem>
                                    <asp:ListItem>1200</asp:ListItem>
                                    <asp:ListItem>1300</asp:ListItem>
                                    <asp:ListItem>1400</asp:ListItem>
                                    <asp:ListItem>1500</asp:ListItem>
                                    <asp:ListItem>1600</asp:ListItem>
                                    <asp:ListItem>1700</asp:ListItem>
                                    <asp:ListItem>1800</asp:ListItem>
                                    <asp:ListItem>1900</asp:ListItem>
                                    <asp:ListItem>2000</asp:ListItem>
                                    <asp:ListItem>2100</asp:ListItem>
                                    <asp:ListItem>2200</asp:ListItem>
                                    <asp:ListItem>2300</asp:ListItem>
                                </asp:DropDownList>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" CssClass="form-control" ID="tbActivity3"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell CssClass="col-sm-3">
                                <asp:DropDownList ID="DropDownListTime4" runat="server" CssClass="form-control">
                                    <asp:ListItem Text="-Select" Value="NIL">-Select-</asp:ListItem>
                                    <asp:ListItem>0000</asp:ListItem>
                                    <asp:ListItem>0100</asp:ListItem>
                                    <asp:ListItem>0200</asp:ListItem>
                                    <asp:ListItem>0300</asp:ListItem>
                                    <asp:ListItem>0400</asp:ListItem>
                                    <asp:ListItem>0500</asp:ListItem>
                                    <asp:ListItem>0600</asp:ListItem>
                                    <asp:ListItem>0700</asp:ListItem>
                                    <asp:ListItem>0800</asp:ListItem>
                                    <asp:ListItem>0900</asp:ListItem>
                                    <asp:ListItem>1000</asp:ListItem>
                                    <asp:ListItem>1100</asp:ListItem>
                                    <asp:ListItem>1200</asp:ListItem>
                                    <asp:ListItem>1300</asp:ListItem>
                                    <asp:ListItem>1400</asp:ListItem>
                                    <asp:ListItem>1500</asp:ListItem>
                                    <asp:ListItem>1600</asp:ListItem>
                                    <asp:ListItem>1700</asp:ListItem>
                                    <asp:ListItem>1800</asp:ListItem>
                                    <asp:ListItem>1900</asp:ListItem>
                                    <asp:ListItem>2000</asp:ListItem>
                                    <asp:ListItem>2100</asp:ListItem>
                                    <asp:ListItem>2200</asp:ListItem>
                                    <asp:ListItem>2300</asp:ListItem>
                                </asp:DropDownList>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" CssClass="form-control" ID="tbActivity4"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell CssClass="col-sm-3">
                                <asp:DropDownList ID="DropDownListTime5" runat="server" CssClass="form-control">
                                    <asp:ListItem Text="-Select" Value="NIL">-Select-</asp:ListItem>
                                    <asp:ListItem>0000</asp:ListItem>
                                    <asp:ListItem>0100</asp:ListItem>
                                    <asp:ListItem>0200</asp:ListItem>
                                    <asp:ListItem>0300</asp:ListItem>
                                    <asp:ListItem>0400</asp:ListItem>
                                    <asp:ListItem>0500</asp:ListItem>
                                    <asp:ListItem>0600</asp:ListItem>
                                    <asp:ListItem>0700</asp:ListItem>
                                    <asp:ListItem>0800</asp:ListItem>
                                    <asp:ListItem>0900</asp:ListItem>
                                    <asp:ListItem>1000</asp:ListItem>
                                    <asp:ListItem>1100</asp:ListItem>
                                    <asp:ListItem>1200</asp:ListItem>
                                    <asp:ListItem>1300</asp:ListItem>
                                    <asp:ListItem>1400</asp:ListItem>
                                    <asp:ListItem>1500</asp:ListItem>
                                    <asp:ListItem>1600</asp:ListItem>
                                    <asp:ListItem>1700</asp:ListItem>
                                    <asp:ListItem>1800</asp:ListItem>
                                    <asp:ListItem>1900</asp:ListItem>
                                    <asp:ListItem>2000</asp:ListItem>
                                    <asp:ListItem>2100</asp:ListItem>
                                    <asp:ListItem>2200</asp:ListItem>
                                    <asp:ListItem>2300</asp:ListItem>
                                </asp:DropDownList>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" CssClass="form-control" ID="tbActivity5"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell CssClass="col-sm-3">
                                <asp:DropDownList ID="DropDownListTime6" runat="server" CssClass="form-control">
                                    <asp:ListItem Text="-Select" Value="NIL">-Select-</asp:ListItem>
                                    <asp:ListItem>0000</asp:ListItem>
                                    <asp:ListItem>0100</asp:ListItem>
                                    <asp:ListItem>0200</asp:ListItem>
                                    <asp:ListItem>0300</asp:ListItem>
                                    <asp:ListItem>0400</asp:ListItem>
                                    <asp:ListItem>0500</asp:ListItem>
                                    <asp:ListItem>0600</asp:ListItem>
                                    <asp:ListItem>0700</asp:ListItem>
                                    <asp:ListItem>0800</asp:ListItem>
                                    <asp:ListItem>0900</asp:ListItem>
                                    <asp:ListItem>1000</asp:ListItem>
                                    <asp:ListItem>1100</asp:ListItem>
                                    <asp:ListItem>1200</asp:ListItem>
                                    <asp:ListItem>1300</asp:ListItem>
                                    <asp:ListItem>1400</asp:ListItem>
                                    <asp:ListItem>1500</asp:ListItem>
                                    <asp:ListItem>1600</asp:ListItem>
                                    <asp:ListItem>1700</asp:ListItem>
                                    <asp:ListItem>1800</asp:ListItem>
                                    <asp:ListItem>1900</asp:ListItem>
                                    <asp:ListItem>2000</asp:ListItem>
                                    <asp:ListItem>2100</asp:ListItem>
                                    <asp:ListItem>2200</asp:ListItem>
                                    <asp:ListItem>2300</asp:ListItem>
                                </asp:DropDownList>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" CssClass="form-control" ID="tbActivity6"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell CssClass="col-sm-3">
                                <asp:DropDownList ID="DropDownListTime7" runat="server" CssClass="form-control">
                                    <asp:ListItem Text="-Select" Value="NIL">-Select-</asp:ListItem>
                                    <asp:ListItem>0000</asp:ListItem>
                                    <asp:ListItem>0100</asp:ListItem>
                                    <asp:ListItem>0200</asp:ListItem>
                                    <asp:ListItem>0300</asp:ListItem>
                                    <asp:ListItem>0400</asp:ListItem>
                                    <asp:ListItem>0500</asp:ListItem>
                                    <asp:ListItem>0600</asp:ListItem>
                                    <asp:ListItem>0700</asp:ListItem>
                                    <asp:ListItem>0800</asp:ListItem>
                                    <asp:ListItem>0900</asp:ListItem>
                                    <asp:ListItem>1000</asp:ListItem>
                                    <asp:ListItem>1100</asp:ListItem>
                                    <asp:ListItem>1200</asp:ListItem>
                                    <asp:ListItem>1300</asp:ListItem>
                                    <asp:ListItem>1400</asp:ListItem>
                                    <asp:ListItem>1500</asp:ListItem>
                                    <asp:ListItem>1600</asp:ListItem>
                                    <asp:ListItem>1700</asp:ListItem>
                                    <asp:ListItem>1800</asp:ListItem>
                                    <asp:ListItem>1900</asp:ListItem>
                                    <asp:ListItem>2000</asp:ListItem>
                                    <asp:ListItem>2100</asp:ListItem>
                                    <asp:ListItem>2200</asp:ListItem>
                                    <asp:ListItem>2300</asp:ListItem>
                                </asp:DropDownList>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox runat="server" CssClass="form-control" ID="tbActivity7"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>
            </fieldset>
        </div>
        <div style="text-align: center">
            <asp:Button runat="server" Text="Confirm" CssClass="btn btn-primary" ID="AddTourConfirmation" OnClick="AddTourConfirmation_Click" />
        </div>
    </div>
</asp:Content>
