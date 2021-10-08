<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="AI_Forge_Web_App.Checkout1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/TransationPage.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <section>
        <div class="page">

            <div class="ProductInfo">
                <h1 style="padding-top:10px">Delivery</h1>
                 <hr />
      
                <div class="ProductSum">

                 <h2 id="Items">Please enter your delivery address</h2>
                <br/>
                    
                    <label class="custom-field address" id="address1">
  <input type="text" required="required"/>
  <span class="placeholder">Street address</span>
  <span class="border"></span>
                        </label>
                    <br/><br/>

                    <label class="custom-field address" id="address2">
  <input type="text" required="required"/>
  <span class="placeholder">Surbub</span>
  <span class="border"></span>
                        </label>
                    <br/><br/>

                    <label class="custom-field address" >
  <input type="text" required="required"/>
  <span class="placeholder">City/Town</span>
  <span class="border"></span>
                        </label>
                    <br/><br/>

                    <label class="custom-field address">
  <input type="text" required="required"/>
  <span class="placeholder">Province</span>
  <span class="border"></span>
                        </label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                    <label class="custom-field address" id="postalcode" style="width:170px; ">
  <input type="number" required="required" style="width:170px"/>
  <span class="placeholder">Postal Code</span>
  <span class="border" style="width:170px"></span>
                        </label>
                    </div>
                   <br/><br/> <hr /> <br/>
                <div class="Total">
               <h3>Total:</h3>
                <h3>Delivery fee:</h3>
                <h3>To pay:</h3>
                    </div>
                 <hr /><br/>
                   <label class="custom-field two">
  <input type="text" placeholder="&nbsp;"/>
  <span class="placeholder">Promo Code</span>
</label>

                    <button class="button Promo">Enter Promo</button>

                </div>

            </div>

            <div class="PaymentInfo">
                <h1 style="padding-top:10px">Payment</h1>
                <hr />

                <div class="PaymentDetails">
                 
                    <h2>Enter your card details</h2>

                    <label class="custom-field three">
  <input type="text" required/>
  <span class="placeholder">Name on Card</span>
  <span class="border"></span>
                        </label>
                    <br/><br/>

   <label class="custom-field three">
  <input type="number" required/>
  <span class="placeholder">Card Number</span>
  <span class="border"></span>
                        </label>
                    <br/><br/>

                     <label class="custom-field three">
  <input type="number" required/>
  <span class="placeholder">Expiry Date (MM/YY)</span>
  <span class="border"></span>
                        </label>
                    <br/><br/>

                     <label class="custom-field three">
  <input type="number" required max-length="3" min-length="3"/>
  <span class="placeholder">CVV</span>
  <span class="border"></span>
                        </label>
                    <br/>
  
                    <a href="Paid.aspx">
                                   <input class="button Pay" type="button" value="PAY" />
                                </a>

                    <span class="validity"></span>
                </div>
            </div>
    
    </section>
</asp:Content>
