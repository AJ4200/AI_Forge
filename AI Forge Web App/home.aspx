<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="AI_Forge_Web_App.home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    
  <style>
    .product-tile-container img {
    width: 130px;
    height: 130px;
    margin: 10px;
    }

    .product-tile {
    overflow: auto;
    height: 275px;
    width: 175px;
    padding: 10px;
    border: 1px solid black;
    float: left;
    margin: 20px;
    }
  </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
  <h1>Highlights of the week</h1>
  <div>
<ul>


  <li class="product-tile">
    <div class="product-tile-container">
      <div class="tile-container-image">
        <a href="homebot-a5.aspx" class="container-link" title="HomeBot A5">
          <img class="container-image" src="images/Products/homebot.jpg" alt="HomeBot A5"/>
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
                      <asp:Label ID="Label6" runat="server" Text="R2999.00"></asp:Label>
        </p>
      </div>
    </div>
  </li>

  <li class="product-tile">
    <div class="product-tile-container">
      <div class="tile-container-image">
        <a href="homebot-s3.aspx" class="container-link" title="HomeBot S3">
          <img class="container-image" src="images/Products/homebot-mini.jpg" alt="HomeBot S3"/>
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
                      <asp:Label ID="Label8" runat="server" Text="R999.00"></asp:Label>
        </p>
      </div>
    </div>
  </li>

  <li class="product-tile">
    <div class="product-tile-container">
      <div class="tile-container-image">
        <a href="mx360-lamp.aspx" class="container-link" title="MX360 Bedside Lamp">
          <img class="container-image" src="images/Products/lamp.jpg" alt="MX360 Bedside Lamp"/>
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
                      <asp:Label ID="Label12" runat="server" Text="R749.00"></asp:Label>
        </p>
      </div>
    </div>
  </li>

  <li class="product-tile">
    <div class="product-tile-container">
      <div class="tile-container-image">
        <a href="cambot-mini.aspx" class="container-link" title="Cambot mini">
          <img class="container-image" src="images/Products/cambot.jpg" alt="Cambot mini"/>
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
                      <asp:Label ID="Label10" runat="server" Text="R519.00"></asp:Label>
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
                      <asp:Label ID="Label2" runat="server" Text="R71999.00"></asp:Label>
        </p>
      </div>
    </div>
  </li>
  </ul>
   </div>


</asp:Content>
