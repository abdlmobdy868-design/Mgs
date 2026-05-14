namespace Consoletask4
{

    class Book
    {
        public string Title;
        public string Author;
        public string IsBn;
        public bool Availbl=true;

    }

    class library
    {
        public List<Book> boks = new List<Book>();
            public void addBok(Book bokss)
        {
            boks.Add(bokss);
            Console.WriteLine("add");


        }
        public void ShowBok() {

            for (int i = 0; i < boks.Count; i++)
            {
                Console.WriteLine(boks[i].Title + '-' + boks[i].Author + boks[i].IsBn + '-' +( boks[i].Availbl));
            }
    }
        public void BorrowBok(string isbn)
        {
            for (int i = 0;i < boks.Count; i++)
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
                    Console.WriteLine("a.add s.show b.brow e.exit");
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
                        lii.ShowBok();

                    }

                    
                    
                       else if (mas == "b")
                    {
                        Console.WriteLine("enetr isb: ");
                        string iaa = Console.ReadLine();
                        lii.BorrowBok(iaa);

                    }
                    else if (mas == "e") {
                        Console.WriteLine("exite");
                        break;

                    }



                } } }
        }
    }

