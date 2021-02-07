//Bir oyun yazmak istiyorsunuz. Bu yazılım için backend kodlarını C# ile geliştirmeyi planlıyoruz. Yeni üye, satış ve kampanya yönetimi yapılması isteniyor. Nesnelere ait özellikleri istediğiniz gibi verebilirsiniz. Burada amaç yazdığınız kodun kalitesidir. Ödevde gereksinimleri tam anlamadığınız durum benim için önemli değil, kendinize göre mantık geliştirebilirsiniz. Dediğim gibi kod kalitesiyle ilgileniyoruz şu an :)


//Gereksinimler

//1.Oyuncuların sisteme kayıt olabileceği, bilgilerini güncelleyebileceği, kayıtlarını silebileceği bir ortamı simule ediniz. Müşteri bilgilerinin doğruluğunu e-devlet sistemlerini kullanarak doğrulama yapmak istiyoruz. (E-devlet sistemlerinde doğrulama TcNo, Ad, Soyad, DoğumYılı bilgileriyle yapılır. Bunu yapacak servisi simule etmeniz yeterlidir.)

//2.Oyun satışı yapılabilecek satış ortamını simule ediniz.( Yapılan satışlar oyuncu ile ilişkilendirilmelidir. Oyuncunun parametre olarak metotta olmasını kastediyorum.)

//3.Sisteme yeni kampanya girişi, kampanyanın silinmesi ve güncellenmesi imkanlarını simule ediniz.

//4.     Satışlarda kampanya entegrasyonunu simule ediniz.
using GameDemo.Entities;
using System;
using System.Collections.Generic;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Player player = new Player()
            {
                TcNo = "221412",
                Ad="Kağan",
                Soyad="COŞAR"
            };

            Player player2 = new Player()
            {
                TcNo = "221412",
                Ad = "Hatice",
                Soyad = "COŞAR"
            };

            PlayerManager playerManager = new PlayerManager();
            playerManager.Add(player);
            playerManager.Update(player2);
            playerManager.Delete(player);

            Console.WriteLine("*************");

            IUsersService[] usersService = new IUsersService[2] { new MySqlUserService(), new OracleUserService() };
            ILoggerService[] loggersService = new ILoggerService[2] { new MySqlUserService(), new OracleUserService() };

            foreach (var item in usersService)
            {
                item.CheckUser();
            }

            foreach (var item in loggersService)
            {
                item.LoggerService();
            }

            Console.WriteLine("**********");

            Compaign compaign1 = new Compaign();
            compaign1.CampaignType = "İndirim";
            compaign1.CampaignName = "Black Friday";

            Compaign compaign2 = new Compaign();
            compaign2.CampaignType = "İndirim";
            compaign2.CampaignName = "Şahane Aralık";

            ////Compaign[] compoigns = new Compaign[2] { compaign1, compaign2 };
            List<Compaign> compoigns = new List<Compaign>() { compaign1, compaign2 };

            var compaignmanager = new CompaignManager();
            foreach (var item in compoigns)
            {
                compaignmanager.CompaignAdd(item);
                compaignmanager.CompaignDeleted(item);
                compaignmanager.CompaigUpdate(item);
            }

            Console.WriteLine("*********");

            Product product1 = new Product();
            product1.Name = "Valaront";
            product1.Price = 200;

            Product product2 = new Product() { Name = "Cs Go", Price = 77 };

            GameManager gameManager = new GameManager();
            gameManager.GameBuy(product1,compaign1,player);
            gameManager.GameBuy(product2,compaign2,player2);
        }
    }
}
