using M.A.R.S.Data.Entities;
using M.A.R.S.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M.A.R.S.Factories.IFactories
{
    public interface IConfigFactory
    {
        public ConfigVM CreateConfigVM(UserKPIConfig config);

        public UserKPIConfig CreateConfig(ConfigVM configVM);

        public Campaign CreateCampaign(ConfigVM configVM);
    }
}
