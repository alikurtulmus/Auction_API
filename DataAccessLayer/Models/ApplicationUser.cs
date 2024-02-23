using DataAccessLayer.Domain;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FullName { get; set; }
        public string? ProfilePicture { get; set; }
        public DateTime DateOfBirth { get; set; }

        public ICollection<PaymentHistory> PaymentHistories { get; set; } 
        public ICollection<Vehicle> Vehicles { get; set; }
        public ICollection<Bid> Bids { get; set; }
        //Bir kullanıcı birden fazla araca talip olabilir. Çoka çok ilişki kurulacağı için ICollection yapısında oluşturduk.
    }
}
