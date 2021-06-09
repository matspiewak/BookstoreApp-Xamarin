using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookstoreApp.Models
{
    class BookDetail
    {
        [PrimaryKey][AutoIncrement]
        public int BookID { get; set; }
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }
        public string BookDescription { get; set; }
        public decimal BookPrice { get; set; }
        public Nullable<decimal> BookRating { get; set; }
    }
}
