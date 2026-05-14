namespace task_3
{
    public enum BookAvailability
    {
        Available ,
        NotAvailable
    }

    public class Book
    {
        public string title;
        public string author;
        public int isbn;
        public BookAvailability availability;

        public Book(string title, string author, int isbn, BookAvailability availability = BookAvailability.Available )
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
            this.availability = availability ;
        }



    }
    public class  Library
    {
        List<Book> books = new List<Book>();

        public string AddBook(Book b)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (b.title == books[i].title)
                {
                    return "Book already exsist!";
                }
                
            }

            books.Add(b);
            return "Book is added!";
        }

        public bool SearchBook(string name)
        {
            
            for (int i = 0; i < books.Count; i++)
            {
                if (name == books[i].title || name == books[i].author) 
                { 
                    return true;

                }
            }
            return false;
        }

        public string BorrowBook(Book b)
        {
            if (b.availability == BookAvailability.Available)
            {
                b.availability = BookAvailability.NotAvailable ;
                return "here is the book enjoy";
            }
            else
                return "Book is not avalible now !!";
        }

        public string ReturnBook(Book b)
        {
            b.availability = BookAvailability.Available;
            return "Now book is available";

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Book b1 = new Book("Atomic Habibt","James Clear",1);
           Library l = new Library();

            Console.WriteLine(l.AddBook(b1));
            Console.WriteLine(l.AddBook(new Book("Rich Dad Poor Dad", "Robert Kiyosaki", 2)));
                 
            Console.WriteLine($"Is this book exsit ? {l.SearchBook("Atomic Habibt")}");
            Console.WriteLine($"Is this book exsit ? {l.SearchBook("James Clear")}");
               
            Console.WriteLine($"Is this book available ? {l.BorrowBook(b1)}"); 
            Console.WriteLine($"Is this book available ? {l.BorrowBook(b1)}"); 


            Console.WriteLine("------------------------------");

            Console.WriteLine(l.BorrowBook(b1));
            Console.WriteLine(l.ReturnBook(b1));
            Console.WriteLine(l.BorrowBook(b1));























        }
    }
}
