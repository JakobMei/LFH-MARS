using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M.A.R.S.ViewModel
{
    public class PieElementVM
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string Color { get; set; }
        public bool ShowInLegend { get; set; } = true;
        public string DisplayOn { get; set; }

    }
}
