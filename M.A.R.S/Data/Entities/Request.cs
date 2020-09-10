using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace M.A.R.S.Data.Entities
{
    public class Request
    {
        [Key]
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public string User { get; set; }
        public bool Radio { get; set; }
        public bool TV { get; set; }
        public bool Print { get; set; }
        public bool Coupon { get; set; }
        public bool Banner { get; set; }
        public bool SM { get; set; }
        public bool EMail { get; set; }
        public bool SEA { get; set; }
        public bool Website { get; set; }
        public bool Shop { get; set; }

    }
}
