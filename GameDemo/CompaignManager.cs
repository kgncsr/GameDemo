using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class CompaignManager
    {
        public void CompaignAdd(Compaign compaign)
        {
            Console.WriteLine(compaign.CampaignName+" Adlı Kampanya Basladı");
        }

        public void CompaignDeleted(Compaign compaign)
        {
            Console.WriteLine(compaign.CampaignName + " Adlı Kampanya Silindi");
        }

        public void CompaigUpdate(Compaign compaign)
        {
            Console.WriteLine(compaign.CampaignName + " Adlı Kampanya Güncellendi");
        }
    }
}
