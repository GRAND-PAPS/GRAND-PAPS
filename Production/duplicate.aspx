<%@ Page Title="" Language="C#" MasterPageFile="~/Production.Master" AutoEventWireup="true" CodeBehind="duplicate.aspx.cs" Inherits="Production.duplicate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row col-lg-12 w3-margin">
        <div class="col-lg-3"></div>
   <%--textbox search section--%>
        <div class="col-lg-6">
            <div class="col-lg-12 row">
                <div class="row">
                    <div class="col-lg-2"><asp:RadioButton ID="DuplicateRadioButton1" runat="server" CssClass="form-check-input" GroupName="Duplicates" OnCheckedChanged="DuplicateRadioButton1_CheckedChanged" AutoPostBack="true" /></div>                    
                    <div class="col-lg-10"><asp:TextBox ID="duplicateidtextbox" runat="server" CssClass="form-control" placeholder="DuplicateID"></asp:TextBox></div>
                </div>
                <div class="row">
                    <div class="col-lg-2"><asp:RadioButton ID="DuplicateRadioButton2" runat="server" CssClass="form-check-input" GroupName="Duplicates" OnCheckedChanged="DuplicateRadioButton2_CheckedChanged" AutoPostBack="true" /></div>                    
                   <div class="col-lg-10"><asp:TextBox ID="Personidtextbox" runat="server" CssClass="form-control" placeholder="PersonID"></asp:TextBox></div>
                </div>
                <asp:Button ID="duplicatebtn" runat="server" CssClass="btn btn-primary btn-block w3-margin" Text="Search" />
            </div>
        </div>
        <div class="col-lg-3"></div>
    </div>

       <%--Search results--%>
    <div class="col-lg-12">
        <div class="col-lg-6 w3-margin">

        </div>
        <div class="col-lg-6 w3-margin">

        </div>
    </div>
</asp:Content>
