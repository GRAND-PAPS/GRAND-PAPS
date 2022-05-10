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
                <asp:Label ID="lblStartDate" Font-Bold="true" Text="Start Date" runat="server" Visible="false" />
            </div>
            <div class="col-lg-8">
                <asp:TextBox ID="StartDate" runat="server" type="date" CssClass="form-control" Font-Size="X-Large" Visible="false" />
            </div>
        </div>
        <div class="col-lg-3">
            <div class="col-lg-4">
                <asp:Label ID="lblEndDate" Font-Bold="true" Text="Start Date" runat="server" Visible="false" />
            </div>
            <div class="col-lg-8">
                <asp:TextBox ID="EndDate" runat="server" type="date" CssClass="form-control" Font-Size="X-Large" Visible="false" />
            </div>
             <%--<asp:TextBox ID="reportsearch" runat="server" type="date" CssClass="form-control" Font-Size="X-Large"></asp:TextBox>--%>
        </div>
        <div class="col-lg-4">
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
        <div class="col-lg-2">
            <asp:Button Text="Load" runat="server" ID="btnLoad" CssClass="btn btn-primary" OnClick="btnLoad_Click" />
        </div>
    </div>

 <%--main Grid Div results--%>
    <div class="w3-margin-top">
        <asp:GridView ID="gridResult" runat="server" CellPadding="4" ForeColor="#333333" GridLines="Both" BorderStyle="Double">
            <AlternatingRowStyle BackColor="White"></AlternatingRowStyle>

            <EditRowStyle BackColor="#2461BF"></EditRowStyle>

            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White"></FooterStyle>

            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White"></HeaderStyle>

            <PagerStyle HorizontalAlign="Center" BackColor="#2461BF" ForeColor="White"></PagerStyle>

            <RowStyle BackColor="#EFF3FB"></RowStyle>

            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333"></SelectedRowStyle>

            <SortedAscendingCellStyle BackColor="#F5F7FB"></SortedAscendingCellStyle>

            <SortedAscendingHeaderStyle BackColor="#6D95E1"></SortedAscendingHeaderStyle>

            <SortedDescendingCellStyle BackColor="#E9EBEF"></SortedDescendingCellStyle>

            <SortedDescendingHeaderStyle BackColor="#4870BE"></SortedDescendingHeaderStyle>
        </asp:GridView>
    </div>


</asp:Content>
