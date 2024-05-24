﻿using OnlineBookStore.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace OnlineBookStore.DTO.BookDTO
{
    public class PutBookDto  
    {
        public int BookId { get; set; }

        public string BookName { get; set; }


        public string BookAuthor { get; set; }


        public string BookDescription { get; set; }


        public decimal Price { get; set; }

        public string ImageURl { get; set; }




    }
}
