<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="PasswordReset.aspx.cs" Inherits="AI_Forge_Web_App.PasswordReset" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/TransationPage.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <section>

       <div class="password">

           <h1 class="HeadPass"><strong>Reset Password</strong></h1>

           <label class="custom-field pass">
  <input type="password" style="width:720px" required="required"/>
  <span class="placeholder">Enter Current Password</span>
</label>
            <br /><br />

            <label class="custom-field pass">
  <input type="password" style="width:720px" class="Pass-Input" required=" required"/>
  <span class="placeholder">New password</span>
</label>
           <br /><br />

            <label class="custom-field pass">
  <input type="password" style="width:720px" class="Pass-Input" required=" required"/>
  <span class="placeholder">Re-enter new password</span>
</label> <br /><br /><br />

           <a href="ClientProfile.aspx">
            <input class="button Cancel" type="button" value="Cancel" />
           </a>

           <input class="button ResetPassword_" type="submit" value="Reset" />
       </div>
            </section>
</asp:Content>
