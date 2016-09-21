using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSTerminal
{
    public  class ReceiptClass
    {
        public int quantity = 0;
        public string ItemName = "";
        public float ItemPrice = 0.0f;

        public ReceiptClass(int Q, string N, float P)
        {
            this.quantity = Q;
            this.ItemName = N;
            this.ItemPrice = P;
        }
    }
}
