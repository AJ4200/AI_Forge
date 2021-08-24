<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ClientProfile.aspx.cs" Inherits="AI_Forge_Web.ClientProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <title>My Account</title>
    <link href="ClientProfileStyle.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

          <h1>My Profile</h1>

   <div class="PersonalInfo">
    <h2><strong>Personal Details</strong></h2>
       <h3>Name </h3>
       <h3>Email Adress</h3>
       <h3>Mobile Number</h3>
   </div>

   <div class="Invoices">
       
       <h2>Previous Invoices</h2>

   </div>

    <div  class="Orders"><h2>Orders</h2></div>
    <div  class="LPoints">
        <h2>Loyalty Points</h2>
        <h3>Your loyalty points</h3>
    </div>
    <div  class="Reset-Password">
        
        <h2>Reset Password</h2>

    </div> 
</asp:Content>
