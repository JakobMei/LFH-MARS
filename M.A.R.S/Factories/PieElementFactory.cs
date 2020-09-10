using M.A.R.S.Data.Entities;
using M.A.R.S.Factories.IFactories;
using M.A.R.S.PublicEnums;
using M.A.R.S.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M.A.R.S.Factories
{
    public class PieElementFactory : IPieElementFactory
    {
        public List<PieElementVM> CreatePieElements(Campaign campaign, PieChartType type)
        {
            List<PieElementVM> pieElements = new List<PieElementVM>();

            switch (type)
            {
                case PieChartType.Output:

                    PieElementVM radioPie = new PieElementVM
                    {
                        Name = "Radio",
                        Value = campaign.RadioImpact.ToString(),
                        Color = "#854B7F"
                    };
                    pieElements.Add(radioPie);

                    PieElementVM TVPie = new PieElementVM
                    {
                        Name = "TV",
                        Value = campaign.TVImpact.ToString(),
                        Color = "#614B85"
                    };
                    pieElements.Add(TVPie);

                    PieElementVM PrintPie = new PieElementVM
                    {
                        Name = "Print",
                        Value = campaign.PrintImpact.ToString(),
                        Color = "#4B7D85"
                    };
                    pieElements.Add(PrintPie);

                    PieElementVM CouponPie = new PieElementVM
                    {
                        Name = "Coupon",
                        Value = campaign.CouponImpact.ToString(),
                        Color = "#74DAD3"
                    };
                    pieElements.Add(CouponPie);

                    PieElementVM BannerPie = new PieElementVM
                    {
                        Name = "Banner",
                        Value = campaign.BannerImpact.ToString(),
                        Color = "#1E5DD5"
                    };
                    pieElements.Add(BannerPie);

                    PieElementVM SMPie = new PieElementVM
                    {
                        Name = "SM",
                        Value = campaign.SMImpact.ToString(),
                        Color = "#74DAD3"
                    };
                    pieElements.Add(SMPie);

                    PieElementVM EMailPie = new PieElementVM
                    {
                        Name = "EMail",
                        Value = campaign.EMailImpact.ToString(),
                        Color = "#CE8DE8"
                    };
                    pieElements.Add(EMailPie);

                    PieElementVM SEAPie = new PieElementVM
                    {
                        Name = "SEA",
                        Value = campaign.SEAImpact.ToString(),
                        Color = "#3ED15F"
                    };
                    //SEAPie.ShowInLegend = string.IsNullOrEmpty(SEAPie.Value) ? SEAPie.ShowInLegend = false : SEAPie.ShowInLegend = true;
                    pieElements.Add(SEAPie);

                    PieElementVM WebsitePie = new PieElementVM
                    {
                        Name = "Website",
                        Value = campaign.WebsiteImpact.ToString(),
                        Color = "#BF2260"
                    };
                    pieElements.Add(WebsitePie);

                    PieElementVM ShopPie = new PieElementVM
                    {
                        Name = "Online-Shop",
                        Value = campaign.ShopImpact.ToString(),
                        Color = "#EB8C12"
                    };
                    pieElements.Add(ShopPie);

                    return pieElements;

                case PieChartType.Input:

                    PieElementVM radioPieInput = new PieElementVM
                    {
                        Name = "Radio",
                        Value = campaign.RadioBudget.ToString(),
                        Color = "#854B7F"
                    };
                    pieElements.Add(radioPieInput);

                    PieElementVM TVPieInput = new PieElementVM
                    {
                        Name = "TV",
                        Value = campaign.TVBudget.ToString(),
                        Color = "#614B85"
                    };
                    pieElements.Add(TVPieInput);

                    PieElementVM PrintPieInput = new PieElementVM
                    {
                        Name = "Print",
                        Value = campaign.PrintBudget.ToString(),
                        Color = "#4B7D85"
                    };
                    pieElements.Add(PrintPieInput);

                    PieElementVM CouponPieInput = new PieElementVM
                    {
                        Name = "Coupon",
                        Value = campaign.CouponBudget.ToString(),
                        Color = "#74DAD3"
                    };
                    pieElements.Add(CouponPieInput);

                    PieElementVM BannerPieInput = new PieElementVM
                    {
                        Name = "Banner",
                        Value = campaign.BannerBudget.ToString(),
                        Color = "#1E5DD5"
                    };
                    pieElements.Add(BannerPieInput);

                    PieElementVM SMPieInput = new PieElementVM
                    {
                        Name = "SM",
                        Value = campaign.SMBudget.ToString(),
                        Color = "#74DAD3"
                    };
                    pieElements.Add(SMPieInput);

                    PieElementVM EMailPieInput = new PieElementVM
                    {
                        Name = "EMail",
                        Value = campaign.EMailBudget.ToString(),
                        Color = "#CE8DE8"
                    };
                    pieElements.Add(EMailPieInput);

                    PieElementVM SEAPieInput = new PieElementVM
                    {
                        Name = "SEA",
                        Value = campaign.SEABudget.ToString(),
                        Color = "#3ED15F"
                    };
                    pieElements.Add(SEAPieInput);

                    PieElementVM WebsitePieInput = new PieElementVM
                    {
                        Name = "Website",
                        Value = campaign.WebsiteBudget.ToString(),
                        Color = "#BF2260"
                    };
                    pieElements.Add(WebsitePieInput);

                    PieElementVM ShopPieInput = new PieElementVM
                    {
                        Name = "Online-Shop",
                        Value = campaign.ShopBudget.ToString(),
                        Color = "#EB8C12"
                    };
                    pieElements.Add(ShopPieInput);

                    return pieElements;

                default:
                    throw new Exception();
            }   
        }
    }
}
