<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="TransactionPage.aspx.cs" Inherits="AI_Forge_Web_App.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
        <div class="page">

            <div class="ProductInfo">
                <h1>Order Summary</h1>
                 <hr />

                <div class="ProductSum">

                 <h2 id="Items">Items</h2>
                
                <h2 id="Address">Address</h2>

                <h2 id="Total">Total</h2>

                <h2 id="DeliveryFee">Delivery fee</h2>
                    <br />

                   <label class="custom-field two">
  <input type="text" placeholder="&nbsp;"/>
  <span class="placeholder">Promo Code</span>
</label>

                    <button class="button Promo">Enter Promo</button>

                </div>

            </div>

            <div class="PaymentInfo">
                <h1>Payment</h1>
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
  <input type="text" required/>
  <span class="placeholder">Card Number</span>
  <span class="border"></span>
                        </label>
                    <br/><br/>

                     <label class="custom-field three">
  <input type="text" required/>
  <span class="placeholder">Expiry Date (MM/YY)</span>
  <span class="border"></span>
                        </label>
                    <br/><br/>

                     <label class="custom-field three">
  <input type="text" required max-length="3" min-length="3"/>
  <span class="placeholder">CVV</span>
  <span class="border"></span>
                        </label>
                    <br/><br/>
  
  
        <button class="button Pay">PAY</button>
                    

                    <span class="validity"></span>
                </div>
            </div>
        </div>
    
</asp:Content>
