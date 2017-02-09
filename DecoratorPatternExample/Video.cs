//------------------------------------------------------------------------
// <copyright file="Video.cs" company="AACOSTA">
//     Copyright (c) AACOSTA All rights reserved.
//     Website: http://aacosta.com.mx/
// </copyright>
//------------------------------------------------------------------------

namespace DecoratorPatternExample
{
    using System;

    public class Video : LibraryItem
    {
        /// <summary>
        /// The director
        /// </summary>
        public string Director;

        /// <summary>
        /// The title
        /// </summary>
        public string Title;

        /// <summary>
        /// The play time
        /// </summary>
        public int PlayTime;

        /// <summary>
        /// Initializes a new instance of the <see cref="Video"/> class.
        /// </summary>
        public Video() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Video"/> class.
        /// </summary>
        /// <param name="video">The video.</param>
        public Video(Video video)
        {
            this.Director = video.Director;
            this.Title = video.Title;
            this.NumCopies = video.NumCopies;
            this.PlayTime = video.PlayTime;
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public override void Display()
        {
            Console.WriteLine("\nVideo ----- ");
            Console.WriteLine(" Director: {0}", Director);
            Console.WriteLine(" Title: {0}", Title);
            Console.WriteLine(" # Copies: {0}", NumCopies);
            Console.WriteLine(" Playtime: {0}\n", PlayTime);
        }
    }
}
