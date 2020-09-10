using M.A.R.S.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M.A.R.S.Calculators.ICalculators
{
    public interface ICalculator
    {
        public ConfigVM CalcBanner(ConfigVM configVM);
        public ConfigVM CalcCoupon(ConfigVM configVM);
        public ConfigVM CalcEMail(ConfigVM configVM);
        public ConfigVM CalcPrint(ConfigVM configVM);
        public ConfigVM CalcRadio(ConfigVM configVM);
        public ConfigVM CalcSEA(ConfigVM configVM);
        //public ConfigVM CalcShop(ConfigVM configVM);
        public ConfigVM CalcSM(ConfigVM configVM);
        public ConfigVM CalcTV(ConfigVM configVM);
        public ConfigVM CalcWebsiteAndShop(ConfigVM configVM);
    }
}
