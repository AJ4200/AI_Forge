<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Catalogue.aspx.cs" Inherits="AI_Forge_Web_App.Catalogue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	
	<link rel="stylesheet" href="css/products-checkout-catalog.css">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div>
		<div class="filter">
			<asp:Button ID="btnFilterOptions" runat="server" OnClick="btnFilterOptions_Click" Text="Filter" Width="98px"/>
			<div id="divOpenFilter" runat="server">
				<asp:DropDownList ID="ddlCategory" runat="server" OnSelectedIndexChanged="ddlCategory_SelectedIndexChanged">
                    <asp:ListItem>Select Category</asp:ListItem>
				</asp:DropDownList>
				<asp:DropDownList ID="ddlPriceRange" runat="server" OnSelectedIndexChanged="ddlPriceRange_SelectedIndexChanged">
                    <asp:ListItem>Select Price Range</asp:ListItem>
				</asp:DropDownList>
			</div>
		</div>
		<div class="sort">
			<asp:Button ID="btnSort" runat="server" OnClick="btnSort_Click" Text="Sort" Width="98px"/>
			<asp:ImageButton ID="ibtnSortDir" runat="server" OnClick="ibtnSortDir_Click" ImageUrl="~/images/ascending" Width="32px"/>
			<div id="divSortOptions" runat="server">
				<asp:BulletedList ID="blSortOptions" runat="server" OnClick="blSortOptions_Click" OnTextChanged="blSortOptions_TextChanged">
                    <asp:ListItem>Name</asp:ListItem>
                    <asp:ListItem>Recently Added</asp:ListItem>
                    <asp:ListItem>Price</asp:ListItem>
                    <asp:ListItem>Category</asp:ListItem>
                </asp:BulletedList>
			</div>
		</div>
	</div>

	<div>
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
		
		<!--
		<li class="product-tile">
			<div class="product-tile-container">
				<div class="tile-container-image">
					<a href="homebot-a5.aspx" class="container-link" title="HomeBot A5">
						<img class="container-image" src="images/Products/product1.jpg" alt="HomeBot A5"/>
					</a>
				</div>
				<div class="product-container-details">
					<a class="details-link" href="homebot-a5.aspx">View Details</a>
				</div>
			</div>

			<div class="product-tile-summary">
				<div class="product-links">
					<asp:Label ID="Label5" runat="server" Text="HomeBot A5"></asp:Label>
				</div>
				<div class="product-tile__prices">
					<p class="product-tile__price">
                        <asp:Label ID="Label6" runat="server" Text="R500.00"></asp:Label>
					</p>
				</div>
			</div>
		</li>
		
		<li class="product-tile">
			<div class="product-tile-container">
				<div class="tile-container-image">
					<a href="homebot-s3.aspx" class="container-link" title="HomeBot S3">
						<img class="container-image" src="images/Products/product2.jpg" alt="HomeBot S3"/>
					</a>
				</div>
				<div class="product-container-details">
					<a class="details-link" href="homebot-s3.aspx">View Details</a>
				</div>
			</div>

			<div class="product-tile-summary">
				<div class="product-links">
					<asp:Label ID="Label7" runat="server" Text="HomeBot S3"></asp:Label>
				</div>
				<div class="product-tile__prices">
					<p class="product-tile__price">
                        <asp:Label ID="Label8" runat="server" Text="R300.00"></asp:Label>
					</p>
				</div>
			</div>
		</li>
		
		<li class="product-tile">
			<div class="product-tile-container">
				<div class="tile-container-image">
					<a href="mx360-lamp.aspx" class="container-link" title="MX360 Bedside Lamp">
						<img class="container-image" src="images/Products/product3.jpg" alt="MX360 Bedside Lamp"/>
					</a>
				</div>
				<div class="product-container-details">
					<a class="details-link" href="mx360-lamp.aspx">View Details</a>
				</div>
			</div>

			<div class="product-tile-summary">
				<div class="product-links">
					<asp:Label ID="Label11" runat="server" Text="MX360 Bedside Lamp"></asp:Label>
				</div>
				<div class="product-tile__prices">
					<p class="product-tile__price">
                        <asp:Label ID="Label12" runat="server" Text="R250.00"></asp:Label>
					</p>
				</div>
			</div>
		</li>
		
		<li class="product-tile">
			<div class="product-tile-container">
				<div class="tile-container-image">
					<a href="cambot-mini.aspx" class="container-link" title="Cambot mini">
						<img class="container-image" src="images/Products/product4.jpg" alt="Cambot mini"/>
					</a>
				</div>
				<div class="product-container-details">
					<a class="details-link" href="cambot-mini.aspx">View Details</a>
				</div>
			</div>

			<div class="product-tile-summary">
				<div class="product-links">
					<asp:Label ID="Label9" runat="server" Text="Cambot mini"></asp:Label>
				</div>
				<div class="product-tile__prices">
					<p class="product-tile__price">
                        <asp:Label ID="Label10" runat="server" Text="R800.00"></asp:Label>
					</p>
				</div>
			</div>
		</li>

		<li class="product-tile">
			<div class="product-tile-container">
				<div class="tile-container-image">
					<a href="smart-fridge.aspx" class="container-link" title="F4 Double Door Fridge">
						<img class="container-image" src="images/Products/smart-fridge.jpg" alt="F4 Double Door Fridge"/>
					</a>
				</div>
				<div class="product-container-details">
					<a class="details-link" href="smart-fridge.aspx">View Details</a>
				</div>
			</div>

			<div class="product-tile-summary">
				<div class="product-links">
					<asp:Label ID="Label1" runat="server" Text="F4 Double Door Fridge"></asp:Label>
				</div>
				<div class="product-tile__prices">
					<p class="product-tile__price">
                        <asp:Label ID="Label2" runat="server" Text="R17500.00"></asp:Label>
					</p>
				</div>
			</div>
		</li>
		-->
	</ul>
	   </div>
 

</asp:Content>
