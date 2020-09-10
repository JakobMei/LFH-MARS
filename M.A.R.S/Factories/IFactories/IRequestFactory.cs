using M.A.R.S.Data.Entities;
using M.A.R.S.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M.A.R.S.Factories.IFactories
{
    public interface IRequestFactory
    {
        public Request CreateRequest(CampaignRequestVM requestVM);
        public CampaignRequestVM CreateRequestVM(Request request);
    }
}
