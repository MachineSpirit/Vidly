﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public DateTime? BirthDate { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        [Required]
        public byte MembershipTypeId { get; set; }

        public MembershipTypeDto MembershipType { get; set; }

        public void MapCustomerDtoPropsToCustomerProps(Customer customerInDbo)
        {
            customerInDbo.Name = Name;
            customerInDbo.BirthDate = BirthDate;
            customerInDbo.MembershipTypeId = MembershipTypeId;
            customerInDbo.IsSubscribedToNewsletter = IsSubscribedToNewsletter;
        }
    }
}