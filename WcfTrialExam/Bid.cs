using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfTrialExam
{
    public class Bid
    {
        public int ItemNumber { get; set; }
        public int Price { get; set; }
        public string CustomName { get; set; }
        public string CustomPhone { get; set; }

        public Bid(int id, int price, string name, string phone)
        {
            ItemNumber = id;
            Price = price;
            CustomName = name;
            CustomPhone = phone;
        }
    }
}
