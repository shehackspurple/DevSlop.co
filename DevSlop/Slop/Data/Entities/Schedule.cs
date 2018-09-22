using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevSlop.Slop.Data.Entities
{
    public class Schedule
    {
        public int Id { get; set; }
        public string What { get; set; }
        public string WhatUrl { get; set; }
        public DateTime When { get; set; }
        public string WhenUrl { get; set; }

        public string Where { get; set; }
        public string WhereUrl { get; set; }
        public string Who { get; set; }
        public string WhoUrl { get; set; }
        public string Description { get; set; }
    }
}
