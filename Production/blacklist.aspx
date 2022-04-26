<%@ Page Title="" Language="C#" MasterPageFile="~/Production.Master" AutoEventWireup="true" CodeBehind="blacklist.aspx.cs" Inherits="Production.blacklist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%--First div and Log in User; search option--%>
    <div class="col-lg-12">
        <div class="row">
            <div class="col-lg-3">

            </div>
            <div class="col-lg-5">

            </div>
            <div class="col-lg-4">
                <asp:Label ID="timelabel" CssClass="text-center form-control" Text="LOG IN TIME" Font-Size="Larger" Font-Bold="true" runat="server"></asp:Label>
                <asp:Label ID="usernamelabel" CssClass="text-center form-control" Text="APPLICATION USERNAME" Font-Size="Larger" Font-Bold="true" runat="server"></asp:Label>
            </div>
        </div>
        

         <%-- Second Div and headings--%>
        <div class="col-lg-12 row mt-4 w3-margin-16">
            <div class="col-lg-3">

                Select District: 
                <asp:DropDownList ID="DistrictDropDown" runat="server" AutoPostBack="true" 
                    DataTextField="Name" DataValueField="DistrictId" 
                    OnSelectedIndexChanged="DistrictDropDown_SelectedIndexChanged" />
                <br /><br />
                Select TA:
                <asp:DropDownList ID="TADropDown" runat="server" DataTextField="Name"
                     DataValueField="chiefdomid" >
                    <asp:ListItem Value="0">SELECT TA</asp:ListItem>
                </asp:DropDownList>
                
            </div>
            <div class="col-lg-5">
                <h5 class="text-center">PERSON INFORMATION</h5>
            </div>
            <div class="col-lg-4">
                <h5 class="text-center">PERSON IMAGE</h5>
            </div>
        </div>

      <%--Third Div and Person Info--%>
        <div class="col-lg-12 row mt-4 w3-margin-16">
          <%--  Data Grid--%>
            <div class="col-lg-3">
                <asp:GridView ID="dataGridView" CssClass="table table-hover" runat="server" />
            </div>

            <%--Person Information after searched--%>
            <div class="col-lg-5">
                <div class="w3-margin-12">
                        <label class="m5">Firstname:</label>
                        <asp:Label ID="bfirstnamelbl" CssClass="" runat="server" Font-Bold="true" Font-Size="Larger" Font-Italic="true" Text="MMMM"></asp:Label>
                </div>
                <div class="w3-margin-12">
                        <label class="m5">Othernames:</label>
                        <asp:Label ID="bothernameslbl" CssClass="" runat="server" Font-Bold="true" Font-Size="Larger" Font-Italic="true" Text="SSSS"></asp:Label>
                </div>
                <div class="w3-margin-12">
                        <label class="m5">Surname:</label>
                        <asp:Label ID="bsurnamelbl" CssClass="" runat="server" Font-Bold="true" Font-Size="Larger" Font-Italic="true" Text="SSSS"></asp:Label>
                </div>
                <div class="w3-margin-12">
                        <label class="m5">Date Of Birth:</label>
                        <asp:Label ID="bDOBlbl" CssClass="" runat="server" Font-Bold="true" Font-Size="Larger" Font-Italic="true" Text="MMMM"></asp:Label>
                </div>
                <div class="w3-margin-12">
                        <label class="m5">Date Of Registration:</label>
                        <asp:Label ID="bRegistrationlbl" CssClass="" runat="server" Font-Bold="true" Font-Size="Larger" Font-Italic="true" Text="SSSS"></asp:Label>
                </div>
                <div class="w3-margin-12">
                        <label class="m5">Distric:</label>
                        <asp:Label ID="bDistrict" CssClass="" runat="server" Font-Bold="true" Font-Size="Larger" Font-Italic="true" Text="SSSS"></asp:Label>
                </div>
                
               <%-- Blacklist Status--%>
                <div class="w3-margin-24 text-center">
                    <asp:Label ID="blacklistedlbi" runat="server" Font-Bold="true" Font-Size="X-Large" Text="Blacklisted" CssClass="text-danger"></asp:Label>
                    <asp:Label ID="removedblacklistedlbl" runat="server" Font-Bold="true" Font-Size="X-Large" Text="Blacklisted Removed SuccessFully" CssClass="text-success"></asp:Label>
                </div>

                <%--button for Blacklist and Remove--%>
                <div class="col-lg-12 row">
                    <div class="col-lg-6">
                        <asp:Button ID="Blacklistbtn" runat="server" CssClass="btn btn-danger" Text="BLACKLIST RECORD" /> 
                    </div>
                    <div class="col-lg-6 text-right">
                        <asp:Button ID="removeblacklistbtn" runat="server" CssClass="btn btn-success" Text="REMOVE BLACKLIST" />
                    </div>
                </div>

            </div>
            <div class="col-lg-4">
                
               <%-- image for the Person--%>
                <div class="" style="height:260px;">
                    
                </div>
                <div class="w3-margin-24 text-center">
                    <asp:Label ID="blacklistagelbl" runat="server" CssClass="text-info" Font-Bold="true" Font-Size="XX-Large" Text="00"></asp:Label>
                </div>
            </div>
            
        </div>

    </div>
</asp:Content>
