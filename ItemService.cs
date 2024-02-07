using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityApp
{
    public class ItemService
    {
        public List<Item> Items;

        public ItemService() 
        {
            Items = new List<Item>();

            InitializeTestingData();
        }

        private void InitializeTestingData()
        {
            var Item = new Item();
            Item.Id = 1;
            Item.Name = "Bieganie 5 km + 10 km";
            Item.TypeId = ItemTypes.Running;
            Item.ActivityDate = DateTime.Now;
            Item.Quantity = 15;
            Item.ActivtyTime = 120;
            Item.Weight = 84;
            Items.Add(Item);


            Item = new Item();
            Item.Id = 11;
            Item.Name = "Bieganie 5 km + 10 km";
            Item.TypeId = ItemTypes.Running;
            Item.ActivityDate = DateTime.Now;
            Item.Quantity = 15;
            Item.ActivtyTime = 120;
            Item.Weight = 84;
            Items.Add(Item);



            Item = new Item();
            Item.Id = 2;
            Item.Name = "Grzbiet";
            Item.TypeId = ItemTypes.Swimming;
            Item.ActivityDate = DateTime.Now;
            Item.Quantity = 60;
            Item.ActivtyTime = 67;
            Item.Weight = 84;
            Items.Add(Item);

            Item = new Item();
            Item.Id = 22;
            Item.Name = "Grzbiet";
            Item.TypeId = ItemTypes.Swimming;
            Item.ActivityDate = DateTime.Now;
            Item.Quantity = 40;
            Item.ActivtyTime = 50;
            Item.Weight = 84;
            Items.Add(Item);

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

        public ConsoleKeyInfo AddNewItemView(MenuActionService actionService)
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

        public int AddNewItem(char itemType)
        {
            int itemTypeId;
            Int32.TryParse(itemType.ToString(), out itemTypeId);    
            Item item = new Item();
            item.TypeId = (ItemTypes)itemTypeId;
            Console.WriteLine();
            Console.WriteLine("Podaj id dla nowej aktywności:");
            var id = Console.ReadLine();
            int itemId;
            Int32.TryParse(id, out itemId);
            Console.WriteLine("Podaj nazwę dla aktywności:");
            var name = Console.ReadLine();


            switch (item.TypeId)
            {
                case ItemTypes.Swimming:
                    Console.WriteLine("Podaj ilość przepłyniętych basenów dwudziesto-pięcio metrowych:");
                    break;
                case ItemTypes.Running: 
                    Console.WriteLine("Podaj pokonany dystans w kilometach:");
                    break;
                case ItemTypes.Exercising: 
                    Console.WriteLine("Podaj ilość wykonanych powtórzeń:");
                    break;

            }

            /*Console.WriteLine("Podaj ilość aktywności:");
            Console.WriteLine("Pływanie  - liczba przepłyniętych basenów (25 m)");
            Console.WriteLine("Bieganie  - pokonany dystans w kilometrach");
            Console.WriteLine("Ćwiczenie - ilość wykonanych powtórzeń");
*/

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


            
            Items.Add(item);
            return itemId;


        }

        public int RemoveItemView()
        {
            Console.WriteLine("Wprowadź id aktywności, którą chcesz usunąć:");
            var itemId = Console.ReadKey();
            int id;
            Int32.TryParse(itemId.KeyChar.ToString(), out id);  


            return id;
        }

        public void RemoveItem(int removeId)
        {
            Item activityToRemove = new Item();
            foreach (var item in Items)
            {
                if (item.Id == removeId)
                {
                    activityToRemove = item;
                    break;
                }
            }
            Items.Remove(activityToRemove);
        }

        public int ItemDetailSelectionView()
        {
            Console.WriteLine("Wprowadź id aktywności, którą chcesz pokazać:");
            var itemId = Console.ReadKey();
            int id;
            Int32.TryParse(itemId.KeyChar.ToString(), out id);


            return id;
        }

        public void ItemDetailView(int detailId)
        {
            Item activityToShow = new Item();
            foreach(var item in Items)
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

        public ItemTypes ItemTypeSelectionView()
        {
            Console.WriteLine("Podaj id typu aktywności , które chcesz wyświetlić:");
            Console.WriteLine("1 - Pływanie");
            Console.WriteLine("2 - Bieganie");
            Console.WriteLine("3 - Ćwiczenia");
            Console.WriteLine("4 - Wszystkie typy aktywności");
            var itemId = Console.ReadKey();
            int id;
            Int32.TryParse(itemId.KeyChar.ToString(), out id);

            ItemTypes idType = (ItemTypes)id;

            return idType;
        }

        public void ItemByTypeIdView(ItemTypes typeId)
        {
            List<Item> toShow = new List<Item>();
            int maxNameLength = 0;
            foreach (var item in Items)
            {
                if (item.TypeId == typeId || typeId == ItemTypes.All)
                {
                    toShow.Add(item);
                    maxNameLength = Math.Max(maxNameLength, item.Name.Length); 
                
                }
            }
            
            
            //toDo
            //Zrobić metodę wyświetlającą
            string line = "-";
            for(int i =0; i<maxNameLength*2; i++)
            {
                line = line + "-";  
            }
            Console.WriteLine();
            if(toShow.Count > 0)
            {
                Console.WriteLine(line);
                foreach (var item in toShow)
                {
                    Console.WriteLine($"Id : {item.Id} | Name : {item.Name}");
                }
                Console.WriteLine(line);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Nieznalezionego żadnej aktywności typu : {typeId.ToString()}");
            }
            
        }
    }
}
