
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LibraryProject.Domain.Entities
{
    [Table("Books")]
    public class BooksEntity:EntityBase
    {

        public string BookName { get; set; }

        public string Auther { get; set; }

        public string ISBN { get; set; }

        public int BookPublishYear { get; set; }


        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }


        public int Status { get; set; }

        public string ControllerUserName { get; set; }


    }
}
