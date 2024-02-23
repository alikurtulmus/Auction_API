﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Dtos
{
    public class CreateBidDTO
    {
        public decimal BidAmount { get; set; }
        public string? UserId { get; set; }
        public int VehicleId { get; set; }
    }
}
