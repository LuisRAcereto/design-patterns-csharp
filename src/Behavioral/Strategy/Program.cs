/* Wikipedia
"The strategy pattern is a behavioral software design pattern that enables selecting
an algorithm at runtime."
*/
var cart = new ShoppingCart(59.99m);

cart.SetPaymentMethod(new CreditCardPayment("4111 1111 1111 1111"));
cart.CheckOut();

cart.SetPaymentMethod(new PayPalPayment("isaiah@example.com"));
cart.CheckOut();

/*
When to Use it
Use Strategy when you have several variants of an algorithm, and want to switch 
between them at runtime.

It's also helpful when you want to avoid a class full of conditionals that pick 
behavior bassed on a type or flag.

And it's a solid choice when related classes only differr in the behavior they use, 
and that behavior should be interchangeable.
*/
