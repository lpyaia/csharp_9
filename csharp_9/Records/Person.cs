namespace Records
{
    public record Person(string FirstName, string LastName)
    {
        public string FullName => $"{FirstName} {LastName}";
    }

    public record PersonExplicitDescontructor(string FirstName, string LastName)
    {
        public string FullName => $"{FirstName} {LastName}";

        public void Deconstruct(out string firstName, out string lastName, out string fullName)
            => (firstName, lastName, fullName) = (FirstName, LastName, FullName);
    }
}