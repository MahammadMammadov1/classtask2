namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            Book book = new Book();
            book.Name = "Melikmemmed";
            book.Price = 100;
            Book book1 = new Book();
            book1.Name = "qirxayaq";
            book1.Price = 150;

            library.AddBook(book);
            library.AddBook(book1);

            Console.WriteLine("Min eded daxil edin ");
            int minPr = int.Parse(Console.ReadLine());
            Console.WriteLine("Max eded daxil edin ");
            int maxPr = int.Parse(Console.ReadLine());

            
            foreach (var item in library.GetProductsByPrice(minPr, maxPr))
            {
                Console.WriteLine(item.GetInfo());
            }

            Console.WriteLine("axtardiginiz hissseni  daxil edin ");
            string part1 = Console.ReadLine();


            foreach(var item in library.GetProductsByName(part1))
            {
                Console.WriteLine(item.GetInfo());
            }
               
 




        }
    }
}