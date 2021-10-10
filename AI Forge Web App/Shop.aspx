<%@ Page Title="Shop" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="AI_Forge_Web_App.Shop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	
	<link rel="stylesheet" href="css/products-checkout-catalog.css">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
		<asp:Button id="btnShowSort" runat="server" Text="Button" OnClick="btnShowSort_Click" />
		<div id="divSort" runat="server" Visible="false">
			<asp:RadioButtonList id="rdlSort" runat="server">
                <asp:ListItem Selected="True">Name: A-Z</asp:ListItem>
                <asp:ListItem>Name: Z-A</asp:ListItem>
                <asp:ListItem>Price: Ascending</asp:ListItem>
                <asp:ListItem>Price: Descending</asp:ListItem>
                <asp:ListItem>Category: A-Z</asp:ListItem>
                <asp:ListItem>Category: Z-A</asp:ListItem>
            </asp:RadioButtonList>
			<asp:Button id="btnSort" runat="server" Text="Button" OnClick="btnSort_Click" />
		</div>
		
		<asp:Button id="btnShowFilters" runat="server" Text="Button" OnClick="btnShowFilters_Click" />
		<div id="divFilters" runat="server" Visible="false">
			<div id="price">
				<asp:TextBox id="min_price" runat="server"></asp:TextBox>
				<asp:TextBox id="max_price" runat="server"></asp:TextBox>
			</div>
			<div id="categories">
				<asp:CheckBoxList ID="cblCategories" runat="server"></asp:CheckBoxList>
			</div>
			<asp:Button id="btnFilter" runat="server" Text="Button" OnClick="btnFilter_Click" />
		</div>
	</div>

	<div>
		<div id="products_on_display" runat="server">
		</div>
	</div>
 
</asp:Content>
