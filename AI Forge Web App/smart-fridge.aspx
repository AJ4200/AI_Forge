<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="smart-fridge.aspx.cs" Inherits="AI_Forge_Web_App.ProductExample" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	
	<link rel="stylesheet" href="css/products-checkout-catalog.css">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


	<div class="product-container-details">
        <div class="product-container-header">
		    <div class="header-details">
				<p class="product-name">F4 Double Door Fridge</p>
                <p class="product-price">R7500.00</p>
			</div>
			<div>
				<img class="header-image" src="images/Products/smart-fridge.jpg" alt="F4 Double Door Fridge"/>
			</div>
        </div>

		<div class="add-product">
			<span class="add-to-cart">
				<asp:Button ID="btnAddToCart2" runat="server" Text="Add To Cart" Width="130px" />
			</span>
		</div>

		<div class="product-details">
			<p class="details-heading">Details</p>
			<p class="details-content">
				This is a description of the product... it's a fridge... a double door fridge... 
				a smart double dor fridge.
				Are you impressed :)
			</p>
		</div>
	</div>


</asp:Content>
