using ActivityApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityApp.Domain.Entity
{
    public class Activity : BaseEntity
    {
        public string Name { get; set; }
        public ActivityTypes TypeId {  get; set; }

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
                    case ActivityTypes.Swimming:
                        return "długości basenu( 25 m)";
                    case ActivityTypes.Running:
                        return "km";
                    case ActivityTypes.Exercising:
                        return "powtórzenia";
                    default:
                        return "";
                }
             
            }
        }

    }
}
