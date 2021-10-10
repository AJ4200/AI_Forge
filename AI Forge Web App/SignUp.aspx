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
                                <input ID="name" class="contactus" placeholder="Name" type="text" required="required" data-error="Name is required." runat="server">
                            </div>
                            <div class="col-sm-12">
                                <input ID="surname" class="contactus" placeholder="Surname" type="text" required="required" data-error="Surname is required." runat="server">
                            </div>
                            <div class="col-sm-12">
                                <input ID="Email" class="contactus" placeholder="Email" type="text" required="required" data-error="Email is required." runat="server">
                            </div>
                            <div class="col-sm-12">
                                <input ID="phone" class="contactus" placeholder="Phone" type="text" required="required" data-error="Phone is required." runat="server">
                            </div>
                            <div class="col-sm-12">
                                <input ID="gender" class="contactus" placeholder="Gender" type="text" required="required" data-error="Gender is required." runat="server">
                            </div>
                            <div class="col-sm-12">
                                <input ID="dob" class="contactus" placeholder="Date Of Birth" type="date" runat="server">
                            </div>
                            <div class="col-sm-12">
                                <input ID="Address" class="contactus" placeholder="Address" type="text" required="required" data-error="Address is required." runat="server">
                            </div>
                            <div class="col-sm-12">
                                <input ID="password" class="contactus" placeholder="Enter New Password" type="password" required="required" data-error="Password is required." runat="server">
                            </div>
                            <div class="col-sm-12">
                                <input ID="re_password" class="contactus" placeholder="Re-enter New Password" type="password" required="required" data-error="Password do not match." runat="server">
                            </div>
                            <div class="col-sm-12">                   
                                <asp:Button ID="btnSignup" class="send" runat="server" Text="Sign Up" Width="100%" OnClick="btnSignup_Click" /> 
                           </div>
                        </div>
                    </div>
                </div>
            </div>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <!-- end contact -->

        </div>
    </div>
</asp:Content>
