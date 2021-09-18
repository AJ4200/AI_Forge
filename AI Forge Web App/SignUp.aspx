<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="AI_Forge_Web_App.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="css/Register.css">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        
        <!-- register -->
    <div class="register">
      <i class="fas fa-user-circle"></i>
      <strong>Create account!</strong>
     
        <fieldset>
          <div class="form">
            <div class="form-row">
              <i class="fas fa-user"></i>
              <label class="form-label" for="input">Name</label>
              <input type="text" class="form-text" placeholder="enter your name">
            </div>
            <div class="form-row">
              <i class="fas fa-envelope"></i>
              <label class="form-label" for="input">E-mail</label>
              <input type="text" class="form-text" placeholder="enter your e-mail">
            </div>
            <div class="form-row">
              <i class="fas fa-lock"></i>
              <label class="form-label" for="input">Password</label>
              <input type="text" class="form-text" placeholder="enter a name">
            </div>
            <div class="form-row button-login">
              <button class="btn btn-login">Create <i class="fas fa-arrow-right"></i></button>
            </div>
          </div>
        </fieldset>

      <span class="create-account">Or create account using social media!</span>

      <div class="social-media">
        <i class="fab fa-facebook"></i>
        <i class="fab fa-twitter"></i>
      </div>
    </div>

</asp:Content>
