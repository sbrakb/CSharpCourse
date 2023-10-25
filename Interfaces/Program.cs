

//IPerson person = new IPerson();  // can not create an instance of the abstract type and interfaces

/*
IPerson person1 = new Customer();
IPerson person2 = new Student();
IPerson person3 = new Worker();
*/



/*

using Interfaces;

CustomerManager customerManager = new CustomerManager();
customerManager.Add(new SqlServerCustomerDal());
customerManager.Add(new OracleCustomerDal());

*/


using Interfaces;

ICustomerDal[] customerDals = new ICustomerDal[3] 
{
    new SqlServerCustomerDal(),
    new OracleCustomerDal(),
    new MySqlCustomerDal()
};

foreach (var customerDal in customerDals)
{
    customerDal.Add();
}



//InterfacesIntro();

static void InterfacesIntro()
{
    PersonManager personManager = new PersonManager();

    Customer customer = new Customer()
    {
        Id = 1,
        FirstName = "Engin",
        LastName = "Demiroğ",
        Adress = "Ankara"
    };
    personManager.Add(customer);

    Student student = new Student()
    {
        Id = 2,
        FirstName = "Derin",
        LastName = "Demiroğ",
        Departmant = "Software"
    };
    personManager.Add(student);

    personManager.Add(new Worker() { FirstName = "Worker" });
}

interface IPerson
{
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
}

class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Adress { get; set; }
}

class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Departmant { get; set; }
}

class Worker : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}


class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName);
    }
}