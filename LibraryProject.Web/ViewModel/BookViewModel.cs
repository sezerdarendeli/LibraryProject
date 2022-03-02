using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject.Web.ViewModel
{
    public class BookViewModel
    {
        public int Id { get; set; }
        public string BookName { get; set; }

        public string Auther { get; set; }

        public string ISBN { get; set; }

        public int BookPublishYear { get; set; }
        public decimal Price { get; set; }

        public int Status { get; set; }

        public string ControllerUserName { get; set; }
    }
}
