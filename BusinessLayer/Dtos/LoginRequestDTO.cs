﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Dtos
{
    public class LoginRequestDTO
    {
        public  string UserName { get; set; }
        public string Password { get; set; }
    }
}
