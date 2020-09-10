using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace M.A.R.S.Data.Entities
{
    public class UserKPIConfig
    {
        [Key]
        public long Id { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }

        public double Radio_TKP { get; set; }

        public double TV_TKP { get; set; }
        public double TV_OTS { get; set; }

        public double Print_TKP { get; set; }

        public double Coupon_TKP { get; set; }
        public double Coupon_CTR { get; set; }
        public double Coupon_CR { get; set; }

        public double Banner_TKP { get; set; }
        public double Banner_CTR { get; set; }
        
        public double SM_TKP { get; set; }
        public double SM_CTR { get; set; }

        public double EMail_CTR { get; set; }
        public double EMail_BR { get; set; }
        public double EMail_OR { get; set; }

        public double SEA_CPC { get; set; }

        public double Website_CTR { get; set; }
        public double Website_BR { get; set; }

        public double Shop_CTR { get; set; }
        public double Shop_BR { get; set; }
        public double Shop_CR { get; set; }
        public double Shop_WAR { get; set; }
    }
}
