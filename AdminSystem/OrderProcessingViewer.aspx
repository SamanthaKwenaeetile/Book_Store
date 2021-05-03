<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderProcessingViewer.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cart</title>

</head>
<body>
        </div>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
         <!--Nav-->
        <nav class="navbar navbar-expand-lg main-navbar bg-color main-navbar-color"
        id="main-navbar">
        <div class="container">
            <a class="navbar-brand" href="#">Book Store</a>
            <div class="order-lg-last btn-group">
                <i class="fas fa-shopping-bag fa-2x"></i>
            </div>
           
                
        </div>
        </div>
        </nav>
        <!--End of Nav-->
    </section>
    <!---Hero Section-->
    <section id="hero">
        <div class="hero-container">
            <div class="hero-logo">
                <h1 class="font-weight-bold">Cart Products</h1>
            </div>
            </div>
    </section>
    <!---End of Hero Section-->
    <!--Cart Section-->
    <section class="mt-5">
        <div class="container">
            <div class="cart">
            <div class="table-responsive">
                <table class="auto-style4">
                    <thead class="thead-dark">
                        <tr>
                            <th scope="col"class="auto-style5">Product</th>
                            <th scope="col"class="auto-style5">Price</th>
                            <th scope="col"class="auto-style5">Quantity</th>
                            <th scope="col"class="auto-style6">Total</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>
                                <div class="main">
                                    <div class="d-flex">
                     <!--W=145 H=98--> <img src="images/cart-1.jpg"alt="">
                                    </div>
                                    <div class="des">
                                        <p>Book 1</p>
                                    </div>
                                </div>
                            </td>
                            <td>
                                <h6>£20.00</h6>
                            </td>
                            <td>
                                <div class="counter">
                                    <i class="fas fa-angle-down"></i>
                                    <input class="input-number"type="text"
                                    value="1"min="0"max="10">
                                    <i class="fas fa-angle-up"></i>
                                </div>
                            </td>
                            <td class="auto-style1">
                                <h6>£20.00</h6>
                            </td>
                        </tr>
                        <!----->
                        <tr>
                            <td>
                                <div class="main">
                                    <div class="d-flex">
                     <!--W=145 H=98--> <img src="images/cart-1.jpg"alt="">
                                    </div>
                                    <div class="des">
                                        <p>Book 2</p>
                                    </div>
                                </div>
                            </td>
                            <td>
                                <h6>£20.00</h6>
                            </td>
                            <td>
                                <div class="counter">
                                    <i class="fas fa-angle-down"></i>
                                    <input class="input-number"type="text"
                                    value="1"min="0"max="10">
                                    <i class="fas fa-angle-up"></i>
                                </div>
                            </td>
                            <td class="auto-style1">
                                <h6>£20.00</h6>
                            </td>
                        </tr>
                        <!----->
                        <tr>
                            <td class="auto-style2">
                                <div class="main">
                                    <div class="d-flex">
                     <!--W=145 H=98--> <img src="images/cart-1.jpg"alt="">
                                    </div>
                                    <div class="des">
                                        <p>Book 3</p>
                                    </div>
                                </div>
                            </td>
                            <td class="auto-style2">
                                <h6>£20.00</h6>
                            </td>
                            <td class="auto-style2">
                                <div class="counter">
                                    <i class="fas fa-angle-down"></i>
                                    <input class="input-number"type="text"
                                    value="1"min="0"max="10">
                                    <i class="fas fa-angle-up"></i>
                                </div>
                            </td>
                            <td class="auto-style3">
                                <h6>£20.00</h6>
                            </td>
                        </tr>
                        <!----->
                    </tbody>
                </table>
            </div>
            </div>
        </div>
    </section>
    <div class="col-lg-4 offset-lg-4">
        <div class="checkout">
            <ul>
                <li class="subtotal">subtotal
                    <span>£60.00</span>
                </li>
                <li class="cart-total">Total
                <span>£60.00</span></li>
            </ul>
            <a href="#"class="proceed-btn">Proceed to Checkout</a>
        </div>
    </div>
   
  </body>
</html>
</body>
</html>

