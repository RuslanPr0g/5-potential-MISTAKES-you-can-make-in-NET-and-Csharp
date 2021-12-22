namespace ExpressionBodyVSAutoProperties
{
    public class Employee
    {
        public Employee(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }

        public string FirstName { get; }

        public string LastName { get; }

        public string FullName => $"{FirstName} {LastName}"; // problem here
    }
}
