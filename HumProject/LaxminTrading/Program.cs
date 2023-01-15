namespace LaxmiTrading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Example1();
            Example2();
        }

        static void Example1()
        {
            //Create two new customer objects.
            Customer c1 = new Customer(customerName: "Ram", customerEmail: "ram@gmail.com");
            Customer c2 = new Customer("Sita", "sita@gmail.com");

            //Create three new orders for the above two customers.
            Order o1 = new Order(orderId: "1", customer: c1, productName: "Pipe", productPrice: 101.00, productQuantity: 10);
            Order o2 = new Order("2", c2, "Tap", 50.00, 30);
            Order o3 = new Order("3", c2, "Tanki", 10000.00, 1);

            Console.WriteLine("The total price for order id: {0} is {1}.", o1.OrderId, o1.TotalPrice());
            Console.WriteLine($"Customer {o1.Customer.CustomerName} purchased {o1.ProductName}.");

            Console.WriteLine($"The total price for order id: {o2.OrderId} is {o2.TotalPrice()}.");
            Console.WriteLine($"Customer {o2.Customer.CustomerName} purchased {o2.ProductName}.");

            Console.WriteLine($"The total price for order id: {o3.OrderId} is {o3.TotalPrice()}.");
            Console.WriteLine($"Customer {o3.Customer.CustomerName} purchased {o3.ProductName}.");
        }

        static void Example2()
        {
            while (true)
            {
                Console.WriteLine("Customer Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Customer Email:");
                string email = Console.ReadLine();

                //Creates a new customer object with the above details.
                Customer cus = new Customer(name, email);

                Console.WriteLine("Oder id:");
                string orderId = Console.ReadLine();
                Console.WriteLine("Product name:");
                string productName = Console.ReadLine();
                Console.WriteLine("Product price");
                double price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Product quantity:");
                int quantity = Convert.ToInt32(Console.ReadLine());

                //Creates a new order object with above details.
                Order or1 = new Order(orderId, cus, productName, price, quantity);

                //Output the order details to console.
                Console.WriteLine($"{or1.Customer.CustomerName} purchased {or1.ProductQuantity} {or1.ProductName}."
                    + $" Their order id is {or1.OrderId}. Total price to be paid {or1.TotalPrice()}");
            }
        }
    }
}