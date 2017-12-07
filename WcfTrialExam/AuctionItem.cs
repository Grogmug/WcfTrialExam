using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfTrialExam
{
    [DataContract]
    public class AuctionItem
    {
        [DataMember]
        public int ItemNumber { get; set; }
        [DataMember]
        public string ItemDescription { get; set; }
        [DataMember]
        public int RatingPrice { get; set; }
        [DataMember]
        public int BidPrice { get; set; }
        [DataMember]
        public string BidCustomerName { get; set; }
        [DataMember]
        public string BidCustomerPhone { get; set; }
        [DataMember]
        public DateTime BidTime { get; set; }

        public AuctionItem(int ItemNumber, string ItemDescription)
        {
            this.ItemNumber = ItemNumber;
            this.ItemDescription = ItemDescription;
            RatingPrice = 2000;
            BidPrice = 0;
            BidCustomerName = "";
            BidCustomerPhone = "";
            BidTime = DateTime.Now;
        }
    }
}
