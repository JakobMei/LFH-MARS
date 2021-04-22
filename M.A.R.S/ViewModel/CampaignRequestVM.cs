using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace M.A.R.S.ViewModel
{
    public class CampaignRequestVM
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public string User { get; set; }
        public bool TPRadio { get; set; }
        public bool TPTV { get; set; }
        public bool TPPrint { get; set; }
        public bool TPCoupon { get; set; }
        public bool TPBanner { get; set; }
        public bool TPSM { get; set; }
        public bool TPEMail { get; set; }
        public bool TPSEA { get; set; }
        public bool TPWebsite { get; set; }
        public bool TPShop { get; set; }
    }
}
