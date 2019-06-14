using System.Collections.Generic;

namespace ipb.Models
{
    public class DzialWrapper
    {
        public List List { get; set; }
        public string Rezultat { get; set; }

        public DzialWrapper(){}

        public DzialWrapper(List l){
            List = l;
        }
    }
}