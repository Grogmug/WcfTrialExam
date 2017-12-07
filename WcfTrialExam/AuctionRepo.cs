using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfTrialExam
{
    public static class AuctionRepo
    {
        public static List<AuctionItem> AuctionList;

        static AuctionRepo()
        {
            AuctionList = new List<AuctionItem>();
            AuctionList.Add(new AuctionItem(1, "Sko"));
            AuctionList.Add(new AuctionItem(2, "Spil"));
            AuctionList.Add(new AuctionItem(3, "Slange"));
            AuctionList.Add(new AuctionItem(4, "Snaps"));
        }
    }
}
