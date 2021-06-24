using System.Collections.Generic;

namespace Shop
{
    interface IDBItem<T> where T : IID
    {
        List<T> Items { get; set; }

        void AddItem(T item);
        bool Delete(T item);
        T FindByID(int ID);
    }
}