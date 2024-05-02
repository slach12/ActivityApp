using ActivityApp.App.Common;
using ActivityApp.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ActivityApp.App.Concrete
{
    public class MenuActionService : BaseService<MenuAction>
    {
    
        public MenuActionService() 
        {
            Initialize();
        }
        public List<MenuAction> GetMenuActionsByMenuName(string menuName)
        {
            List<MenuAction> result = new List<MenuAction>();
            foreach (var menuAction in Items ) 
            {
                if(menuAction.MenuName == menuName)
                {
                    result.Add(menuAction);
                }
            }
            return result;
        }


        private void Initialize()
        {
        

            AddItem(new MenuAction(1, "Dodaj aktywność", "Main"));
            AddItem(new MenuAction(2, "Usuń aktwyność", "Main"));
            AddItem(new MenuAction(3, "Pokaż detale aktywności", "Main"));
            AddItem(new MenuAction(4, "Lista aktywności", "Main"));

            AddItem(new MenuAction(1, "Pływanie", "AddNewItemMenu"));
            AddItem(new MenuAction(2, "Bieganie", "AddNewItemMenu"));
            AddItem(new MenuAction(3, "Ćwiczenia", "AddNewItemMenu"));


        }

    }

}
