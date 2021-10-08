<%@ Page Title="Update Product" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="EditProduct.aspx.cs" Inherits="AI_Forge_Frontend.EditProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="contact" class="contact">
    <div class="container">
          <div class="row">
               <div class="col-md-6 offset-md-3 ">
            <div class="main_form">
                <h1 style="color:aliceblue; text-align:center;">Edit Product</h1>
                <div class="row">
                <div class="col-sm-12">
                    <input class="contactus" placeholder="Product Name" type="text" name="PName" id="Text2" runat="server">
                </div>    
                  <div class="col-sm-12">
                           <input class="contactus" placeholder="Price" type="text" name="Price" id="Text3" runat="server">
                    </div>
                   <div class="col-sm-12">
                           <input class="contactus" placeholder="Description" type="text" name="desc" id="Text4" runat="server">
                    </div>
                      <div class="col-sm-12">
                        <input class="contactus" placeholder="Dimensions" type="text" name="dimensions" id="Text5" runat="server">
                     </div>
                      <div class="col-sm-12">
                           <input class="contactus" placeholder="Category" type="text" name="Category" id="Text6" runat="server">
                        </div>
                        <div class="col-sm-12">
                           <input class="contactus" type="number" name="quantity" id="Number1" runat="server">
                        </div>
                     <div class="col-sm-12">
                           <input class="contactus" type="number" name="Sale" id="number" runat="server">
                        </div>
                    <div class="col-sm-12">
                           <input class="contactus" placeholder="Sale Price" type="text" name="SalePrice" id="Text7" runat="server">
                    </div>
                     <div class="col-sm-12">
                           <input class="contactus" placeholder="Sale Description" type="text" name="Sale Description" id="Text8" runat="server">
                        </div>
                <div class="col-sm-12">
                    <a href="ClientProfile.aspx">
                            <input class="send" type="button" value="Edit Product" style="width:420px;"/>
                        </a>
                </div>
            </div>
        </div>
         </div>
      </div>
                 
         </div>
      </div>
</asp:Content>
