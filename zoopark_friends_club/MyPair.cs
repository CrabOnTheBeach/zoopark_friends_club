using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoopark_friends_club
{
    public class MyPair
    {
        public int Id { get; set; }
        public string Str { get; }

        public MyPair(int id, string str)
        {
            Id = id;
            Str = str;
        }
        public override string ToString()
        {
            return Str;
        }
    }
}
