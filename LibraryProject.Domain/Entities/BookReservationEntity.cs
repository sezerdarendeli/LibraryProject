
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LibraryProject.Domain.Entities
{
    [Table("BookReservation")]
    public class BookReservationEntity : EntityBase
    {
        public int BookId { get; set; }

        public string ReservedUserName { get; set; }
        public string PhoneNumber { get; set; }
        public string IdentityNumber { get; set; }

        public DateTime ReserveStartDate { get; set; } = DateTime.Now;

        public DateTime ReserveEndDate { get; set; } = DateTime.Now.AddDays(15);


    }
}
