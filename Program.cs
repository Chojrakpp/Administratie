namespace Administratie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyDbContext context = new MyDbContext();
            using (var context = new MyDbContext())
            {
                context.InitiateDatabase();
            }
        }
    }
}