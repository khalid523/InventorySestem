using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryDataAccess.Model
{
   public interface Igeneric<T> where T : class
    {
        void Insert(T obj);
        void Update(T obj);
        void Delete(int Id);
        T Load(int Id);
        List<T> LoadAll();

    }
}
