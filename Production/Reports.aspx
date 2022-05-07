<%@ Page Title="" Language="C#" MasterPageFile="~/Production.Master" AutoEventWireup="true" CodeBehind="Reports.aspx.cs" Inherits="Production.Reports" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="">
        <h2 class="text-center">
            <strong>REPORT CENTER</strong>
        </h2>
    </div>

<%--Weekly and Monthly buttons--%>
    <div class="text-center w3-margin-top">
        <asp:DropDownList ID="drpreportType" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="drpreportType_SelectedIndexChanged">
            <asp:ListItem Value="0" Selected="True" Text="SELECT REPORT TYPE" />
            <asp:ListItem Text="PRINTING REPORT" />
            <asp:ListItem  Text="DUPLICATES REPORT" />
            <asp:ListItem  Text="BLACKLIST REPORT" />
            <asp:ListItem  Text="REGISTRATION REPORTS" />
        </asp:DropDownList>
        <%--<asp:Button ID="weeklyreportbtn" runat="server" CssClass="btn btn-md alert-success" text="WEEKLY REPORT"/>
        <asp:Button ID="monthlyreportbtn" runat="server" CssClass="btn btn-md alert-success" text="MONTHLY REPORT"/>--%>
    </div>
<%--Search Div--%>
    <div class="w3-margin-top col-lg-12 row">
        <div class="col-lg-3">
            <div class="col-lg-4">
                <asp:Label ID="lblStartDate" Text="Start Date" runat="server" Visible="false" />
            </div>
            <div class="col-lg-8">
                <asp:TextBox ID="StartDate" runat="server" type="date" CssClass="form-control" Font-Size="X-Large" Visible="false" />
            </div>
        </div>
        <div class="col-lg-3">
            <div class="col-lg-4">
                <asp:Label ID="lblEndDate" Text="Start Date" runat="server" Visible="false" />
            </div>
            <div class="col-lg-8">
                <asp:TextBox ID="EndDate" runat="server" type="date" CssClass="form-control" Font-Size="X-Large" Visible="false" />
            </div>
             <%--<asp:TextBox ID="reportsearch" runat="server" type="date" CssClass="form-control" Font-Size="X-Large"></asp:TextBox>--%>
        </div>
        <div class="col-lg-6">
            <div class="col-lg-3">
                <%--<asp:CheckBox ID="chkDistrict" runat="server" Text="By District" TextAlign="Left" />--%>
                <asp:RadioButton ID="rd1" runat="server" GroupName="Controls" Text="" TextAlign="Right" Visible="false" />
            </div>
            <div class="col-lg-3">
                <%--<asp:CheckBox ID="chkUser" runat="server" Text="By User" TextAlign="Left"/>--%>
                <asp:RadioButton ID="rd2" runat="server" Text="" GroupName="Controls" TextAlign="Right" Visible="false" />
            </div>
            <%--<asp:Button ID="reportsearchbtn" runat="server" CssClass="btn btn-md btn-primary" Text="SEARCH" />--%>
        </div>          
    </div>

 <%--main Grid Div results--%>
    <div class="w3-margin-top">
        <asp:GridView ID="gridResult" runat="server" />
    </div>


</asp:Content>
