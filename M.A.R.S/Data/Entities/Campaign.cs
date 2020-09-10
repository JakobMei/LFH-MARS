using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace M.A.R.S.Data.Entities
{
    public class Campaign
    {
        [Key]
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public string User { get; set; }


        public double Budget { get; set; }
        public double OpenBudget { get; set; }


        public double RadioBudget{get; set;}
        public string RadioPercentage {get; set;}
        public double RadioImpact {get; set;}


        public double TVBudget {get; set;}
        public string TVPercentage { get; set;}
        public double TVImpact { get; set;}


        public double PrintBudget { get; set;}
        public string PrintPercentage { get; set;}
        public double PrintImpact { get; set;}


        public double CouponBudget { get; set;}
        public string CouponPercentage { get; set;}
        public double CouponImpact { get; set;}


        public double BannerBudget { get; set;}
        public string BannerPercentage { get; set;}
        public double BannerImpact { get; set;}


        public double SMBudget { get; set;}
        public string SMPercentage { get; set;}
        public double SMImpact { get; set;}


        public double EMailBudget { get; set;}
        public string EMailPercentage { get; set;}
        public double EMailImpact { get; set;}


        public double SEABudget { get; set;}
        public string SEAPercentage { get; set;}
        public double SEAImpact { get; set;}


        public double WebsiteBudget { get; set;}
        public string WebsitePercentage { get; set;}
        public double WebsiteImpact { get; set;}


        public double ShopBudget { get; set;}
        public string ShopPercentage { get; set;}
        public double ShopImpact { get; set;}
        
    }
}
