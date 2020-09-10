using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M.A.R.S.ViewModel
{
    public class ConfigVM
    {
        public ConfigVM ()
        {
            this.Banner = new BannerVM();
            this.Coupon = new CouponVM();
            this.EMail = new EMailVM();
            this.Print = new PrintVM();
            this.Radio = new RadioVM();
            this.SEA = new SEAVM();
            this.SM = new SMVM();
            this.TV = new TVVM();
            this.Website = new WebsiteVM();
            this.Shop = new ShopVM();
            this.Budget = new BudgetVM();
        }
        public long Id { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }
        public BannerVM Banner { get; set; }
        public CouponVM Coupon { get; set; }
        public EMailVM EMail { get; set; }
        public PrintVM Print { get; set; }
        public RadioVM Radio { get; set; }
        public SEAVM SEA { get; set; }
        public SMVM SM { get; set; }
        public TVVM TV { get; set; }
        public WebsiteVM Website { get; set; }
        public ShopVM Shop { get; set; }

        public BudgetVM Budget { get; set; }
    }
}
