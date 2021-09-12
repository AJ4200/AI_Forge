<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Catalogue.aspx.cs" Inherits="AI_Forge_Web_App.Catalogue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	
	<link rel="stylesheet" href="css/products-checkout-catalog.css">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
		<div>
			<span>
				<asp:Button ID="btnFilterOptions" runat="server" OnClick="btnFilterOptions_Click" Text="Filter" Width="98px"/>
				<asp:Button ID="btnSortOptions" runat="server" OnClick="btnSortOptions_Click" Text="Sort" Width="98px"/>
			</span>
		</div>
		<div id="divRmvFilters" Visible="false">
			<span>
				<asp:Button ID="btnRmvCatagoryFilter" runat="server" Text="Catagory" Visible="false"/>
				<asp:Button ID="btnRmvPriceFilter" runat="server" Text="Price" Visible="false"/>
			</span>
		</div>
		<div id="divFilterOptions" runat="server" Visible="false">
			<span>
				<asp:DropDownList ID="ddlCategory" runat="server" OnSelectedIndexChanged="ddlCategory_SelectedIndexChanged">
					<asp:ListItem Value="none">Select Category</asp:ListItem>
				</asp:DropDownList>
				<asp:DropDownList ID="ddlPriceRange" runat="server" OnSelectedIndexChanged="ddlPriceRange_SelectedIndexChanged">
					<asp:ListItem Value="none">Select Price Range</asp:ListItem>
				</asp:DropDownList>
			</span>
		</div>
		<div>
			<div id="divSortOptions" runat="server" Visible="false">
				<asp:DropDownList ID="ddlSortOptions" runat="server" OnSelectedIndexChanged="ddlSortOptions_SelectedIndexChanged">
                    <asp:ListItem>Name</asp:ListItem>
                    <asp:ListItem>Price</asp:ListItem>
                    <asp:ListItem>Category</asp:ListItem>
                </asp:DropDownList>
			</div>
		</div>
	</div>

	<div>
		<div id="products_on_sale" runat="server">
		</div>
		<div id="active_products" runat="server">
		</div>
	</div>
 

</asp:Content>
