<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Catalog.aspx.cs" Inherits="AI_Forge_Web_App.Catalog" %>

<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {
		//TODO
    }
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	
	<link rel="stylesheet" href="css/products-checkout-catalog.css">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

	<form id="form1" runat="server">

	<ul>
		<li class="product-tile">
			<div class="product-tile-container">
				<div class="tile-container-image">
					<a href="ProductExample.aspx" class="container-link" title="Example">
						<img class="container-image" src="images/example.jpg" alt="Example"/>
					</a>
				</div>
				<div class="product-container-details">
					<a class="details-link" href="ProductExample.aspx">View Details</a>
				</div>
			</div>

			<div class="product-tile-summary">
				<div class="product-links">
					<asp:Label ID="Label3" runat="server" Text="Example"></asp:Label>
				</div>
				<div class="product-tile__prices">
					<p class="product-tile__price">
                        <asp:Label ID="Label4" runat="server" Text="R0.00"></asp:Label>
					</p>
				</div>
			</div>
		</li>
		
		<li class="product-tile">
			<div class="product-tile-container">
				<div class="tile-container-image">
					<a href="ProductExample.aspx" class="container-link" title="Example">
						<img class="container-image" src="images/example.jpg" alt="Example"/>
					</a>
				</div>
				<div class="product-container-details">
					<a class="details-link" href="ProductExample.aspx">View Details</a>
				</div>
			</div>

			<div class="product-tile-summary">
				<div class="product-links">
					<asp:Label ID="Label5" runat="server" Text="Example"></asp:Label>
				</div>
				<div class="product-tile__prices">
					<p class="product-tile__price">
                        <asp:Label ID="Label6" runat="server" Text="R0.00"></asp:Label>
					</p>
				</div>
			</div>
		</li>
		
		<li class="product-tile">
			<div class="product-tile-container">
				<div class="tile-container-image">
					<a href="ProductExample.aspx" class="container-link" title="Example">
						<img class="container-image" src="images/example.jpg" alt="Example"/>
					</a>
				</div>
				<div class="product-container-details">
					<a class="details-link" href="ProductExample.aspx">View Details</a>
				</div>
			</div>

			<div class="product-tile-summary">
				<div class="product-links">
					<asp:Label ID="Label7" runat="server" Text="Example"></asp:Label>
				</div>
				<div class="product-tile__prices">
					<p class="product-tile__price">
                        <asp:Label ID="Label8" runat="server" Text="R0.00"></asp:Label>
					</p>
				</div>
			</div>
		</li>
		
		<li class="product-tile">
			<div class="product-tile-container">
				<div class="tile-container-image">
					<a href="ProductExample.aspx" class="container-link" title="Example">
						<img class="container-image" src="images/example.jpg" alt="Example"/>
					</a>
				</div>
				<div class="product-container-details">
					<a class="details-link" href="ProductExample.aspx">View Details</a>
				</div>
			</div>

			<div class="product-tile-summary">
				<div class="product-links">
					<asp:Label ID="Label9" runat="server" Text="Example"></asp:Label>
				</div>
				<div class="product-tile__prices">
					<p class="product-tile__price">
                        <asp:Label ID="Label10" runat="server" Text="R0.00"></asp:Label>
					</p>
				</div>
			</div>
		</li>

		<!--Smart Fridge-->
		<li class="product-tile">
			<div class="product-tile-container">
				<div class="tile-container-image">
					<a href="ProductExample.aspx" class="container-link" title="Smart Fridge">
						<img class="container-image" src="images/Products/smart-fridge.jpg" alt="Smart Fridge"/>
					</a>
				</div>
				<div class="product-container-details">
					<a class="details-link" href="ProductExample.aspx">View Details</a>
				</div>
			</div>

			<div class="product-tile-summary">
				<div class="product-links">
					<asp:Label ID="Label1" runat="server" Text="Smart Fridge"></asp:Label>
				</div>
				<div class="product-tile__prices">
					<p class="product-tile__price">
                        <asp:Label ID="Label2" runat="server" Text="R7500"></asp:Label>
					</p>
				</div>
			</div>
		</li>
	</ul>

    </form>

</asp:Content>