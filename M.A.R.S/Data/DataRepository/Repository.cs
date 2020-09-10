using M.A.R.S.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M.A.R.S.Data.DataRepository
{
    public class Repository : IRepository
    {
        private readonly ApplicationDbContext Context;

        public Repository(ApplicationDbContext context)
        {
            this.Context = context;
        }




         

        public Request GetLatestRequest(string username)
        {
            //Äquivalent zu "Select * from Request Where User = Username order by Date desc"
            var latestRequest = this.Context.Requests.OrderByDescending(r => r.Date)
                                                     .Where(r => r.User == username)
                                                     .FirstOrDefault();

            //Fehlerbehandlung, damit keine "Null-Objekte" nach oben gereicht werden
            if (latestRequest == null)
            {
                Request standardRequest = new Request
                {
                    Banner = true,
                    Coupon = true,
                    EMail = true,
                    Print = true,
                    Radio = true,
                    SEA = true,
                    Shop = true,
                    SM = true,
                    TV = true,
                    Website = true,

                    Date = DateTime.Now,
                    User = username
                };
                this.Context.Requests.Add(standardRequest);
                this.Context.SaveChanges();
            }

            return this.Context.Requests.OrderByDescending(r => r.Date)
                                        .Where(r => r.User == username)
                                        .FirstOrDefault();
        }

        public void SetRequest(Request request)
        {
            this.Context.Requests.Add(request);
            this.Context.SaveChanges();
        }





        public UserKPIConfig GetLastConfig(string username)
        {
            var latestUserConfig = this.Context.KPIConfigs.OrderByDescending(c => c.Date)
                                                          .Where(c => c.User == username)
                                                          .FirstOrDefault();

            //Dev Initializing for local usage only! Replace the following part in productive use before deploying

            if (latestUserConfig == null)
            {
                var standardConfig = this.Context.KPIConfigs.OrderByDescending(c => c.Date)
                                                            .Where(c => c.User == "admin@admin.com")
                                                            .FirstOrDefault();
                if(standardConfig == null)
                {
                    UserKPIConfig standardInitConfig = new UserKPIConfig
                    {
                        User = "admin@admin.com",
                        Date = DateTime.Now,
                        Radio_TKP = 1.98,
                        TV_TKP = 37.96, //evtl auch 100, noch kein Antwort
                        TV_OTS = 1, //Default value missing
                        Print_TKP = 31.12,
                        Coupon_TKP = 1, //Default value missing
                        Coupon_CTR = 0.02,
                        Coupon_CR = 0.029,
                        Banner_TKP = 25,
                        Banner_CTR = 0.0003,
                        SM_TKP = 7.04,
                        SM_CTR = 0.0052,
                        EMail_CTR = 0.1538,
                        EMail_BR = 0.0337,
                        EMail_OR = 0.2656,
                        SEA_CPC = 4,
                        Website_CTR = 1, //Default value missing
                        Website_BR = 0.5,
                        Shop_CTR = 1, //Default value missing
                        Shop_BR = 0.3,
                        Shop_CR = 1, //Default value missing
                        Shop_WAR = 0.69,
                    };

                    this.Context.KPIConfigs.Add(standardInitConfig);
                    this.Context.SaveChanges();
                }
                else
                {
                    UserKPIConfig userKPIConfig = new UserKPIConfig
                    {
                        User = username,
                        Date = DateTime.Now,
                        Radio_TKP = 1.98,
                        TV_TKP = 37.96, //evtl auch 100, noch kein Antwort
                        TV_OTS = 1, //Default value missing
                        Print_TKP = 31.12,
                        Coupon_TKP = 1, //Default value missing
                        Coupon_CTR = 0.02,
                        Coupon_CR = 0.029,
                        Banner_TKP = 25,
                        Banner_CTR = 0.0003,
                        SM_TKP = 7.04,
                        SM_CTR = 0.0052,
                        EMail_CTR = 0.1538,
                        EMail_BR = 0.0337,
                        EMail_OR = 0.2656,
                        SEA_CPC = 4,
                        Website_CTR = 1, //Default value missing
                        Website_BR = 0.5,
                        Shop_CTR = 1, //Default value missing
                        Shop_BR = 0.3,
                        Shop_CR = 1, //Default value missing
                        Shop_WAR = 0.69,
                    };

                    this.Context.KPIConfigs.Add(userKPIConfig);
                    this.Context.SaveChanges();
                } 
            }
            return this.Context.KPIConfigs.OrderByDescending(c => c.Date)
                                          .Where(c => c.User == username)
                                          .FirstOrDefault();
        }
        public void UpdateUserConfig(UserKPIConfig config)
        {
            this.Context.KPIConfigs.Update(config);
            this.Context.SaveChanges();
        }






        public void SetCampaign(Campaign campaign)
        {
            this.Context.Campaigns.Add(campaign);
            this.Context.SaveChanges();
        }

        public Campaign GetCampaign(string username)
        {
            return this.Context.Campaigns.OrderByDescending(c => c.Date)
                                         .Where(c => c.User == username)
                                         .FirstOrDefault();
        }
    }
}
