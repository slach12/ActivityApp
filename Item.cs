using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityApp
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ItemTypes TypeId {  get; set; }

        public DateTime ActivityDate { get; set; }

        public double Weight {  get; set; }
        public double ActivtyTime { get; set; }
        public double Quantity {  get; set; }
        public string Unit 
        { 
            get 
            {
                
                switch (TypeId)
                {
                    case ItemTypes.Swimming:
                        return "długości basenu( 25 m)";
                    case ItemTypes.Running:
                        return "km";
                    case ItemTypes.Exercising:
                        return "powtórzenia";
                    default:
                        return "";
                }
             
            }
        }

    }
}
