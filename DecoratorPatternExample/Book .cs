//------------------------------------------------------------------------
// <copyright file="Book.cs" company="AACOSTA">
//     Copyright (c) AACOSTA All rights reserved.
//     Website: http://aacosta.com.mx/
// </copyright>
//------------------------------------------------------------------------

namespace DecoratorPatternExample
{
    using System;

    public class Book : LibraryItem
    {
        /// <summary>
        /// Gets or sets the author.
        /// </summary>
        /// <value>
        /// The author.
        /// </value>
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Book"/> class.
        /// </summary>
        /// <param name="book">The book.</param>
        public Book(Book book)
        {
            this.Author = book.Author;
            this.Title = book.Title;
            this.NumCopies = book.NumCopies;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Book"/> class.
        /// </summary>
        public Book() { }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public override void Display()
        {
            Console.WriteLine("\nBook ------ ");
            Console.WriteLine(" Author: {0}", Author);
            Console.WriteLine(" Title: {0}", Title);
            Console.WriteLine(" # Copies: {0}", NumCopies);
        }
    }
}
