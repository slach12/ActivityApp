using ActivityApp.App.Concrete;
using ActivityApp.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityApp.App.Managers
{
    public class ActivityManager
    {
        private readonly MenuActionService _actionService;
        private ActivityService _activityService;

        public ActivityManager(MenuActionService actionService) 
        {
            _activityService = new ActivityService();
            _activityService.InitializeTestingData();

            _actionService = actionService;
            
        }

        public int AddNewActivity()
        {
            var addNewItemMenu = _actionService.GetMenuActionsByMenuName("AddNewItemMenu");
            Console.WriteLine();
            Console.WriteLine("Wybierz typ aktywności: ");

            for (int i = 0; i < addNewItemMenu.Count; i++)
            {
                Console.WriteLine($"{addNewItemMenu[i].Id}. {addNewItemMenu[i].Name}");
            }
    
            var activityType = Console.ReadKey();
            int itemTypeId;
            Int32.TryParse(activityType.KeyChar.ToString(), out itemTypeId);
            Console.WriteLine();
            Console.WriteLine("Podaj nazwę dla aktywności:");
            var name = Console.ReadLine(); 
            var lastId = _activityService.GetLastId();
            Activity activity = new Activity(lastId + 1, name, (ActivityTypes)itemTypeId);
            switch (activity.TypeId)
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
            Double.TryParse(Console.ReadLine(), out quantity);
            Console.WriteLine("Podaj czas jaki zajeło wykonanie aktywności w minutach:");
            double activityTime;
            Double.TryParse(Console.ReadLine(), out activityTime);
            Console.WriteLine("Podaj wagę w dniu aktywności");
            double weight;
            Double.TryParse(Console.ReadLine(), out weight);

            activity.Weight = weight;
            activity.Quantity = quantity;
            activity.ActivtyTime = activityTime;
            activity.ActivityDate = DateTime.Now;
            _activityService.AddItem(activity);
            return activity.Id;
        }



        public int RemoveActivity()
        {
            Console.WriteLine("Wprowadź id aktywności, którą chcesz usunąć:");
            var itemId = Console.ReadLine();
            int removeId;
            Int32.TryParse(itemId, out removeId);


            Activity activityToRemove = new Activity();
            foreach (var item in _activityService.Items)
            {
                if (item.Id == removeId)
                {
                    activityToRemove = item;
                    break;
                }
            }

            _activityService.RemoveItem(activityToRemove);  
            
            return removeId;
        }



        public int ActivityDetailView()
        {
            Console.WriteLine("Wprowadź id aktywności, którą chcesz pokazać:");
            var itemId = Console.ReadLine();
            int detailId;
            Int32.TryParse(itemId, out detailId);
            Activity activityToShow = new Activity();
            foreach (var item in _activityService.Items)
            {
                if (item.Id == detailId)
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

            return detailId;
        }


        public ActivityTypes ActivityByTypeIdView()
        {
            Console.WriteLine("Podaj id typu aktywności , które chcesz wyświetlić:");
            Console.WriteLine("1 - Pływanie");
            Console.WriteLine("2 - Bieganie");
            Console.WriteLine("3 - Ćwiczenia");
            Console.WriteLine("4 - Wszystkie typy aktywności");
            var itemId = Console.ReadKey();
            int id;
            Int32.TryParse(itemId.KeyChar.ToString(), out id);

            ActivityTypes typeId = (ActivityTypes)id;

            List<Activity> toShow = new List<Activity>();
            int maxNameLength = 0;
            int maxIdLength = 0;
            foreach (var item in _activityService.Items)
            {
                if (item.TypeId == typeId || typeId == ActivityTypes.All)
                {
                    toShow.Add(item);
                    maxNameLength = Math.Max(maxNameLength, item.Name.Length);
                    maxIdLength = Math.Max(maxIdLength, item.Id.ToString().Length);
                }
            }

            var lineLength = maxIdLength + maxNameLength + 15;

            Console.WriteLine();
            if (toShow.Count > 0)
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

            return typeId;
        }

    }
}
