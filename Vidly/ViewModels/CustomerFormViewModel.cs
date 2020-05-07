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

        // To change view's title based on new or existing customer
        public string Title
        {
            get
            {
                if (Customer != null && Customer.Id != 0)
                    return "Edit Customer";

                return "New Customer";
            }
        }


    }
}