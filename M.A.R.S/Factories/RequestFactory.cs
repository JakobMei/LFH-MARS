using M.A.R.S.Data.Entities;
using M.A.R.S.Factories.IFactories;
using M.A.R.S.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M.A.R.S.Factories
{
    public class RequestFactory : IRequestFactory
    {
        public Request CreateRequest(CampaignRequestVM requestVM)
        {
            Request request = new Request
            {
                Id = requestVM.Id,
                Date = requestVM.Date,
                User = requestVM.User,
                Radio = requestVM.TPRadio,
                TV = requestVM.TPTV,
                Print = requestVM.TPPrint,
                Coupon = requestVM.TPCoupon,
                EMail = requestVM.TPEMail,
                Banner = requestVM.TPBanner,
                SM = requestVM.TPSM,
                SEA = requestVM.TPSEA,
                Website = requestVM.TPWebsite,
                Shop = requestVM.TPShop
            };

            return request;
        }

        public CampaignRequestVM CreateRequestVM(Request request)
        {
            CampaignRequestVM requestVM = new CampaignRequestVM
            {
                Id = request.Id,
                Date = request.Date,
                User = request.User,
                TPRadio = request.Radio,
                TPTV = request.TV,
                TPPrint = request.Print,
                TPCoupon = request.Coupon,
                TPBanner = request.Banner,
                TPSM = request.SM,
                TPEMail = request.EMail,
                TPSEA = request.SEA,
                TPWebsite = request.Website,
                TPShop = request.Shop
            };
            return requestVM;
        }
    }
}
