<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="ProductExample.aspx.cs" Inherits="AI_Forge_Web_App.ProductExample" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

	<form id="form1" runat="server">
	<div class="product__container__details">
        <div class="product__header">
		    <div class="name__price_container">
				<p class="product-name">{Product Name]</p>
                <p class="product-price">{Price}</p>
			</div>
        </div>

		<div class="add-product">
			<div class="product-quantity">
			    <div class="product__container__details__quantity">
				    <p class="quantity-label">Quantity</p>
				    <div class="quantity__select">
					    <span class="select__less">
							<asp:Button ID="btnDecQuantity" runat="server" Text="-" Width="18px" />
					    </span>
						<span class="quantity__value">1</span>
					    <span class="select__more">
							<asp:Button ID="btnIncQuantity" runat="server" Text="+" Width="18px" />
                        </span>
					</div>
				</div>
			</div>
			<span class="add-to-cart">
				<asp:Button ID="btnAddToCart" runat="server" Text="Add To Cart" Width="130px" />
			</span>
		</div>

		<div class="product__details">
			<p class="product-details__heading">Details</p>
			<p class="prduct__details-{product name}">blah blah blah</p>
		</div>
	</div>

    </form>

</asp:Content>
