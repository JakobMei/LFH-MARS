using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M.A.R.S.ViewModel
{
    public class CouponVM
    {
        public string Name { get; } = "Coupon";
        public double TKP { get; set; }
        public double CTR { get; set; }
        public double CR { get; set; }
        public double ROPO { get; set; }
        public double InputBudget { get; set; }
        public double OutputVisit { get; set; }
        public string Percentage { get; set; }
        public string OutputAsString { get; set; } = "0";
    }
}
