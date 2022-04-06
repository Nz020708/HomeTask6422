using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask6422.Utilities
{
    public class Boutique
    {
        public string Name;
        public int Count { get; set; }
        public Boutique()
        {

        }
        public Boutique(string name,int count)
        {
            Name = name;
            Count = count;
        }
        public Dresses[] dresses = new Dresses[0];
        public Dresses this[int index]
        {
            get
            {
                if (index<=dresses.Length || index>0)
                {
                    return dresses[index];
                }
                return dresses[index];
            }
            set
            {
                if (index > dresses.Length || index < 0)
                {
                    throw new OutofIndexException("Indexi ashir.");
                }
                else
                {
                    dresses[index] = value;
                }
            }
        }
        public void BuyDress()
        {

        }
    }
}
