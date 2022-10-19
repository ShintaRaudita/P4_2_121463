using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214063
{
    public class product_1214063
    {
        private string myType;
        private string myTitle;

        public product_1214063()
        {
        
        
        }
        public product_1214063(string type, string title)
        {
            this.myType = type;
            this.myTitle = title;
        }

        public string MyType
        {
            get
            {
                return myType;
            }

            set
            {
                myType = value;
            }
        }

        public string MyTitle
        {
            get
            {
                return myTitle;
            }

            set
            {
                myTitle = value;
            }
        }
    }//end public class product_1214063

    
    

}//end namespace P4_2_1214063
