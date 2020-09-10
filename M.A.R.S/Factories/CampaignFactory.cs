using M.A.R.S.Data.Entities;
using M.A.R.S.Factories.IFactories;
using M.A.R.S.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M.A.R.S.Factories
{
    public class CampaignFactory : ICampaignFactory
    {
        public Campaign CreateCampaign(ConfigVM configVM)
        {
            Campaign campaign = new Campaign
            {
                Date = configVM.Date,
                User = configVM.User,

                Budget = configVM.Budget.Budget,
                OpenBudget = configVM.Budget.OpenBudget,

                RadioBudget = configVM.Radio.InputBudget,
                RadioPercentage = configVM.Radio.Percentage,
                RadioImpact = configVM.Radio.OutputVisit,

                TVBudget = configVM.TV.InputBudget,
                TVPercentage = configVM.TV.Percentage,
                TVImpact = configVM.TV.OutputVisit,

                PrintBudget = configVM.Print.InputBudget,
                PrintPercentage = configVM.Print.Percentage,
                PrintImpact = configVM.Print.OutputVisit,

                CouponBudget = configVM.Coupon.InputBudget,
                CouponPercentage = configVM.Coupon.Percentage,
                CouponImpact = configVM.Coupon.OutputVisit,

                BannerBudget = configVM.Banner.InputBudget,
                BannerPercentage = configVM.Banner.Percentage,
                BannerImpact = configVM.Banner.OutputVisit,

                SMBudget = configVM.SM.InputBudget,
                SMPercentage = configVM.SM.Percentage,
                SMImpact = configVM.SM.OutputVisit,

                EMailBudget = configVM.EMail.InputBudget,
                EMailPercentage = configVM.EMail.Percentage,
                EMailImpact = configVM.EMail.OutputVisit,

                SEABudget = configVM.SEA.InputBudget,
                SEAPercentage = configVM.SEA.Percentage,
                SEAImpact = configVM.SEA.OutputVisit,

                WebsiteBudget = configVM.Website.InputBudget,
                WebsitePercentage = configVM.Website.Percentage,
                WebsiteImpact = configVM.Website.OutputVisit,

                ShopBudget = configVM.Shop.InputBudget,
                ShopPercentage = configVM.Shop.Percentage,
                ShopImpact = configVM.Shop.Conversions
            };
            return campaign;
        }
    }
}
