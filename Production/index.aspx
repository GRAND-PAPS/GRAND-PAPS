<%@ Page Title="" Language="C#" MasterPageFile="~/Production.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Production.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <nav class="w3-margin-top">        
        <h2 class="text-center">
            <strong>
                <span>PRODUCTION DASHBOARD</span> 
            </strong>
        </h2>
    </nav>

<%--    <div class="col-lg-12">

        <div class="col-sm-12 row">
            <div class="w3-card-12 col-sm-4">
                <div class="w3-card-8">
                    <h4 class="text-info text-center"><strong>TODAY TOTAL PRINTED</strong></h4>
                </div>    
                <div class="alert text-right">
                    <asp:Label CssClass="" ID="printedtoday" runat="server" Font-Size="XX-Large" Font-Bold="true">000</asp:Label>
                </div>            
            </div>

            <div class="w3-card-12 col-sm-4">
                <div class="w3-card-8">
                    <h4 class="text-info text-center"><strong>DAY SHIFT</strong></h4>
                </div>    
                <div class="alert text-right">
                    <asp:Label CssClass="" ID="dayshiftprinted" runat="server" Font-Size="XX-Large" Font-Bold="true">000</asp:Label>
                </div>            
            </div>

            <div class="w3-card-12 col-sm-4">
                <div class="w3-card-8">
                    <h4 class="text-info text-center"><strong>NIGHT SHIFT</strong></h4>
                </div>    
                <div class="alert text-right">
                    <asp:Label CssClass="text-left" ID="nightshiftprinted" runat="server" Font-Size="XX-Large" Font-Bold="true">000</asp:Label>
                </div>            
            </div>
        </div>
    </div>--%>

   <%-- Divs contain Offices --%>
    <div class="row col-lg-12 w3-margin-16">
        <div class="col-sm-6 alert w3-card-4">
            <div class="">
                <h4><strong>OFFICERS:</strong></h4>
                <asp:Panel ID="Officerspanel" runat="server" CssClass="mt-3"></asp:Panel>
            </div>
        </div>
        <div class="col-sm-6 alert w3-card-4">
            <div class="">
                <h4><strong>DISTRICTS:</strong></h4>
                <asp:Panel ID="Districtpanel" runat="server" CssClass="mt-3"></asp:Panel>
            </div>
        </div>
    </div>

   <%-- Divs contain Districts Printed --%>
   <%--  <div class="row col-lg-12 w3-margin-16">
        <div class="col-sm-6 alert w3-card-4">
            <div class="">
                <h4><strong>DAY DISTRICTS:</strong></h4>
            </div>
        </div>
        <div class="col-sm-6 alert w3-card-4">
            <div class="">
                <h4><strong>NIGHT DISTRICTS:</strong></h4>
            </div>
        </div>
    </div>--%>

</asp:Content>
