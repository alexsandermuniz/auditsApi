﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditApi.Entities
{
    public class Record
    {
        public long id { get; set; }
        public string customer { get; set; }
        public string store { get; set; }
        public DateTime date { get; set; }
        public double value { get; set; }
        public string place { get; set; }
    }
}
