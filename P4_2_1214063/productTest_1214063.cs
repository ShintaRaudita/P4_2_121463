using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214063
{
    internal class productTest_1214063
    {
        static void Main(string[] args)
        {
            romance_1214063 novelpertama = new romance_1214063("romance", "Spring in London");
            fantasy_1214063 novelkedua = new fantasy_1214063("fantasy", "Purple Eyes");
            comedy_1214063 novelketiga = new comedy_1214063("comedy", "Spy in Love");


            Console.WriteLine("ini dari kelas romance");
            Console.WriteLine("romance is a {0} call \"{1}\" and {2} as novel", 
                novelpertama.MyType, novelpertama.MyTitle, novelpertama.buku);

            Console.WriteLine("ini dari kelas fantasy");
            Console.WriteLine("fantasy is a {0} call \"{1}\" and {2} as novel", 
                novelkedua.MyType, novelkedua.MyTitle, novelkedua.buku);

            Console.WriteLine("ini dari kelas comedy");
            Console.WriteLine("comedy is a {0} call \"{1}\" and {2} as novel",
                novelketiga.MyType, novelketiga.MyTitle, novelketiga.buku);
        } 
    }
}
