<%@ Page Title="" Language="C#" MasterPageFile="~/Production.Master" AutoEventWireup="true" CodeBehind="Reports.aspx.cs" Inherits="Production.Reports" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="">
        <h2 class="text-center">
            <strong>REPORT CENTER</strong>
        </h2>
    </div>

<%--Weekly and Monthly buttons--%>
    <div class="text-center w3-margin-top">
        <asp:DropDownList ID="drpreportType" runat="server" CssClass="form-control">
            <asp:ListItem Text="Printing Report" />
            <asp:ListItem  Text="Duplicates Report" />
            <asp:ListItem  Text="BlackList Report" />
            <asp:ListItem  Text="Registration Report" />
            <asp:ListItem Value="0" Selected="True" Text="SELECT REPORT TYPE" />
        </asp:DropDownList>
        <%--<asp:Button ID="weeklyreportbtn" runat="server" CssClass="btn btn-md alert-success" text="WEEKLY REPORT"/>
        <asp:Button ID="monthlyreportbtn" runat="server" CssClass="btn btn-md alert-success" text="MONTHLY REPORT"/>--%>
    </div>

<%--Search Div--%>
    <div class="w3-margin-top col-lg-12 row">
        <div class="col-lg-6"></div>
        <div class="col-lg-4">
             <%--<asp:TextBox ID="reportsearch" runat="server" type="date" CssClass="form-control" Font-Size="X-Large"></asp:TextBox>--%>
        </div>
        <div class="col-lg-2">
            <%--<asp:Button ID="reportsearchbtn" runat="server" CssClass="btn btn-md btn-primary" Text="SEARCH" />--%>
        </div>          
    </div>

 <%--main Grid Div results--%>
    <div class="w3-margin-top">

    </div>


</asp:Content>
