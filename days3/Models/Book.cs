using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace days3.Models
{
   public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string CoverImage { get; set; }
    }
    public class BookManage
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();

            books.Add(new Book { BookID = 1, Title = "Fly", Author = "Futurum", CoverImage = "Assets/1.png" });
            books.Add(new Book { BookID = 2, Title = "High", Author = "Futurum", CoverImage = "Assets/2.png" });
            books.Add(new Book { BookID = 3, Title = "Chill", Author = "Futurum", CoverImage = "Assets/3.png" });
            books.Add(new Book { BookID = 4, Title = "Weed", Author = "Futurum", CoverImage = "Assets/4.png" });
            books.Add(new Book { BookID = 5, Title = "Dab", Author = "Futurum", CoverImage = "Assets/5.png" });
            books.Add(new Book { BookID = 6, Title = "Roll", Author = "Futurum", CoverImage = "Assets/6.png" });
            books.Add(new Book { BookID = 7, Title = "Bazoka", Author = "Futurum", CoverImage = "Assets/7.png" });
            books.Add(new Book { BookID = 8, Title = "Dieu", Author = "Futurum", CoverImage = "Assets/8.png" });
            books.Add(new Book { BookID = 9, Title = "Cay", Author = "Futurum", CoverImage = "Assets/9.png" });
            books.Add(new Book { BookID = 10,Title = "Tut", Author = "Futurum", CoverImage = "Assets/10.png" });
            books.Add(new Book { BookID = 11, Title = "Lo", Author = "Futurum", CoverImage = "Assets/11.png" });
            books.Add(new Book { BookID = 12, Title = "Bat", Author = "Futurum", CoverImage = "Assets/12.png" });
            books.Add(new Book { BookID = 13, Title = "Top", Author = "Futurum", CoverImage = "Assets/13.png" });

            return books;
        }
    }
}
