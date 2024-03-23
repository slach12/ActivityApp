﻿using ActivityApp.App.Common;
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
        public List<Activity> Activities;

        public ActivityService() 
        {
            Activities = new List<Activity>();

            
        }

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
            Activities.Add(Item);


            Item = new Activity();
            Item.Id = 11;
            Item.Name = "Bieganie 5 km + 10 km";
            Item.TypeId = ActivityTypes.Running;
            Item.ActivityDate = DateTime.Now;
            Item.Quantity = 15;
            Item.ActivtyTime = 120;
            Item.Weight = 84;
            Activities.Add(Item);



            Item = new Activity();
            Item.Id = 2;
            Item.Name = "Grzbiet";
            Item.TypeId = ActivityTypes.Swimming;
            Item.ActivityDate = DateTime.Now;
            Item.Quantity = 60;
            Item.ActivtyTime = 67;
            Item.Weight = 84;
            Activities.Add(Item);

            Item = new Activity();
            Item.Id = 22;
            Item.Name = "Grzbiet";
            Item.TypeId = ActivityTypes.Swimming;
            Item.ActivityDate = DateTime.Now;
            Item.Quantity = 40;
            Item.ActivtyTime = 50;
            Item.Weight = 84;
            Activities.Add(Item);

           /* Item = new Item();
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

  /*      public ConsoleKeyInfo AddNewActivityView(MenuActionService actionService)
        {
            var addNewItemMenu = actionService.GetMenuActionsByMenuName("AddNewItemMenu");
            Console.WriteLine();
            Console.WriteLine("Wybierz typ aktywności: ");

            for (int i = 0; i < addNewItemMenu.Count; i++) 
            {
                Console.WriteLine($"{addNewItemMenu[i].Id}. {addNewItemMenu[i].Name}");
            }

            var operation = Console.ReadKey();
            return operation;
        }
*/
/*        public int AddActivityItem(char activityType)
        {
            int itemTypeId;
            Int32.TryParse(activityType.ToString(), out itemTypeId);    
            Activity item = new Activity();
            item.TypeId = (ActivityTypes)itemTypeId;
            Console.WriteLine();
            Console.WriteLine("Podaj id dla nowej aktywności:");
            var id = Console.ReadLine();
            int itemId;
            Int32.TryParse(id, out itemId);
            Console.WriteLine("Podaj nazwę dla aktywności:");
            var name = Console.ReadLine();


            switch (item.TypeId)
            {
                case ActivityTypes.Swimming:
                    Console.WriteLine("Podaj ilość przepłyniętych basenów dwudziesto-pięcio metrowych:");
                    break;
                case ActivityTypes.Running: 
                    Console.WriteLine("Podaj pokonany dystans w kilometach:");
                    break;
                case ActivityTypes.Exercising: 
                    Console.WriteLine("Podaj ilość wykonanych powtórzeń:");
                    break;

            }


            double quantity;
            Double.TryParse(Console.ReadLine(),out quantity);
            Console.WriteLine("Podaj czas jaki zajeło wykonanie aktywności w minutach:");
            double activityTime;
            Double.TryParse(Console.ReadLine(), out activityTime);
            Console.WriteLine("Podaj wagę w dniu aktywności");
            double weight;
            Double.TryParse(Console.ReadLine(), out weight);

            item.Id = itemId;
            item.Name = name;
            item.Weight = weight;
            item.Quantity = quantity;
            item.ActivtyTime = activityTime;
            item.ActivityDate = DateTime.Now;


            
            Activities.Add(item);
            return itemId;


        }
*/
/*        public int RemoveActivityView()
        {
            Console.WriteLine("Wprowadź id aktywności, którą chcesz usunąć:");
            var itemId = Console.ReadKey();
            int id;
            Int32.TryParse(itemId.KeyChar.ToString(), out id);  


            return id;
        }
*/
  /*      public void RemoveActivity(int removeId)
        {
            Activity activityToRemove = new Activity();
            foreach (var item in Activities)
            {
                if (item.Id == removeId)
                {
                    activityToRemove = item;
                    break;
                }
            }
            Activities.Remove(activityToRemove);
        }
*/
 /*       public int ActivityDetailSelectionView()
        {
            Console.WriteLine("Wprowadź id aktywności, którą chcesz pokazać:");
            var itemId = Console.ReadKey();
            int id;
            Int32.TryParse(itemId.KeyChar.ToString(), out id);


            return id;
        }
*/
 /*       public void ActivityDetailView(int detailId)
        {
            Activity activityToShow = new Activity();
            foreach(var item in Activities)
            {
                if(item.Id == detailId)
                {
                    activityToShow = item;
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine($"Id aktywności    : {activityToShow.Id}");
            Console.WriteLine($"Nazwa aktywności : {activityToShow.Name}");
            Console.WriteLine($"Data aktywności  : {activityToShow.ActivityDate}");
            Console.WriteLine($"Typ aktywności   : {activityToShow.TypeId}");
            Console.WriteLine($"Ilość   : {activityToShow.Quantity} {activityToShow.Unit} w czasie {activityToShow.ActivtyTime} minuty");
            Console.WriteLine($"Waga w dniu aktywności : {activityToShow.Weight}");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine();
        }
*/
 
  /*      public ActivityTypes ActivityTypeSelectionView()
        {
            Console.WriteLine("Podaj id typu aktywności , które chcesz wyświetlić:");
            Console.WriteLine("1 - Pływanie");
            Console.WriteLine("2 - Bieganie");
            Console.WriteLine("3 - Ćwiczenia");
            Console.WriteLine("4 - Wszystkie typy aktywności");
            var itemId = Console.ReadKey();
            int id;
            Int32.TryParse(itemId.KeyChar.ToString(), out id);

            ActivityTypes idType = (ActivityTypes)id;

            return idType;
        }
*/
    /*    public void ActivityByTypeIdView(ActivityTypes typeId)
        {
            List<Activity> toShow = new List<Activity>();
            int maxNameLength = 0;
            int maxIdLength = 0;
            foreach (var item in Activities)
            {
                if (item.TypeId == typeId || typeId == ActivityTypes.All)
                {
                    toShow.Add(item);
                    maxNameLength = Math.Max(maxNameLength, item.Name.Length); 
                    maxIdLength = Math.Max(maxIdLength,item.Id.ToString().Length);  
                }
            }

            var lineLength = maxIdLength + maxNameLength + 15;

            Console.WriteLine();
            if(toShow.Count > 0)
            {
                Console.WriteLine(("").PadRight(lineLength, '-'));
                foreach (var item in toShow)
                {
                    Console.WriteLine($"Id : {item.Id} | Name : {item.Name}");
                }
                Console.WriteLine(("").PadRight(lineLength, '-'));
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Nieznalezionego żadnej aktywności typu : {typeId.ToString()}");
            }
            
        }
    */
    
    }
}
