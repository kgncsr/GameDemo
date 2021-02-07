using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class GameManager
    {

        public void GameBuy(Product product, Compaign compaign, Player player)
        {
            product.Price = product.Price-(product.Price*compaign.CampaignRatio);
            Console.WriteLine(player.Ad+" adlı oyuncu "+product.Price+"Tl'ye "+product.Name +" isimli oyunu satın aldı");
        }

    }
}
