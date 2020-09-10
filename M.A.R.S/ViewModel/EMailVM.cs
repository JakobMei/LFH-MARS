using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M.A.R.S.ViewModel
{
    public class EMailVM
    {
        public string Name { get; } = "E-Mail";
        public double BR { get; set; }
        public double OR { get; set; }
        public double CTR { get; set; }
        public double InputBudget { get; set; }
        public double OutputVisit { get; set; }
        public string Percentage { get; set; }
        public string OutputAsString { get; set; } = "0";
    }
}
