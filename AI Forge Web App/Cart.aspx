<%@ Page Title="Cart" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="AI_Forge_Web_App.Checkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	
	<link rel="stylesheet" href="css/products-checkout-catalog.css">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

	<ul id="cart" runat="server">
		<!--F4 Double Door Fridge-->
		<%--<li class="cart-item-container">
			<div class="item-container-info">
				<div class="item-container-image">
					<img class="container-image" src="images/Products/smart-fridge.jpg" alt="F4 Double Door Fridge"/>
				</div>
				<div class="item-summary">
					<p class="product-name">F4 Double Door Fridge</p>

					<div class="product-select">
						<span class="select-less">
							<asp:Button ID="Button5" runat="server" Text="-" Width="18px" />
						</span>
						<span class="quantity-value">
							<asp:Label ID="Label3" runat="server" Text="1"></asp:Label>
						</span>
						<span class="select-more">
							<asp:Button ID="Button6" runat="server" Text="+" Width="18px" />
						</span>
					</div>
				</div>
			</div>
			<div class="item-price">
				<p class="price=heading">Price</p>
				<p class="price-value">R17500.00</p>
			</div>
		</li>--%>
	</ul>

	<div class="checkout">
		<div class="checkout-summary">
			<p>VAT</p>
			<p id="vat" runat="server">

			</p>
			<p>Delivery</p>
			<p id="delivery" runat="server">

			</p>
			<p>Subtotal</p>
			<p id="subtotal" runat="server">

			</p>
		</div>
		<div class="confirm">
			<asp:Button ID="btnCheckout" runat="server" Text="Procced To Checkout" Width="80px" OnClick="btnCheckout_Click" />
		</div>
	</div>

</asp:Content>