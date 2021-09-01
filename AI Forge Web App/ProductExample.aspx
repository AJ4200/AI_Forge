<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="ProductExample.aspx.cs" Inherits="AI_Forge_Web_App.ProductExample" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	
	<link rel="stylesheet" href="css/products-checkout-catalog.css">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

	
	<div class="product-container-details">
        <div class="product-container-header">
		    <div class="header-details">
				<p class="product-name">Example</p>
                <p class="product-price">R0.00</p>
			</div>
			<div>
				<img class="header-image" src="images/example.jpg" alt="Example"/>
			</div>
        </div>

		<div class="add-product">
			<span class="add-to-cart">
				<asp:Button ID="btnAddToCart" runat="server" Text="Add To Cart" Width="130px" />
			</span>
		</div>

		<div class="product-details">
			<p class="details-heading">Details</p>
			<p class="details-content">...</p>
		</div>
	</div>


</asp:Content>