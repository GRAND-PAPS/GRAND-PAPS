<%@ Page Title="" Language="C#" MasterPageFile="~/Production.Master" AutoEventWireup="true" CodeBehind="manifest.aspx.cs" Inherits="Production.manifest" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

 <%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=15.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="">
        <h2 class="text-center">
            <strong>MANIFEST GENERATOR</strong>
        </h2>
    </div>

    <%--Search Div--%>
    <div class="w3-margin-top col-lg-12 row">
        <%-- IN CORRECT ID NUMBER label --%>
        <div class="col-lg-6 text-center">
            <asp:Label ID="incorrectid" runat="server" CssClass="text-danger" Font-Bold="true" Font-Size="X-Large"></asp:Label>
        </div>

        <div class="col-lg-4">
             <asp:TextBox ID="manifestsearch" runat="server" type="text" placeholder="ID NUMBER" CssClass="form-control text-uppercase" Font-Size="Larger"></asp:TextBox>
        </div>
        <div class="col-lg-2">
            <asp:Button ID="manifestsearchbtn" runat="server" CssClass="btn btn-md btn-primary" Text="SEARCH" OnClick="manifestsearchbtn_Click"/>
        </div>          
    </div>

<%--Manifest Labels results--%>
    <div class="w3-margin-top row col-lg-12">
        <div class="col-lg-3 text-center">
            <h4><strong>DISTRICT:</strong></h4>
            <asp:label ID="districtlbl" runat="server" cssClass="" Font-Bold="true"> District Name</asp:label>
        </div>
        <div class="col-lg-3 text-center">
            <h4><strong>VILLAGE:</strong></h4>
            <asp:Label ID="villagelbl" runat="server" CssClass="" Font-Bold="true"> Village Name</asp:Label>
        </div>
        <div class="col-lg-3 text-center">
            <h4><strong>TOTAL ON MANIFEST:</strong></h4>
            <asp:Label ID="manifesttotallbl" runat="server" CssClass="" Font-Bold="true">Manifest Total Printed</asp:Label>
        </div>
        <div class="col-lg-3 text-center">
            <h4><strong>PRINTED BY:</strong></h4>
            <asp:Label ID="edituserlbl" runat="server" CssClass="" Font-Bold="true">Name of User</asp:Label>
        </div>
    </div>



 <%--main Grid Div of manifest results--%>
    <div class="w3-margin-top">
       
    </div>
</asp:Content>
