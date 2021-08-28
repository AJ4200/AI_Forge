<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Catalog.aspx.cs" Inherits="AI_Forge_Web_App.Catalog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	
	<link rel="stylesheet" href="Main.css">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

	<ul>
		<li class="product-tile__item">
			<!--Container for the product's information.-->
			<div class="product-tile__container">
				<!--Container for the image of the product. This might be styled differently from the other containers-->
				<div class="product-tile__images">
					<a href="ProductExample.aspx" class="product-tile__link" title="[Product Name]">
						<img class="product-tile__image" src="images/smart-fridge.jpg" alt="[Product Name]"/>
					</a>
				</div>
				<!--Container for the link when image of the product is clicked. This might be styled differently from the other containers-->
				<div class="product__details__link__container">
					<!--productsku is the serial number of the product in inventory-->
					<a class="quick__product__details" href="ProductExample.aspx">View Details</a>
				</div>
			</div>

			<!--Container for the name of the product. This might be styled differently from the other containers-->
			<div class="product-tile__name">
				<div class="product-tile__links">
					<a href="ProductExample.aspx" class="product-tile__link">[Product Name]</a>
				</div>
			</div>

			<!--Container for the price of the product. This might be styled differently from the other containers-->
			<div class="product-tile__prices">
				<p class="product-tile__price">{Price}</p>
			</div>
		</li>
	</ul>

</asp:Content>
