<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="AI_Forge_Web_App.Checkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	
	<link rel="stylesheet" href="css/products-checkout-catalog.css">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="frmCheckout" runat="server">

	<ul class="cart">
		<!--F4 Double Door Fridge-->
		<li class="cart-item-container">
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
							<asp:Label ID="Label3" runat="server" Text="5"></asp:Label>
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
		</li>
		<!--HomeBot A5-->
		<li class="cart-item-container">
			<div class="item-container-info">
				<div class="item-container-image">
					<img class="container-image" src="images/Products/product1.jpg" alt="HomeBot A5"/>
				</div>
				<div class="item-summary">
					<p class="product-name">HomeBot A5</p>

					<div class="product-select">
						<span class="select-less">
							<asp:Button ID="Button1" runat="server" Text="-" Width="18px" />
						</span>
						<span class="quantity-value">
							<asp:Label ID="Label1" runat="server" Text="3"></asp:Label>
						</span>
						<span class="select-more">
							<asp:Button ID="Button2" runat="server" Text="+" Width="18px" />
						</span>
					</div>
				</div>
			</div>
			<div class="item-price">
				<p class="price=heading">Price</p>
				<p class="price-value">R1500.00</p>
			</div>
		</li>

		<!--MX360 Bedside Lamp-->
		<li class="cart-item-container">
			<div class="item-container-info">
				<div class="item-container-image">
					<img class="container-image" src="images/Products/product3.jpg" alt="MX360 Bedside Lamp"/>
				</div>
				<div class="item-summary">
					<p class="product-name">MX360 Bedside Lamp</p>

					<div class="product-select">
						<span class="select-less">
							<asp:Button ID="Button3" runat="server" Text="-" Width="18px" />
						</span>
						<span class="quantity-value">
							<asp:Label ID="Label2" runat="server" Text="5"></asp:Label>
						</span>
						<span class="select-more">
							<asp:Button ID="Button4" runat="server" Text="+" Width="18px" />
						</span>
					</div>
				</div>
			</div>
			<div class="item-price">
				<p class="price=heading">Price</p>
				<p class="price-value">R1250.00</p>
			</div>
		</li>
	</ul>

	<div class="checkout">
		<div class="checkout-summary">
			<p class="Subtotal">Subtotal</p>
			<p class="SubtotalValue">
				<asp:Label ID="lblSubtotalValue" runat="server" Text="R20250.00"></asp:Label>
			</p>
		</div>
		<div class="confirm">
			<asp:Button ID="btnCheckout" runat="server" Text="Checkout" Width="80px" />
		</div>
	</div>

    </form>

</asp:Content>