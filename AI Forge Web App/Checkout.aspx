<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="AI_Forge_Web_App.Checkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	
	<link rel="stylesheet" href="css/products-checkout-catalog.css">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="frmCheckout" runat="server">

	<ul class="cart">
		<li class="cart-item-container">
			<div class="item-container-image">
				<img class="container-image" src="images/Products/smart-fridge.jpg" alt="Smart Fridge"/>
			</div>
			<div class="item-summary">
				<p class="product-name">Smart Fridge</p>

				<div class="product-select">
					<span class="select-less">
						<asp:Button ID="btnDecQuantity" runat="server" Text="-" Width="18px" />
					</span>
					<span class="quantity-value">
						<asp:Label ID="lblProductQuantity" runat="server" Text="1"></asp:Label>
					</span>
					<span class="select-more">
						<asp:Button ID="btnIncQuantity" runat="server" Text="+" Width="18px" />
					</span>
				</div>
			</div>
			<div class="item-price">
				<p class="price=heading">Price</p>
				<p class="price-value">R7500.00</p>
			</div>
		</li>
	</ul>

	<div class="checkout">
		<div class="checkout-summary">
			<p class="Subtotal">Subtotal</p>
			<p class="SubtotalValue">
				<asp:Label ID="lblSubtotalValue" runat="server" Text="R7500.00"></asp:Label>
			</p>
		</div>
		<div class="confirm">
			<asp:Button ID="btnCheckout" runat="server" Text="Checkout" Width="80px" />
		</div>
	</div>

    </form>

</asp:Content>