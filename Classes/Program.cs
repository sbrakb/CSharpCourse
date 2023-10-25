

using Classes;

CustomerManager customerManager = new CustomerManager();

customerManager.Add();
customerManager.Update();

ProductManager productManager = new ProductManager();
productManager.Add();
productManager.Update();

Customer customer = new Customer();
customer.Id = 1;
customer.FirstName = "x";
customer.LastName = "";
customer.City = "";

Customer customer2 = new Customer()
{
    Id = 2,
    FirstName = "y",
    LastName="",
    City=""
};

Console.WriteLine(customer2.FirstName);