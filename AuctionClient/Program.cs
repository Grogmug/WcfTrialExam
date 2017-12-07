using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionClient
{
    class Program
    {
        private AuctionService.Service1Client auctionService;
        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.Run();
        }

        public void Run()
        {
            auctionService = new AuctionService.Service1Client();
            auctionService.GetAllAuctionItems();
            foreach (var item in auctionService.GetAllAuctionItems())
            {
                Console.WriteLine(item.ItemNumber);
            }
            Console.ReadLine();
        }
    }
}
