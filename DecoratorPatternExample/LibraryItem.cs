//------------------------------------------------------------------------
// <copyright file="LibraryItem.cs" company="AACOSTA">
//     Copyright (c) AACOSTA All rights reserved.
//     Website: http://aacosta.com.mx/
// </copyright>
//------------------------------------------------------------------------

namespace DecoratorPatternExample
{

    public abstract class LibraryItem
    {
        /// <summary>
        /// Gets or sets the number copies.
        /// </summary>
        /// <value>
        /// The number copies.
        /// </value>
        public int NumCopies { get; set; }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public abstract void Display();
    }
}
