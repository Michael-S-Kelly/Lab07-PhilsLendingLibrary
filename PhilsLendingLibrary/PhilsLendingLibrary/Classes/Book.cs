using System;
using System.Collections.Generic;
using System.Text;

namespace PhilsLendingLibrary.Classes
{
    public class Book
    {
        public string TitleOfBook { get; set; }
        public string AuthorOfBook { get; set; }
        public Genre GenreOfBook { get; set; }
        public bool CheckedOut { get; set; }

        public enum Genre
        {
            Sci_Fi,
            Fantacy,
            Non_Fiction_Technology,
            Non_Fiction_Generic
        }
        

    }
}
