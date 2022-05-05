<%@ Page Title="" Language="C#" MasterPageFile="~/Production.Master" AutoEventWireup="true" CodeBehind="blacklist.aspx.cs" Inherits="Production.blacklist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%--First div and Log in User; search option--%>
    <div class="col-lg-12 w3-margin-16">
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
     </div>

         <%-- Second Div and headings--%>
        <div class="col-lg-12 row mt-4 w3-margin-16">
            <div class="col-lg-3">

                Select District: 
                <asp:DropDownList ID="DistrictDropDown" runat="server" AutoPostBack="true" 
                    DataTextField="Name" DataValueField="DistrictId" 
                    OnSelectedIndexChanged="DistrictDropDown_SelectedIndexChanged">
                    <%--<asp:ListItem Value="0">SELECT DISTRICT</asp:ListItem>--%>
                </asp:DropDownList>
                <br /><br />
                Select TA:
                <asp:DropDownList ID="TADropDown" runat="server" DataTextField="Name" AutoPostBack="true" 
                     DataValueField="chiefdomid" OnSelectedIndexChanged="TADropDown_SelectedIndexChanged" >
                    <asp:ListItem Value="0">SELECT TA</asp:ListItem>
                </asp:DropDownList>
                
            </div>
            <%--search section--%>
            <div class="col-lg-5 text-right">
                <div class="row">
                    <div class="col-lg-2"><asp:RadioButton ID="RadioButton1" CssClass="form-check-input" runat="server" GroupName="Controls" 
                        OnCheckedChanged="RadioButton1_CheckedChanged" AutoPostBack="true"/></div>
                    <div class="col-lg-10"><asp:TextBox ID="Persontextbox" Enabled="false" CssClass="form-control form-control-sm" Placeholder="Person ID" runat="server"></asp:TextBox></div>                   
                </div>
                <div class="row">
                    <div class="col-lg-2"><asp:RadioButton ID="RadioButton2" CssClass="form-check-input" runat="server" GroupName="Controls" 
                        OnCheckedChanged="RadioButton2_CheckedChanged" AutoPostBack="true"/></div>
                    <div class="col-lg-10"><asp:TextBox ID="Pintextbox" Enabled="false" CssClass="form-control form-control-sm" Placeholder="Pin ID" runat="server"></asp:TextBox></div>                    
                </div>
                <div class="col-lg-12 w3-margin"><asp:Button ID="blacklistsearchbtn" Text="search" runat="server" CssClass="btn btn-primary btn-block col-sm-3" /></div>                     
            </div>

            <%--image section--%>
            <div class="col-lg-4">
                <h5 class="text-center">PERSON IMAGE</h5>
            </div>
        </div>

      <%--Third Div and Person Info--%>
        <div class="col-lg-12 row mt-4 w3-margin">
        


                <asp:GridView ID="dataGridView1" CssClass="table table-hover" runat="server" Width="10%" CellPadding="4" ForeColor="#333333" 
                    AutoGenerateSelectButton="true" GridLines="None" AllowPaging="True" OnSelectedIndexChanged="dataGridView_SelectedIndexChanged" >

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

            <%--Person Information after searched--%>
            <div class="col-lg-4">
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
                    <asp:Label ID="blacklistedlbi" runat="server" Font-Bold="true" Font-Size="X-Large" CssClass="text-danger"></asp:Label>
                    <asp:Label ID="removedblacklistedlbl" runat="server" Font-Bold="true" Font-Size="X-Large" CssClass="text-success"></asp:Label>
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

   
</asp:Content>
