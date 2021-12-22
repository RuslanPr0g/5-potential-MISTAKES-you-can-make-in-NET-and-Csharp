namespace ExpressionBodyVSAutoProperties
{
    public class Employee
    {
        public Employee(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
            FullName = $"{FirstName} {LastName}";
        }

        public string FirstName { get; }

        public string LastName { get; }

        public string FullName { get; }
    }
}
