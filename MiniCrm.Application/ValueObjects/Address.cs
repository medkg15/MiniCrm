﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MiniCrm.Application.ValueObjects
{
    public class Address
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
    }
}
