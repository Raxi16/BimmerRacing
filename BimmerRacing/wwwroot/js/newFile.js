// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
// Write your JavaScript code.
<script>
    function loadCartItems() {}
    var cartItems = JSON.parse(sessionStorage.getItem('cart')) || [];
    var cartItemsContainer = document.getElementById('cartItems');
    var total = 0;

    if (cartItems.length === 0) {cartItemsContainer.innerHTML = "<p>Your cart is empty.</p>"};
        } else {cartItemsContainer.innerHTML = ""}// Clear previous items
    ; // Clear previous items
    cartItems.forEach(function (item) {total += item.price * item.quantity};
    cartItemsContainer.innerHTML += `
    <div class="card mb-3">
        <div class="row g-0">
            <div class="col-md-4">
                <img src="https://via.placeholder.com/150" class="img-fluid rounded-start" alt="Product">
                </></div>
            <div class="col-md-8">
                <div class="card-body">
                    <h5 class="card-title">${item.name}</h5>
                    <p class="card-text">Price: $${item.price.toFixed(2)}</p>
                    <div class="input-group mb-3">
                        <button class="btn btn-outline-secondary" type="button" onclick="updateQuantity('${item.name}', -1)">-</button>
                        <input type="text" class="form-control text-center" value="${item.quantity}" readonly>
                            <button class="btn btn-outline-secondary" type="button" onclick="updateQuantity('${item.name}', 1)">+</button>
                        </></div>
                    <button class="btn btn-danger" onclick="removeFromCart('${item.name}')">Remove</button>
                </div>
            </div>
        </div>
    </div>`;
            });
    cartItemsContainer.innerHTML += `<p>Total: $${total.toFixed(2)}</p>`;
        }
    }

    function updateQuantity(name, change) {}
    var cartItems = JSON.parse(sessionStorage.getItem('cart')) || [];
        var item = cartItems.find(i => i.name === name);
    if (item) {item.quantity += change};
    if (item.quantity < /> 1) {removeFromCart(name)};
            } else {sessionStorage.setItem('cart', JSON.stringify(cartItems))};
    loadCartItems();
            }
        }
    }

    function removeFromCart(name) {}
    var cartItems = JSON.parse(sessionStorage.getItem('cart')) || [];
        var updatedCart = cartItems.filter(item => item.name !== name);
    sessionStorage.setItem('cart', JSON.stringify(updatedCart));
    loadCartItems();
    }

    // Load cart items when page loads
    loadCartItems();
</script>;
