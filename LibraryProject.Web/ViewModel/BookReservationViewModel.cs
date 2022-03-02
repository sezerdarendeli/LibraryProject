using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject.Web.ViewModel
{
    public class BookReservationViewModel
    {
        public string BookName { get; set; }
        public int BookId { get; set; }

        [BindProperty(Name = "Reserved User Name")] 
        public string ReservedUserName { get; set; }
        [Description("Phone Number")]
        public string PhoneNumber { get; set; }
        public string IdentityNumber { get; set; }

        public DateTime ReserveStartDate { get; set; } 

        public DateTime ReserveEndDate { get; set; } 
    }
}
