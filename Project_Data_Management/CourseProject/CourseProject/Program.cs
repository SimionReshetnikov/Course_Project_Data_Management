namespace CourseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyDbContext())
            {
                var products = context.City.ToList();
                foreach (var product in products)
                {
                    Console.WriteLine($"Product: {product.Id}, Price: {product.Name_city}");
                }
            }
        }
    }
}
