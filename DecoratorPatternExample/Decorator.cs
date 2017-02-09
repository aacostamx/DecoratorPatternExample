//------------------------------------------------------------------------
// <copyright file="Decorator.cs" company="AACOSTA">
//     Copyright (c) AACOSTA All rights reserved.
//     Website: http://aacosta.com.mx/
// </copyright>
//------------------------------------------------------------------------

namespace DecoratorPatternExample
{
    public abstract class Decorator : LibraryItem
    {
        /// <summary>
        /// The library item
        /// </summary>
        protected LibraryItem LibraryItem;

        /// <summary>
        /// Initializes a new instance of the <see cref="Decorator"/> class.
        /// </summary>
        /// <param name="item">The li.</param>
        public Decorator(LibraryItem item)
        {
            this.LibraryItem = item;
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public override void Display()
        {
            this.LibraryItem.Display();
        }
    }
}
