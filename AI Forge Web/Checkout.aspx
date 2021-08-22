<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="AI_Forge_Web.Checkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	
	<link rel="stylesheet" href="Main.css">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="form1" runat="server">

    <div class="cart__container__details">
        <div class="product-header">
		    <div class="name__price_container">
				<p class="product-name">{Product Name]</p>
                <p class="product-price">{Price}</p>
			</div>
        </div>

        <div class="product-form">
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
			<a class="product-container__checkout" href="404">Checkout</a>
		</div>

    </div>

    </form>

</asp:Content>
