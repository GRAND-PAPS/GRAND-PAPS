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
        <rsweb:ReportViewer ID="ReportViewer1" runat="server" BackColor="" ClientIDMode="AutoID" HighlightBackgroundColor="" InternalBorderColor="204, 204, 204" InternalBorderStyle="Solid" InternalBorderWidth="1px" LinkActiveColor="" LinkActiveHoverColor="" LinkDisabledColor="" PrimaryButtonBackgroundColor="" PrimaryButtonForegroundColor="" PrimaryButtonHoverBackgroundColor="" PrimaryButtonHoverForegroundColor="" SecondaryButtonBackgroundColor="" SecondaryButtonForegroundColor="" SecondaryButtonHoverBackgroundColor="" SecondaryButtonHoverForegroundColor="" SplitterBackColor="" ToolbarDividerColor="" ToolbarForegroundColor="" ToolbarForegroundDisabledColor="" ToolbarHoverBackgroundColor="" ToolbarHoverForegroundColor="" ToolBarItemBorderColor="" ToolBarItemBorderStyle="Solid" ToolBarItemBorderWidth="1px" ToolBarItemHoverBackColor="" ToolBarItemPressedBorderColor="51, 102, 153" ToolBarItemPressedBorderStyle="Solid" ToolBarItemPressedBorderWidth="1px" ToolBarItemPressedHoverBackColor="153, 187, 226" Width="897px">
            <LocalReport ReportPath="Reports\Manifest.rdlc">
            </LocalReport>
        </rsweb:ReportViewer>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:INRS2ConnectionString %>" SelectCommand="select PIN, d.Name as District, c.Name as TA, v.Name as Village, Surname,FirstName,PrinterId,pc.EditUser from PersonCard pc
join Village v on v.VillageId=pc.PlaceOfRegistrationId
join Section s on s.SectionId=v.SectionId
join Chiefdom c on c.ChiefdomId=s.ChiefdomId
join District d on d.DistrictId=c.DistrictId
where ManifestId=1"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:INRS2ConnectionString %>" SelectCommand="PrintManifests" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    </div>
</asp:Content>
