<%@ Page Title="About Product" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Item.aspx.cs" Inherits="AI_Forge_Web_App.Item" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="stylesheet" href="css/Products.css">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="container2">
        <div class="box">
            <div id="imgdiv" runat="server" class="product__img">
                
            </div>
            <div class="product__disc">
                <div class="product__disc--content">
                    <div class="disc__content--about">
                        <h1 id="itemname" runat="server"></h1>
                        <span id="price" runat="server"></span>
                        <p id="decrip" runat="server"></p>
                    </div>

                    <div class="product__view--more">
                        <p>view all specifications</p>
                        <div class="view__more--block"></div>
                    </div>
                </div>
            </div>

            <div class="product_buttons">
                <button class="btn wishlist">Add to wishlist</button>
                <asp:Button ID="btnBuy" class="btn buy" runat="server" Text="Add to cart" OnClick="btnBuy_Click" />
            </div>
        </div>
    </div>
         <br><br><br><br><br><br><br><br>
</asp:Content>
