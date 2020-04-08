namespace TimLib.models
{
   

    public class Account : IAccount
    {
        public Employee createAccount(IPerson person)
        {

            Employee emp = new Employee();
            emp.firstName = person.firstName;
            emp.lastName = person.lastName;
            emp.email = person.firstName.Substring(0, 1) + "." + person.lastName + "@venso.com";
            return emp;
        }
    }
}