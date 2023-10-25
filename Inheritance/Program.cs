

Customer customer = new Customer();
customer.City = "";

Student student = new Student();
student.Department = "";

Person[] persons = new Person[3]
{
    new Person(){FirstName="person"},
    new Customer(){FirstName="customer"},
    new Student(){FirstName="student"}
};

foreach (Person person in persons)
{
    Console.WriteLine(person.FirstName);
}

class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Customer : Person
{
    public string City { get; set; }
}

class Student : Person
{
    public string Department { get; set; }
}