
namespace Consoletask4
{

    class Book
    {
        public string Title;
        public string Author;
        public string IsBn;
        public bool Availbl = true;

    }

    class library
    {
        public List<Book> boks = new List<Book>();
        public void addBok(Book bokss)
        {
            boks.Add(bokss);
            Console.WriteLine("add");


        }
        public void ReturnBook(string title)
        {
            foreach (Book book in boks)
            {
                if (book.Title == title)
                {
                    book.Availbl=true;
                    return;
                }


            } 
        }
        public Book Searchbok(string title)
        {
            foreach (Book book in boks) {

                if (book.Title == title)
                {
                    return book;
                }
            }
            return null;
        }
        public void cotanrBook() {

            for (int i = 0; i < boks.Count; i++)
            {
                Console.WriteLine(boks[i].Title + '-' + boks[i].Author + boks[i].IsBn + '-' + (boks[i].Availbl));
            }
        }
        public void BorrowBok(string isbn)
        {
            for (int i = 0; i < boks.Count; i++)
            {
                if (boks[i].IsBn == isbn)
                {
                    boks[i].Availbl = false;
                    Console.WriteLine("borowd");
                    return;
                }
            }
            Console.WriteLine("not found");
        }
        internal class Program
        {
            static void Main(string[] args)
            {






                library lii = new library();


                while (true) {
                    Console.WriteLine("a.add s.show b.brow .search .return");
                    string mas = Console.ReadLine();
                    if (mas == "a")
                    {
                        Book book = new Book();
                        Console.WriteLine("titl: ");
                        book.Title = Console.ReadLine();

                        Console.WriteLine("author: ");
                        book.Author = Console.ReadLine();

                        Console.WriteLine("isbn: ");
                        book.IsBn = Console.ReadLine();
                        lii.addBok(book);
                    }
                    else if (mas == "s")
                    {
                        lii.cotanrBook();
                    }
                    else if (mas =="return"){
                        Console.WriteLine("title");
                        string title = Console.ReadLine();
                        lii.ReturnBook(title);
                    }
                    else if (mas == "search")
                    {
                        Console.WriteLine("title book");
                        string title = Console.ReadLine();

                        Book result = lii.Searchbok(title);

                        if (result != null)
                        {
                            Console.WriteLine("title" + result.Title);
                            Console.WriteLine("author" + result.Author);

                        }
                        else
                        {
                            Console.WriteLine("not found");
                        }

                    }








                    else if (mas == "b")
                    {
                        Console.WriteLine("enetr isb: ");
                        string iaa = Console.ReadLine();
                        lii.BorrowBok(iaa);

                    }
                    else if (mas == "e")
                    {
                        Console.WriteLine("exite");
                        break;

                    }



                    } } }
        }

    }




