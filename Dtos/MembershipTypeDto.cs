using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VideoRentals.Dtos
{
    public class MembershipTypeDto
    {
        public byte Id { get; set; }
       
        public string MemberShipName { get; set; }
    }
}