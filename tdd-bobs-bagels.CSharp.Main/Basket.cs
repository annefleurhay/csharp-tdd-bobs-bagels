using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket

    {
        public int Capacity { get; set; } = 4;
        
        public bool isCapacityReached { get {  return bagels.Count >= Capacity; } }
        
         public List<string> bagels = new List<string>();

        public bool AddBagel(string bagel)
        {
              if (!isCapacityReached)
            {
                bagels.Add(bagel);
                return true;
            }
              else
            {
                return false;
            }
  
        }

        public bool RemoveBagel(string bagel) //remove() returns a boolean value
        {   
           
            return bagels.Remove(bagel);
        }
        public string RemoveBagelMessage(string bagel)
        {
            return RemoveBagel(bagel) ? "Removed your bagel" : "Your bagel has not been found";
        }
    }
}
