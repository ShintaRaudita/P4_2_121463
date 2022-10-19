using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214063
{
    internal class comedy_1214063 : product_1214063
    {
        public string buku;
        public comedy_1214063(string title, string buku)
        {
            this.MyType = "comedy";
            this.MyTitle = title;
            this.buku = buku;
        }
        public string buku1
        {
            get { return buku; }

            set { buku = value; }
        }
    }
}
