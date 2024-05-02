using ActivityApp.App.Common;
using ActivityApp.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityApp.App.Concrete
{
    public class ActivityService : BaseService<Activity>
    {
        

        public void InitializeTestingData()
        {
            var Item = new Activity();
            Item.Id = 1;
            Item.Name = "Bieganie 5 km + 10 km";
            Item.TypeId = ActivityTypes.Running;
            Item.ActivityDate = DateTime.Now;
            Item.Quantity = 15;
            Item.ActivtyTime = 120;
            Item.Weight = 84;
            AddItem(Item);
            
            

            Item = new Activity();
            Item.Id = 11;
            Item.Name = "Bieganie 5 km + 10 km";
            Item.TypeId = ActivityTypes.Running;
            Item.ActivityDate = DateTime.Now;
            Item.Quantity = 15;
            Item.ActivtyTime = 120;
            Item.Weight = 84;
            AddItem(Item);



            Item = new Activity();
            Item.Id = 2;
            Item.Name = "Grzbiet";
            Item.TypeId = ActivityTypes.Swimming;
            Item.ActivityDate = DateTime.Now;
            Item.Quantity = 60;
            Item.ActivtyTime = 67;
            Item.Weight = 84;
            AddItem(Item);

            Item = new Activity();
            Item.Id = 22;
            Item.Name = "Grzbiet";
            Item.TypeId = ActivityTypes.Swimming;
            Item.ActivityDate = DateTime.Now;
            Item.Quantity = 40;
            Item.ActivtyTime = 50;
            Item.Weight = 84;
            AddItem(Item);

            /*  Item = new Item();
              Item.Id = 3;
              Item.Name = "Biceps";
              Item.TypeId = ItemTypes.Exercising;
              Item.ActivityDate = DateTime.Now;
              Item.Quantity = 45;
              Item.ActivtyTime = 10;
              Item.Weight = 84;
              Items.Add(Item);

              Item = new Item();
              Item.Id = 33;
              Item.Name = "Triceps";
              Item.TypeId = ItemTypes.Exercising;
              Item.ActivityDate = DateTime.Now;
              Item.Quantity = 55;
              Item.ActivtyTime = 10;
              Item.Weight = 84;
              Items.Add(Item);*/

        }




    }
}
