using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M.A.R.S.ViewModel
{
    public class ShopVM
    {
        public string Name { get; } = "Shop";
        public double CTR { get; set; }
        public double BR { get; set; }
        public double CR { get; set; }
        public double WAR { get; set; }
        public double InputBudget { get; set; }
        public double Conversions { get; set; }
        public string Percentage { get; set; }
        public string ConversionsAsString { get; set; } = "0";
    }
}
