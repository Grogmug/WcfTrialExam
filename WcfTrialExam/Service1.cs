using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfTrialExam
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        static object lockobj = new object();
        public List<AuctionItem> GetAllAuctionItems()
        {
            return AuctionRepo.AuctionList.ToList();
        }

        public AuctionItem GetAuctionItemById(int id)
        {
            return AuctionRepo.AuctionList.Find(x => x.ItemNumber == id); 
        }

        public bool Bid(Bid bid)
        {
            lock (lockobj)
            {
                if (AuctionRepo.AuctionList.Exists(x => x.ItemNumber == bid.ItemNumber))
                {
                    AuctionItem chosenItem = AuctionRepo.AuctionList.Find(x => x.ItemNumber == bid.ItemNumber);
                    if (bid.Price > chosenItem.BidPrice)
                    {
                        chosenItem.BidPrice = bid.Price;
                        chosenItem.BidCustomerName = bid.CustomName;
                        chosenItem.BidCustomerPhone = bid.CustomPhone;
                        chosenItem.BidTime = DateTime.Now;
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
