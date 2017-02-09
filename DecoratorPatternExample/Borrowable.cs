//------------------------------------------------------------------------
// <copyright file="Borrowable.cs" company="AACOSTA">
//     Copyright (c) AACOSTA All rights reserved.
//     Website: http://aacosta.com.mx/
// </copyright>
//------------------------------------------------------------------------

namespace DecoratorPatternExample
{
    using System;
    using System.Collections.Generic;

    public class Borrowable : Decorator
    {
        /// <summary>
        /// The borrowers
        /// </summary>
        protected List<string> Borrowers = new List<string>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Borrowable"/> class.
        /// </summary>
        /// <param name="item">The li.</param>
        public Borrowable(LibraryItem item) : base(item) { }

        /// <summary>
        /// Borrows the item.
        /// </summary>
        /// <param name="name">The name.</param>
        public void BorrowItem(string name)
        {
            Borrowers.Add(name);
            LibraryItem.NumCopies--;
        }

        /// <summary>
        /// Returns the item.
        /// </summary>
        /// <param name="name">The name.</param>
        public void ReturnItem(string name)
        {
            Borrowers.Remove(name);
            LibraryItem.NumCopies++;
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public override void Display()
        {
            base.Display();

            foreach (string borrower in Borrowers)
            {
                Console.WriteLine(" borrower: " + borrower);
            }
        }
    }
}
