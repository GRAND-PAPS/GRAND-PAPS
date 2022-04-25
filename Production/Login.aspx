<%@ Page Title="" Language="C#" MasterPageFile="~/Production.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Production.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-lg-12 row w3-margin">
        <div class="col-lg-3"></div>
        <div class="col-lg-6">
            <div class="col-md-12">
                <asp:Label ID="reportUsernamelbl" runat="server" CssClass="fs-3 form-group" Font-Size="Larger" Font-Bold="true">USERNAME:</asp:Label>
                <asp:TextBox ID="textUsername" Type="text" runat="server" CssClass="fs-3 form-group" Font-Size="XX-Large"></asp:TextBox>
            </div>
            <div class="col-md-12">
                <asp:Label ID="reportpasswordlbl" runat="server" CssClass="fs-3 form-group" Font-Size="Larger" Font-Bold="true">PASSWORD:</asp:Label>
                <asp:TextBox ID="reportpassword" Type="Password" runat="server" CssClass="fs-3 form-group" Font-Size="XX-Large"></asp:TextBox>
            </div>
            <div class="col-md-12">
                <asp:Button ID="reportsubmitbtn" runat="server" CssClass="btn btn-lg btn-primary" Text="LOG IN"/>
            </div>
        </div>
        <div class="col-col-lg-3"></div>
    </div>


</asp:Content>
