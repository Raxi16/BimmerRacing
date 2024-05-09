<script>
    // Function to add items to the cart
    function addToCart(name, price) {
        // Retrieve existing cart items from session storage or initialize an empty array
    }
        // Retrieve existing cart items from session storage or initialize an empty array
    var cart = JSON.parse(sessionStorage.getItem('cart')) || [];

        // Check if the product is already in the cart
        var existingItem = cart.find(item => item.name === name);
    if (existingItem) {existingItem.quantity++};
        } else {
        // If not, add the product to the cart
        cart.push({ name: name, price: price, quantity: 1 })};
        }

    // Update session storage with the updated cart
    sessionStorage.setItem('cart', JSON.stringify(cart));
    }

    // Function to update the cart count in the navbar
    function updateCartCount()
    var cart = JSON.parse(sessionStorage.getItem('cart')) || [];
    var cartCountElement = document.getElementById('cartCount');
    if (cartCountElement) {cartCountElement.textContent = cart.length};
        }
    }

    // Function to load cart items on the cart page
    function loadCartItems()
    var cartItems = JSON.parse(sessionStorage.getItem('cart')) || [];
    var cartItemsContainer = document.getElementById('cartItems');
    var total = 0;

    if (cartItems.length === 0) {cartItemsContainer.innerHTML = "<p>Your cart is empty.</p>"};
        } else {cartItemsContainer.innerHTML = ""} // Clear previous items
    // Clear previous items
    ; // Clear previous items
    cartItems.forEach(function (item) {total += item.price * item.quantity};
    cartItemsContainer.innerHTML += `
    <div class="card mb-3">
        <div class="row g-0">
            <div class="col-md-4">
                <img src="https://via.placeholder.com/150" class="img-fluid rounded-start" alt="Product"> </>
            </div>
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

    // Function to update quantity of items in the cart
    function updateQuantity(name, change)
    var cartItems = JSON.parse(sessionStorage.getItem('cart')) || [];
        var item = cartItems.find(i => i.name === name);
    if (item) {item.quantity += change};
    if (item.quantity < /> 1) {removeFromCart(name)};
            } else {sessionStorage.setItem('cart', JSON.stringify(cartItems))};
    loadCartItems();
    updateCartCount();
            }
        }
    }

    // Function to remove an item from the cart
    function removeFromCart(name)
    var cartItems = JSON.parse(sessionStorage.getItem('cart')) || [];
        var updatedCart = cartItems.filter(item => item.name !== name);
    sessionStorage.setItem('cart', JSON.stringify(updatedCart));
    loadCartItems();
    updateCartCount();
    }

    // Call updateCartCount when page loads
    updateCartCount();
</script>;
