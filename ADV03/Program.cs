using System;

namespace ADV03
{

    #region Q2-> A) User Defined Delegate with the same signature of methods in Bookfunctions class
    delegate string BookFuncDelegate(Book b);

    #endregion

    internal class Program
    {
        // public static string delegate Title()
        static void Main(string[] args)
        {

            #region Part01 - Q1
            // Book B = new Book("123", "Little of Faith", new string[] { "asdc", "jhdj", "asdn" }, new DateTime(2001, 12, 12), 223);

            //string Title = BookFunctions.GetTitle(B);
            //Console.WriteLine(Title); 
            #endregion

            #region Q2 -> B) Use the Proper build in delegate

            // Book B = new Book("123", "Little of Faith" , new string[] { "asdc", "jhdj", "asdn" }, new DateTime(2001, 12, 12), 223);

            // Func<Book, string> title = BookFunctions.GetTitle;
            //Console.WriteLine(title(B)); 
            #endregion

            #region Q2 -> C) Anonymous Method

            //Book B = new Book("123", "Little of Faith", new string[] { "asdc", "jhdj", "asdn" }, new DateTime(2001, 12, 12), 223);

            //Func<Book, string> isbn = delegate (Book B) { return B.ISBN; };
            //Console.WriteLine(isbn(B));
            //Console.WriteLine();

            #endregion

            #region Q2 -> D) Lambda Expression

            //Book B = new Book("123", "Little of Faith", new string[] { "asdc", "jhdj", "asdn" }, new DateTime(2001, 12, 12), 223);

            //Func<Book, string> func = B => Convert.ToString(B.PublicationDate);
            //Console.WriteLine(func(B));

            #endregion





        }
    }
}
