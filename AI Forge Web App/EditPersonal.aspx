<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="EditPersonal.aspx.cs" Inherits="AI_Forge_Web_App.EditPersonal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/TransationPage.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="PageEdit">
        <br />
        <div class="EditInfo">
            <h1 class="HeadPass">Edit your personal details</h1>
            <br />

            <label class="custom-field two">
  <input type="text" id="name" runat="server" style="width:720px;height:40px" placeholder="&nbsp;"/>
  <span class="placeholder">Name</span>
</label><br /><br />

            <label class="custom-field two">
  <input type="text" id="Surname" runat="server" style="width:720px;height:40px" placeholder="&nbsp;"/>
  <span class="placeholder">Surname</span>
</label><br /><br />

            <label class="custom-field two">
  <input type="email" id="Email" runat="server" style="width:720px;height:40px" placeholder="&nbsp;"/>
  <span class="placeholder">Email</span>
</label><br /><br />

            <label class="custom-field two">
  <input type="text" id="Number" runat="server" style="width:720px;height:40px" placeholder="&nbsp;"/>
  <span class="placeholder">Number</span>
</label><br /><br />

            <label class="custom-field two">
  <input type="text" id="Gender" runat="server" style="width:720px;height:40px" placeholder="&nbsp;"/>
  <span class="placeholder">Gender</span>
</label><br /><br />

             <label class="custom-field two">
  <input type="date" id="DOB" runat="server" style="width:720px;height:40px" placeholder="&nbsp;"/>
  <span class="placeholder">Date  of birth</span>
</label><br />

            <div class="error" id="error" runat="server">

            </div><br />
           
            <a href="Profile.aspx">
            <input class="button Cancel" type="button" value="Cancel" />
           </a>

            <input class="button ResetPassword_" type="submit" id="UpdatePersonal" runat="server" value="Update details" />
        </div>
    </div>
</asp:Content>
