<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="AI_Forge_Web_App.AddProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--contact -->
    <div id="contact" class="contact">
         <div class="container">
            <div class="row">
               <div class="col-md-6 offset-md-3 ">
                  <div class="main_form">
                      <h1 style="color:aliceblue; text-align:center;">Add Product</h1>
                     <div class="row">
                        <div class="col-sm-12">
                           <input class="contactus" placeholder="Product Name" type="text" name="PName" id="PName" runat="server">
                        </div>                          
                         <div class="col-sm-12">
                           <input class="contactus" placeholder="Price" type="text" name="Price" id="price" runat="server">
                        </div>
                        <div class="col-sm-12">
                           <input class="contactus" placeholder="Description" type="text" name="desc" id="description" runat="server">
                        </div>
                        <div class="col-sm-12">
                           <input class="contactus" placeholder="Dimensions" type="text" name="dimensions" id="dimensions" runat="server">
                        </div>
                        <div class="col-sm-12">
                           <input class="contactus" placeholder="Category" type="text" name="Category" id="category" runat="server">
                        </div>
                        <div class="col-sm-12">
                           <input class="contactus" type="number" name="quantity" id="quantity" runat="server">
                        </div>
                        <div class="col-sm-12">
                           <asp:Button ID="btnSubmit" runat="server" class="send" Text="Add Product" style="width:420px;" OnClick="btnSubmit_Click"/>
                            &nbsp;
                        </div>
               </div>
            </div>
                   </div>
               </div>
            </div>

         </div>
      <!-- end contact -->
</asp:Content>
