using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VideoRentals.Models;

namespace VideoRentals.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }

        public byte MemberShipTypeId { get; set; }

       // [Min18YearsIfAMember]
        //If a member selects other tha pay as you go,then he must be 18 years old
        public DateTime? Birthdate { get; set; }
    }
}