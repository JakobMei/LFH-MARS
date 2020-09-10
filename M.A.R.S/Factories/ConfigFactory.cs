using M.A.R.S.Data.Entities;
using M.A.R.S.Factories.IFactories;
using M.A.R.S.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M.A.R.S.Factories
{
    public class ConfigFactory : IConfigFactory
    {
        public ConfigVM CreateConfigVM(UserKPIConfig config)
        {
            ConfigVM configVM = new ConfigVM();

            configVM.Id = config.Id;
            configVM.User = config.User;
            configVM.Date = config.Date;

            configVM.Radio.TKP = config.Radio_TKP;

            configVM.TV.TKP = config.TV_TKP;
            configVM.TV.OTS = config.TV_OTS;

            configVM.Print.TKP = config.Print_TKP;

            configVM.Coupon.TKP = config.Coupon_TKP;
            configVM.Coupon.CTR = config.Coupon_CTR;
            configVM.Coupon.CR = config.Coupon_CR;
            //configVM.Coupon.ROPO = value; WHAT IS ROPO? :D

            configVM.Banner.TKP = config.Banner_TKP;
            configVM.Banner.CTR = config.Banner_CTR;

            configVM.SM.TKP = config.SM_TKP;
            configVM.SM.CTR = config.SM_CTR;

            configVM.EMail.CTR = config.EMail_CTR;
            configVM.EMail.BR = config.EMail_BR;
            configVM.EMail.OR = config.EMail_OR;

            configVM.SEA.CPC = config.SEA_CPC;

            configVM.Website.CTR = config.Website_CTR;
            configVM.Website.BR = config.Website_BR;
            
            configVM.Shop.CTR = config.Shop_CTR;
            configVM.Shop.BR = config.Shop_BR;
            configVM.Shop.CR = config.Shop_CR;
            configVM.Shop.WAR = config.Shop_WAR;

            return configVM;
        }

        public UserKPIConfig CreateConfig(ConfigVM configVM)
        {
            UserKPIConfig config = new UserKPIConfig();

            config.Id = configVM.Id;
            config.User = configVM.User;
            config.Date = configVM.Date;

            config.Radio_TKP = configVM.Radio.TKP;

            config.TV_TKP = configVM.TV.TKP;
            config.TV_OTS = configVM.TV.OTS;

            config.Print_TKP = configVM.Print.TKP;

            config.Coupon_TKP = configVM.Coupon.TKP;
            config.Coupon_CTR = configVM.Coupon.CTR;
            config.Coupon_CR = configVM.Coupon.CR;
            //config.Coupon_ROPO = value; WHAT IS ROPO? :D

            config.Banner_TKP = configVM.Banner.TKP;
            config.Banner_CTR = configVM.Banner.CTR;

            config.SM_TKP = configVM.SM.TKP;
            config.SM_CTR = configVM.SM.CTR;

            config.EMail_CTR = configVM.EMail.CTR;
            config.EMail_BR = configVM.EMail.BR;
            config.EMail_OR = configVM.EMail.OR;

            config.SEA_CPC = configVM.SEA.CPC;

            config.Website_CTR = configVM.Website.CTR;
            config.Website_BR = configVM.Website.BR;

            config.Shop_CTR = configVM.Shop.CTR;
            config.Shop_BR = configVM.Shop.BR;
            config.Shop_CR = configVM.Shop.CR;
            config.Shop_WAR = configVM.Shop.WAR;


            return config;
        }

        public Campaign CreateCampaign(ConfigVM configVM)
        {
            throw new NotImplementedException();
        }
    }
}
