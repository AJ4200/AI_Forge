<%@ Page Title="Delete Product" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="DeleteProduct.aspx.cs" Inherits="AI_Forge_Frontend.DeleteProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="contact" class="contact">
      <div class="container">
          <div class="row">
               <div class="col-md-6 offset-md-3 ">
                   <div class="main_form">
                      <h1 style="color:aliceblue; text-align:center;">Delete Product</h1>
                     <div class="row">
                        <div class="col-sm-12">
                           <input class="contactus" placeholder="Product Name" type="text" name="PName" id="Text1" runat="server">
                        </div>                          
                        <div class="col-sm-12">
                            <asp:Button ID="btnSubmit" runat="server" Text="Delete Product"  class="send" style="width:420px;" OnClick="btnSubmit_Click" />
                            &nbsp;</div>
                    </div>
                </div>
                   </div>
              </div>
          </div>
        </div>
</asp:Content>
