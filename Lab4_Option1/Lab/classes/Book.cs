using System;

namespace Lab.classes
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }

        public class Price
        {
            public int Cost { get; set; }
        }

        public class Date
        {
            public DateTime Create { get; set; }
        }
    }
}
