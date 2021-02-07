using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class PlayerManager
    {
        public void Add(Player player)
        {
            Console.WriteLine(player.Ad+" isimli Oyuncu eklendi");
        }

        public void Delete(Player player)
        {
            Console.WriteLine(player.Ad+" isimli kullanıcı silindi");
        }

        public void Update(Player player)
        {
            Console.WriteLine(player.Ad + "isimli kullanıcı güncellendi");
        }
    }
}
