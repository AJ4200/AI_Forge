<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="AI_Forge_Web_App.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
          <!-- contact -->
      <div id="contact" class="contact">
         <div class="container">
            <div class="row">
               <div class="col-md-6 offset-md-3 ">
                   <form class="main_form">
                       <div class="row">
                           <div class="col-sm-12">
                               <input class="contactus" placeholder="Full Name" type="text" name="Name">
                           </div>
                           <div class="col-sm-12">
                               <input class="contactus" placeholder="Email" type="text" name=" Email">
                           </div>
                           <div class="col-sm-12">
                               <input class="contactus" placeholder="Phone" type="text" name="Phone">
                           </div>
                           <div class="col-sm-12">
                               <textarea class="textarea" placeholder="Message" type="text" name="Message"></textarea>
                           </div>
                           <div class="col-sm-12">
                               <button class="send">Sign Up</button>
                           </div>
                       </div>
                   </form>
               </div>
            </div>
         </div>
      </div>
 </asp:Content>
