<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="AI_Forge_Web_App.Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="stylesheet" href="css/Products.css">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="container2">
        <div class="box">
            <div class="product__img">
                <img src="images/Products/product1.jpg" alt="">
            </div>
            <div class="product__disc">
                <div class="product__disc--content">
                    <div class="disc__content--about">
                        <h1>Oculus Rift S</h1>
                        <span>get ready to step into a new world</span>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Consequatur hic minus nihil
                            obcaecati, ratione repellendus saepe sint tenetur totam ullam. Accusantium aspernatur
                            ducimus impedit perferendis quisquam repellendus similique ullam vitae!</p>
                    </div>

                    <div class="product__view--more">
                        <p>view all specifications</p>
                        <div class="view__more--block"></div>
                    </div>
                </div>
            </div>

            <div class="product_buttons">
                <button class="btn wishlist">Add to wishlist</button>
                <button class="btn buy">Add to cart</button>
            </div>
        </div>
    </div>
         <br><br><br><br><br><br><br><br>
</asp:Content>
