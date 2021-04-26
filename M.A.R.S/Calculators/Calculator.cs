using M.A.R.S.Calculators.ICalculators;
using M.A.R.S.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M.A.R.S.Calculators
{
    public class Calculator : ICalculator
    {
        public ConfigVM CalcBanner(ConfigVM configVM)
        {
            configVM.Banner.OutputVisit = ((configVM.Banner.InputBudget / configVM.Banner.TKP) * 1000) * configVM.Banner.CTR;
            configVM.Banner.OutputAsString = String.Format("{0:0}", configVM.Banner.OutputVisit);

            configVM = CalcWebsiteAndShop(configVM);

            return configVM;
        }

        public ConfigVM CalcCoupon(ConfigVM configVM)
        {
            configVM.Coupon.OutputVisit = (((configVM.Coupon.InputBudget / configVM.Coupon.TKP) * 1000) * configVM.Coupon.CTR) * configVM.Coupon.CR;
            configVM.Coupon.OutputAsString = String.Format("{0:0}", configVM.Coupon.OutputVisit);

            configVM = CalcWebsiteAndShop(configVM);

            return configVM;
        }

        
        public ConfigVM CalcEMail(ConfigVM configVM)
        {
            configVM.EMail.OutputVisit = (configVM.EMail.InputBudget / 0.0072) * (1 - configVM.EMail.BR) * configVM.EMail.OR * configVM.EMail.CTR;
            configVM.EMail.OutputAsString = String.Format("{0:0}", configVM.EMail.OutputVisit);

            configVM = CalcWebsiteAndShop(configVM);

            return configVM;
        }

        public ConfigVM CalcPrint(ConfigVM configVM)
        {
            configVM.Print.OutputVisit = (configVM.Print.InputBudget / configVM.Print.TKP) * 1000;
            configVM.Print.OutputAsString = String.Format("{0:0}", configVM.Print.OutputVisit);

            configVM = CalcWebsiteAndShop(configVM);

            return configVM;
        }

        public ConfigVM CalcRadio(ConfigVM configVM)
        {

            configVM.Radio.OutputVisit = (configVM.Radio.InputBudget / configVM.Radio.TKP) * 1000;
            configVM.Radio.OutputAsString = String.Format("{0:0}", configVM.Radio.OutputVisit);
            
            configVM = CalcWebsiteAndShop(configVM);
            
            return configVM;
        }

        public ConfigVM CalcSEA(ConfigVM configVM)
        {
            configVM.SEA.OutputVisit = (configVM.SEA.InputBudget / configVM.SEA.CPC);
            configVM.SEA.OutputAsString = String.Format("{0:0}", configVM.SEA.OutputVisit);

            configVM = CalcWebsiteAndShop(configVM);

            return configVM;
        }
        /// <summary>
        /// Hier wird mit den errechneten Visits der Website weitergerechnet
        /// CalcWebsite muss zwingend zuvor ausgeführt werden
        /// </summary>
        /// <param name="shopVM"></param>
        /// <param name="configVM"></param>
        /// <returns></returns>
        //public ConfigVM CalcShop(ConfigVM configVM)
        //{
        //    configVM.Shop.Conversions = configVM.Website.OutputVisit * configVM.Shop.BR * configVM.Shop.WAR * configVM.Shop.CTR;
        //    configVM.Shop.ConversionsAsString = String.Format("{0:0}", configVM.Shop.Conversions);

        //    configVM = CalcWebsite(configVM);

        //    return configVM;
        //}

        public ConfigVM CalcSM(ConfigVM configVM)
        {
            configVM.SM.OutputVisit = ((configVM.SM.InputBudget / configVM.SM.TKP) * 1000) * configVM.SM.CTR;
            configVM.SM.OutputAsString = String.Format("{0:0}", configVM.SM.OutputVisit);

            configVM = CalcWebsiteAndShop(configVM);

            return configVM;
        }

        public ConfigVM CalcTV(ConfigVM configVM)
        {
            configVM.TV.OutputVisit = ((configVM.TV.InputBudget / configVM.TV.TKP) * 1000) / configVM.TV.OTS;
            configVM.TV.OutputAsString = String.Format("{0:0}", configVM.TV.OutputVisit);

            configVM = CalcWebsiteAndShop(configVM);
            
            return configVM;
        }

        public ConfigVM CalcWebsiteAndShop(ConfigVM configVM)
        {
            configVM.Website.OutputVisit = configVM.Banner.OutputVisit 
                                         + configVM.Coupon.OutputVisit 
                                         + configVM.EMail.OutputVisit 
                                         + configVM.Print.OutputVisit 
                                         + configVM.Radio.OutputVisit 
                                         + configVM.SEA.OutputVisit
                                         + configVM.SM.OutputVisit 
                                         + configVM.TV.OutputVisit;

            configVM.Website.OutputVisit = configVM.Website.OutputVisit * (1 - configVM.Website.BR) * configVM.Website.CTR;

            configVM.Website.OutputAsString = String.Format("{0:0}", configVM.Website.OutputVisit);

            configVM.Shop.Conversions = configVM.Website.OutputVisit * (1 - configVM.Shop.BR) * (1 - configVM.Shop.WAR) * configVM.Shop.CTR;
            configVM.Shop.ConversionsAsString = String.Format("{0:0}", configVM.Shop.Conversions);

            return configVM;
        }
    }
}
