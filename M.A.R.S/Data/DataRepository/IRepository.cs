using M.A.R.S.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M.A.R.S.Data.DataRepository
{
    public interface IRepository
    {
        public void SetRequest(Request request);
        public Request GetLatestRequest(string username);

        public void UpdateUserConfig(UserKPIConfig config);
        public UserKPIConfig GetLastConfig(string username);

        public void SetCampaign(Campaign campaign);
        public Campaign GetCampaign(string username);
    }
}
