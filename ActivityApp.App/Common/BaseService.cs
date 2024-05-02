﻿using ActivityApp.App.Abstract;
using ActivityApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityApp.App.Common
{
    public class BaseService<T> : IService<T> where T : BaseEntity
    {
        public List<T> Items { get ; set ; }

        public BaseService() 
        {
            Items = new List<T>();
        }
        public int AddItem(T item)
        {
            Items.Add(item);
            return item.Id;
        }

        public List<T> GetAllItems()
        {
            return Items;    
        }

        public void RemoveItem(T item)
        {
            Items.Remove(item); 
        }

        public int UpdadeItem(T item)
        {
            var entity = Items.FirstOrDefault(p => p.Id == item.Id);
            if (entity != null)
            {
                entity = item;
            }

            return entity.Id;
        }

        public int GetLastId()
        {
            int lastId;
            if (Items.Any())
            {
                lastId = Items.OrderBy(p => p.Id).LastOrDefault().Id;
            } 
            else
            {
                lastId = 0;
            }
            return lastId;

        }

    }
}
