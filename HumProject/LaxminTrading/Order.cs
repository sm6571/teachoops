namespace LaxmiTrading
{
    public class Order
    {
        public string OrderId;

        public Customer Customer { get; set; }

        public string ProductName;

        public double ProductPrice;

        public int ProductQuantity;

        public Order(string orderId, Customer customer, string productName, double productPrice, int productQuantity)
        {
            OrderId = orderId;
            Customer = customer;
            ProductName = productName;
            ProductPrice = productPrice;
            ProductQuantity = productQuantity;
        }

        // Calculate the total price the customer needs to pay.
        public double TotalPrice()
        {
            return this.ProductPrice * this.ProductQuantity;
        }
    }
}
