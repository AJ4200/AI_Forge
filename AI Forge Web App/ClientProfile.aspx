<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="ClientProfile.aspx.cs" Inherits="AI_Forge_Web_App.ClientProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <title>My Account</title>
    <link href="css/ClientProfileStyle.css" rel="stylesheet" />
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <div class="page">
        <div class="header">
            My Account
        </div>

        <div class="Personal-Info">
            <h3>Name </h3>
            <h3>Email Address</h3>
            <h3>Mobile Number</h3>
        </div>

        <br>
        <button class="button Invoices">Get Previous Invoices</button>
        <br>
        <button class="button Reset-Password">Reset Password</button>

    </div> 
</asp:Content>
