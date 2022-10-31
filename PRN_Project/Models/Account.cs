using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace PRN_Project.Models
{
    public partial class Account
    {
        public Account()
        {
            Bills = new HashSet<Bill>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool? IsCus { get; set; }

        [EmailAddress(ErrorMessage = "Please enter the email")]
        public string Email { get; set; }
        public string Address { get; set; }
       
        [Phone]
        public string Phone { get; set; }
        public string CustomerType { get; set; }
        public int? BonusPoint { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }
    }
}
