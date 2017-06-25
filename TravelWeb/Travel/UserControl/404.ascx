<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="404.ascx.cs" Inherits="Travel.UserControl._404" %>

<style>
    body {
        background-image: url(data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABoAAAAaCAYAAACpSkzOAAAABHNCSVQICAgIfAhkiAAAAAlwSFlzAAALEgAACxIB0t1+/AAAABZ0RVh0Q3JlYXRpb24gVGltZQAxMC8yOS8xMiKqq3kAAAAcdEVYdFNvZnR3YXJlAEFkb2JlIEZpcmV3b3JrcyBDUzVxteM2AAABHklEQVRIib2Vyw6EIAxFW5idr///Qx9sfG3pLEyJ3tAwi5EmBqRo7vHawiEEERHS6x7MTMxMVv6+z3tPMUYSkfTM/R0fEaG2bbMv+Gc4nZzn+dN4HAcREa3r+hi3bcuu68jLskhVIlW073tWaYlQ9+F9IpqmSfq+fwskhdO/AwmUTJXrOuaRQNeRkOd5lq7rXmS5InmERKoER/QMvUAPlZDHcZRhGN4CSeGY+aHMqgcks5RrHv/eeh455x5KrMq2yHQdibDO6ncG/KZWL7M8xDyS1/MIO0NJqdULLS81X6/X6aR0nqBSJcPeZnlZrzN477NKURn2Nus8sjzmEII0TfMiyxUuxphVWjpJkbx0btUnshRihVv70Bv8ItXq6Asoi/ZiCbU6YgAAAABJRU5ErkJggg==);
    }

    .error-template {
        padding: 40px 15px;
        text-align: center;
    }

    .error-actions {
        margin-top: 15px;
        margin-bottom: 15px;
    }

        .error-actions .btn {
            margin-right: 10px;
        }

</style>

<link rel="Stylesheet" type="text/css" href="~/Template/css/bootstrap.css" id="Link1" runat="server" visible="false" />
<link rel="Stylesheet" type="text/css" href="~/Template/js/bootstrap.js" id="Link2" runat="server" visible="false" />
<link rel="Stylesheet" type="text/css" href="~/Template/js/jquery-2.2.3.min.js" id="style" runat="server" visible="false" />

<div class="container">
    <div class="row">
        <div class="col-md-12">
            <div class="error-template">
                <h1 style="font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;" >Oops!</h1>
                <h2 style="font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;margin-bottom:20px;">404 Not Found</h2>
                <div class="error-details">
                    Sorry, an error has occured, Requested page not found!
               
                </div>
                <div class="error-actions">
                    <a href="../Default.aspx" class="btn btn-primary btn-lg"><span class="glyphicon glyphicon-home"></span>
                        Take Me Home </a><a href="../Contact.aspx" class="btn btn-default btn-lg"><span class="glyphicon glyphicon-envelope"></span> Contact Support </a>
                </div>
            </div>
        </div>
    </div>
</div>
