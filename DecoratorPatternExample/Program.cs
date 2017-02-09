//------------------------------------------------------------------------
// <copyright file="Program.cs" company="AACOSTA">
//     Copyright (c) AACOSTA All rights reserved.
//     Website: http://aacosta.com.mx/
// </copyright>
//------------------------------------------------------------------------

namespace DecoratorPatternExample
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Create book
            var book = new Book { Author = "Gabriel García Márquez", Title = "Cien años de soledad", NumCopies = 15 };
            book.Display();

            // Create video
            var video = new Video { Director = "Damien Chazelle", Title = "La La Land", PlayTime = 3, NumCopies = 5 } ;
            video.Display();

            // Make video borrowable, then borrow and display
            Console.WriteLine("\nMaking video borrowable:");

            Borrowable borrowvideo = new Borrowable(video);
            borrowvideo.BorrowItem("Customer #1");
            borrowvideo.BorrowItem("Customer #2");
            borrowvideo.BorrowItem("Customer #3");


            borrowvideo.Display();

            // Wait for user
            Console.ReadKey();
        }
    }
}
