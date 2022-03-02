using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryProject.Domain
{
    public class EntityBase : IEntity
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }
    }
}
