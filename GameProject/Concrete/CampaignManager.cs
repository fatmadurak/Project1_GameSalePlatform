using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine("Campaign deleted : "+campaign.CampaignName);
        }

        public void NewCampaign(Campaign campaign)
        {
            Console.WriteLine("Campaign added  : "+campaign.CampaignName);
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine("Campaign updated:  "+campaign.CampaignName);        }
    }
}
