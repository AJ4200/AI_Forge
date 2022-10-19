<%@ Page Title="Shop" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="AI_Forge_Web_App.Shop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	
	<link rel="stylesheet" href="css/products-checkout-catalog.css">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
		<p>
			<span>
				<asp:Button id="btnShowSort" class="send" width="150px" runat="server" Text="Sort"  OnClick="btnShowSort_Click" />
		   </span>
			<span>
				<asp:Button id="Button1"  class="send" width="150px" runat="server" Text="Filter" OnClick="btnShowFilters_Click" />
		   </span>
		</p>
		
		<div>
		<div id="divSort" runat="server" Visible="false">
			<h2>Sort</h2>
			<asp:RadioButtonList id="rdlSort" runat="server">
                <asp:ListItem Selected="True">Name: A-Z</asp:ListItem>
                <asp:ListItem>Name: Z-A</asp:ListItem>
                <asp:ListItem>Price: Ascending</asp:ListItem>
                <asp:ListItem>Price: Descending</asp:ListItem>
                <asp:ListItem>Category: A-Z</asp:ListItem>
                <asp:ListItem>Category: Z-A</asp:ListItem>
            </asp:RadioButtonList>
			<asp:Button id="btnSort" class="send" width="150px" runat="server" Text="Button" OnClick="btnSort_Click" />
		</div>
		<br><br>
		<div id="divFilters" runat="server" Visible="false">
			<h2>Filter</h2>
			<div id="price">
				<p>Price: <span><asp:TextBox id="min_price" runat="server" width="100px"></asp:TextBox>   to   </span><span><asp:TextBox id="max_price" runat="server" width="100px"></asp:TextBox></span></p>
				
			</div>
			<div id="categories">
				<asp:CheckBoxList ID="cblCategories" runat="server">
                    <asp:ListItem>General</asp:ListItem>
                    <asp:ListItem>Bedroom</asp:ListItem>
                    <asp:ListItem>Kitchen</asp:ListItem>
                    <asp:ListItem>Security</asp:ListItem>
                    <asp:ListItem>Living Room</asp:ListItem>
                    <asp:ListItem>Bathroom</asp:ListItem>
                </asp:CheckBoxList>
			</div>
			<asp:Button id="btnFilter" class="send" width="150px" runat="server" Text="Button" OnClick="btnFilter_Click" />
		</div>
	</div>
		</div>

	<div>
		<div id="products_on_display" runat="server">
		</div>
	</div>
 
</asp:Content>
