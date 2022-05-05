<%@ Page Title="" Language="C#" MasterPageFile="~/Production.Master" AutoEventWireup="true" CodeBehind="duplicate.aspx.cs" Inherits="Production.duplicate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row col-lg-12 w3-margin">
        <div class="col-lg-3"></div>
   <%--textbox search section--%>
        <div class="col-lg-6">
            <div class="col-lg-12 row">
                <div class="row">
                    <div class="col-lg-2"><asp:RadioButton ID="DuplicateRadioButton2" runat="server" CssClass="form-check-input" GroupName="Duplicates" 
                        OnCheckedChanged="DuplicateRadioButton2_CheckedChanged" AutoPostBack="true" /></div>                    
                   <div class="col-lg-10"><asp:TextBox Enabled="false" ID="Personidtextbox" runat="server" CssClass="form-control" placeholder="PersonID"></asp:TextBox></div>
                </div>
                <div class="row">
                    <div class="col-lg-2"><asp:RadioButton ID="DuplicateRadioButton1" runat="server" CssClass="form-check-input" 
                        GroupName="Duplicates" OnCheckedChanged="DuplicateRadioButton1_CheckedChanged" AutoPostBack="true"  /></div>                    
                    <div class="col-lg-10"><asp:TextBox Enabled="false" ID="duplicateidtextbox" runat="server" CssClass="form-control" placeholder="DuplicateID"></asp:TextBox></div>
                </div>
                
                <asp:Button ID="duplicatebtn" runat="server" CssClass="btn btn-primary btn-block w3-margin" Text="Search" OnClick="duplicatebtn_Click" />
            </div>
        </div>
        <div class="col-lg-3"></div>
    </div>

       <%--Search results--%>
    <div class="col-lg-12">
       <div class="col-lg-12">
            
            <asp:GridView ID="ResultGridView" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="113%">
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
      <%--  <div class="col-lg-12">
            
            <asp:Repeater ID="rptTable" runat="server" >
                <HeaderTemplate>
                    <table class="table">
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td colspan="5"><center> Applicant Details</center></td>
                        <td colspan="5"><center>Duplicate Details</center></td>
                    </tr>
                    <tr>
                        <td>Personal ID</td>
                        <td>Surname</td>
                        <td>Othernames</td>
                        <td>Firstname</td>
                        <td>Date of Registration</td>
                        <td>Duplicate ID</td>
                        <td>Surname</td>
                        <td>Othernames</td>
                        <td>Firstname</td>
                        <td>Date of Registration</td>
                    </tr>
                    <tr>
                        <td width="*"><%# Eval("PersonId") %></td>
                        <td width="*"><%# Eval("Surname") %></td>
                        <td width="*"><%# Eval("Othernames") %></td>
                        <td width="*"><%# Eval("Firstname") %></td>
                        <td width="*"><%# Eval("ApplicantDateofRegistration") %></td>

                        <td width="*"><%# Eval("DuplicateId") %></td>
                        <td width="*"><%# Eval("Surname") %></td>
                        <td width="*"><%# Eval("othernames") %></td>
                        <td width="*"><%# Eval("firstname") %></td>
                        <td width="*"><%# Eval("DuplicateDateofRegistration") %></td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>


        </div>--%>
    </div>
</asp:Content>
