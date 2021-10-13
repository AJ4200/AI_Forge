<%@ Page Title="My Account" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="AI_Forge_Web_App.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="css/ClientProfileStyle.css" rel="stylesheet" />
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="foot">
       <div class="page">
        <div class="header">
            My Account
        </div>

        <div class="Personal-Info">
            <h3>Name </h3>
            <h3>Email Address</h3>
            <h3>Mobile Number</h3>
            <h3>Gender</h3>
            <h3>Date of Birth</h3>
            <h3>Address</h3>

            <div class="HardCode" id="HardCode" runat="server">
                
</div>
             <a href="EditPersonal.aspx">
            <input class="button EditDetails" type="button" value="Edit personal details" />
           </a>

            <a href="addressEdit.aspx">
            <input class="button Invoices" type="button" value="Update Address" />
           </a>

           <a href="PasswordReset.aspx">
            <input class="button Reset-Password" type="button" value="Reset Password" />
           </a>
        </div>
        </div>
    </div>

       

    
        
</asp:Content>
