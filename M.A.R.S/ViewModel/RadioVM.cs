using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M.A.R.S.ViewModel
{
    public class RadioVM
    {
        public string Name { get; } = "Radio";
        public double TKP { get; set; }
        public double InputBudget { get; set; }
        public double OutputVisit { get; set; }
        public string Percentage { get; set; }
        public string OutputAsString { get; set; } = "0";
    }
}
