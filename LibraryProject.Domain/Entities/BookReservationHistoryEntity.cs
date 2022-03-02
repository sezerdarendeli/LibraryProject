
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LibraryProject.Domain.Entities
{
    [Table("BookReservationHistory")]
    public class BookReservationHistoryEntity : EntityBase
    {
        public int BookId { get; set; }
        public string ReservedUserName { get; set; }
        public string PhoneNumber { get; set; }
        public string IdentityNumber { get; set; }

        public DateTime ReserveStartDate { get; set; }

        public DateTime ReserveEndDate { get; set; }

        public int ReservationStatus { get; set; }


    }
}
