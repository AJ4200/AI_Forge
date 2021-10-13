<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="addressEdit.aspx.cs" Inherits="AI_Forge_Web_App.addressEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link href="css/TransationPage.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="PageEdit">
        <br />
        <div class="EditInfo">
            <h1 class="HeadPass">Edit your address</h1>
            <br />

            <label class="custom-field two">
  <input type="text" id="StrAddress" runat="server" style="width:720px;height:40px" placeholder="&nbsp;"/>
  <span class="placeholder">Street Address</span>
</label><br /><br />

 <label class="custom-field two">
  <input type="text" id="suburb" runat="server" style="width:720px;height:40px" placeholder="&nbsp;"/>
  <span class="placeholder">Suburb</span>
</label><br /><br />

             <label class="custom-field two">
  <input type="text" id="CityTown" runat="server" style="width:720px;height:40px" placeholder="&nbsp;"/>
  <span class="placeholder">City/Town</span>
</label><br /><br />

             <label class="custom-field two">
  <input type="text" id="Province" runat="server" style="width:720px;height:40px" placeholder="&nbsp;"/>
  <span class="placeholder">Province</span>
</label><br /><br />

            <label class="custom-field two">
  <input type="text" id="PostalCode" runat="server" style="width:250px;height:40px" placeholder="&nbsp;"/>
  <span class="placeholder">Postal Code</span>
</label><br /><br />
            <div class="PassError" id="PassError" runat="server">

           </div>

<a href="Profile.aspx">
            <input class="button Cancel" type="button" value="Cancel" />
           </a>

            <input class="button ResetPassword_" type="submit" id="UpdateAddress" runat="server" value="Update Address" />
        </div>
    </div>
</asp:Content>
