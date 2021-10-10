<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="ProductManagement.aspx.cs" Inherits="AI_Forge_Web_App.ProductManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="contact" class="contact">
         <div class="container">
            <div class="row">
               <div class="col-md-6 offset-md-3 ">
                  <div class="main_form">
                      <h1 style="color:aliceblue; text-align:center;">Add Product</h1>
                     <div class="row">
                         <div class="col-sm-12" id="divSearch" runat="server">
                             <label for="search">Search Product</label>
                             <asp:DropDownList class="contactus" ID="ddlProducts" runat="server" OnTextChanged="ddlProducts_TextChanged">
                             </asp:DropDownList>
                             <asp:Button ID="btnSearch" runat="server" class="send" Text="Search" style="width:420px;" OnClick="btnSearch_Click"/>
                         </div>
                        <div class="col-sm-12" id="divName" runat="server">
                           <input class="contactus" placeholder="Product Name" type="text" name="PName" id="name" runat="server" required>
                        </div>                          
                         <div class="col-sm-12" id="divPrice" runat="server">
                           <input class="contactus" placeholder="Price" type="text" name="Price" id="price" runat="server" required>
                        </div>   
                        <div class="col-sm-12" id="divImage" runat="server">
                           <input class="contactus" placeholder="Image Path" type="text" name="imgPath" id="imgPath" runat="server" required>
                        </div>
                        <div class="col-sm-12" id="divDescription" runat="server">
                            <input class="contactus" placeholder="Description" type="text" name="Description" id="description" runat="server" required>
                        </div>
                        <div class="col-sm-12" id="divCategory" runat="server">
                           <select class="contactus" name="Category" id="categories" runat="server" required>
                               <option value="0">General</option>
                               <option value="1">Security</option>
                               <option value="2">Kitchen</option>
                               <option value="3">Bedroom</option>
                               <option value="4">Bathroom</option>
                               <option value="5">Living Room</option>
                           </select>
                        </div>
                        <div class="col-sm-12" id="divAdd" runat="server">
                           <asp:Button ID="btnAdd" runat="server" class="send" Text="Add Product" style="width:420px;" OnClick="btnAdd_Click1"/>
                        </div>
                        <div class="col-sm-12" id="divEdit" runat="server">
                           <asp:Button ID="btnEdit" runat="server" class="send" Text="Edit Product" style="width:420px;" OnClick="btnEdit_Click"/>
                        </div>
                        <div class="col-sm-12" id="divDelete" runat="server">
                           <asp:Button ID="btnDelete" runat="server" class="send" Text="Delete Product" style="width:420px;" OnClick="btnDelete_Click"/>
                        </div>
               </div>
            </div>
                   </div>
               </div>
            </div>

         </div>

</asp:Content>
