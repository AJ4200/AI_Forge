<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="AI_Forge_Web_App.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
          <!-- contact -->
      <div id="contact" class="contact">
         <div class="container">
            <div class="row">
               <div class="col-md-6 offset-md-3 ">
                  <div class="main_form">
                     <div class="row">
                        <div class="col-sm-12">
                           <input class="contactus" placeholder="Name" type="text" name="Name">
                        </div>                          
                         <div class="col-sm-12">
                           <input class="contactus" placeholder="Surname" type="text" name="Surname">
                        </div>
                        <div class="col-sm-12">
                           <input class="contactus" placeholder="Email" type="text" name=" Email">
                        </div>
                        <div class="col-sm-12">
                           <input class="contactus" placeholder="Phone" type="text" name="Phone">
                        </div>
                        <div class="col-sm-12">
                           <input class="contactus" placeholder="Gender" type="text" name="Gender">
                        </div>
                        <div class="col-sm-12">
                           <input class="contactus" placeholder="Date Of Birth" type="date" name="DoB">
                        </div>
                        <div class="col-sm-12">
                           <input class="contactus" placeholder="Address" type="text" name="Address">
                        </div>
                         <br>
                        <div class="col-sm-12">
                           <input class="contactus" placeholder="Username" type="text" name="Username">
                        </div>
                        <div class="col-sm-12">
                           <input class="contactus" placeholder="Enter New Password" type="password" name="Password">
                        </div>
                        <div class="col-sm-12">
                           <input class="contactus" placeholder="Re-enter New Password" type="password" name="Password">
                        </div>
                        <div class="col-sm-12">
                           <button class="send">Sign Up</button>
                        </div>
                     </div>
                  </div>
               </div>
            </div>
         </div>
      </div>

      <!-- end contact -->
 </asp:Content>
