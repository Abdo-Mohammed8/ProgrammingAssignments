namespace Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EF Core Running...");

            using (var context = new SchoolContext())
            {
                context.Database.EnsureCreated();
                Console.WriteLine("Database created successfully!");
            }
        }
    }
}
