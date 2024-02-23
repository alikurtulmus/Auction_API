using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataAccessLayer.Domain
{
    public class Bid
    {
        [Key]
        public int BidId { get; set; }
        public decimal BidAmount { get; set; }
        public DateTime BidDate { get; set; }
        public string BidStatus { get; set; } = DataAccessLayer.Enums.BidStatus.Pending.ToString();
        public string? UserId { get; set; }
        [JsonIgnore]
        public ApplicationUser User { get; set; }
        public int VehicleId { get; set; }
        [JsonIgnore]

        public Vehicle Vehicle { get; set; }
    }
}
