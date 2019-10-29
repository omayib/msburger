using msburger.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msburger.controller
{
    class Bill
    {
        private List<Burger> burgers;

        public Bill()
        {
            burgers = new List<Burger>();
        }
        
        public void add(Burger burger)
        {
            burgers.Add(burger);
        }

        public void remove(Burger burger)
        {

        }

        public List<Burger> getBurgers()
        {
            return burgers;
        }
    }
}
