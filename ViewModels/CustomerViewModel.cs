using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using VideoRentals.Models;

namespace VideoRentals.ViewModels
{
    public class CustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }

        public Customer Customer { get; set; }
    }
}