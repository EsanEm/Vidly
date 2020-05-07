using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using Microsoft.Ajax.Utilities;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class CustomerFormViewModel
    {

        public IEnumerable<MembershipType> MembershipTypes { get; set; }

        public Customer Customer { get; set; }

        
    }
}