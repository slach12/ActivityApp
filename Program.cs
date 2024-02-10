namespace ActivityApp
{
    public class Program
    {
        public const string FILE_NAME = @"C:\Exercises \ImportFile.xlsx";//@ oznacza żeby traktować ukośnik"\" jako zwykły znak

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            /*
                Program tworzy zestawienie aktywności fizycznych, każda aktywność ma typ : pływanie , bieganie , ćwiczenie.
                Klasa aktywność ma własności:
                >	Data aktywności
                >   Ilość:
                        o Pływanie -ilość basenów
                        o   Bieganie - dystans
                        o Ćwiczenie – ilość powtórzeń
                >   Wartość:
                        o Pływanie – długość basenu
                        o Ćwiczenie – waga obciążenia
                        o Bieganie – nachylenie bierźni
                >  	Czas trwania aktywności
                >	Waga po ćwiczeniach
                >	Opcjonalnie spalone kalorie.
                Program będzie potrafił:
                •	Dodać aktywność
                •	Usunąć aktywność
                •	Edytować aktywność
                •	Zrobić zestawienie aktywności po typie
                •	Zrobić zestawienie aktywności w zadanym okresie czasu
            */

            //Użytkownik zostanie przywitany
            /////###################################a. Stworzenie nowej aktywności
            /////###################################b. Usunięcie aktywności
            /////###################################c. Wyświetlenie aktywności
            /////###################################d. Zwrócenie listy aktywności o zadanym filtrze (nazwa kategorii) 
            /////################################### - listę aktywności danej kategorii, dla typu wszystkie wyświetli wszystkie aktywności 
            /////###################################a1. Najpierw dostanę wyboru kategorię aktywności
            /////###################################a2. Zostanę poproszony o wprowadzenie wszystkich szczegułów
            /////###################################b1. Zostanę poproszony o id albo nazwę aktywności
            /////###################################b2. Usunę tę aktywność z listy aktywności
            /////###################################c1. Zostanę poproszony o wprowadzenie id aktywności
            /////###################################c2. Wyświetlę wszystkie informacje związane z tą aktywnością
            /////###################################d1. Zostanę poproszony o wprowadzenie nazwy albo id kategorii
            /////###################################d2. Wyświetlę listę aktywności


            Console.WriteLine("Witam w  Activty App!");
            MenuActionService actionService = new MenuActionService();
            actionService = Initialize(actionService);
            ActivityService itemService = new ActivityService();
            while (true)
            {

                Console.WriteLine("Powiedz mi co chesz zrobić:");
                var mainMenu = actionService.GetMenuActionsByMenuName("Main");
                for (int i = 0; i < mainMenu.Count; i++)
                {
                    Console.WriteLine($"{mainMenu[i].Id}. {mainMenu[i].Name}");
                }
                var operation = Console.ReadKey();
                Console.WriteLine();

                switch (operation.KeyChar)
                {
                    case '1':
                        var keyInfo = itemService.AddNewActivityView(actionService);
                        var id = itemService.AddActivityItem(keyInfo.KeyChar);
                        break;
                    case '2':
                        var removeId = itemService.RemoveActivityView();
                        itemService.RemoveActivity(removeId);
                        break;
                    case '3':
                        var detailId = itemService.ActivityDetailSelectionView();
                        itemService.ActivityDetailView(detailId);
                        break;
                    case '4':
                        var typeId = itemService.ActivityTypeSelectionView();
                        itemService.ActivityByTypeIdView(typeId);
                        break;

                    default:
                        Console.WriteLine("Polecenie, które wybrałeś nie istnieje.");
                        break;
                }
                Console.WriteLine();
            }



        }

        private static MenuActionService Initialize(MenuActionService actionService)
        {
            actionService.AddNewAction(1, "Dodaj aktywność", "Main");
            actionService.AddNewAction(2, "Usuń aktwyność", "Main");
            actionService.AddNewAction(3, "Pokaż detale aktywności", "Main");
            actionService.AddNewAction(4, "Lista aktywności", "Main");

            actionService.AddNewAction(1, "Pływanie", "AddNewItemMenu");
            actionService.AddNewAction(2, "Bieganie", "AddNewItemMenu");
            actionService.AddNewAction(3, "Ćwiczenia", "AddNewItemMenu");

            return actionService;
        }
    }
}
