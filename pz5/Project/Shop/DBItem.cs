using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class DBItem<T> : IDBItem<T> where T : IID
    {
        private static DBItem<T> instance = null;
        public static DBItem<T> Instance()
        {
            if (instance == null)
            {
                instance = new DBItem<T>();
            }
            return instance;
        }
        public List<T> Items { get; set; }

        private DBItem()
        {
            Items = new List<T>();
        }
        public void AddItem(T item)
        {
            Items.Add(item);
        }
        public T FindByID(int ID)
        {
            T result = default(T);
            foreach (var item in Items)
            {
                if (item.ID == ID)
                {
                    result = item;
                }
            }
            return result;
        }

        public bool Delete(T item)
        {
            return Items.Remove(item);
        }

    }
}
