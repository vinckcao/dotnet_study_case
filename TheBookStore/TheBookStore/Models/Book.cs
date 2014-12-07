﻿using System.Collections.Generic;

namespace TheBookStore.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ISBN { get; set; }

        public virtual ICollection<Author> Authors { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
    }
}