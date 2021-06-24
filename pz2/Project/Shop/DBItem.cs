using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class DBItem<T>
    {
        public List<T> Items { get; set; }
        public DBItem()
        {
            Items = new List<T>();
        }
        public void AddItem(T item)
        {
            Items.Add(item);
        }
    }
}
