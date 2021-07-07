
using Session25.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session25.Services
{
    public interface IItemStorage
    {
        public void AddItem(Customer item);
        public void RemoveItem(int id);
        public List<Customer> GetAllItems();
        public Customer GetById(int id);
    }

        public class MemoryItemStorage : IItemStorage
        {
            private List<Customer> innerList { get; set; }

            public MemoryItemStorage()
            {
                innerList = new List<Customer>();
            }

            public void AddItem(Customer item)
            {
                if (item.Id == 0)
                {
                    item.Id = innerList.Count + 1;
                    innerList.Add(item);
                    return;
                }

                var selectedItem = GetById(item.Id);
                
                selectedItem.Name = item.Name;
                selectedItem.Surname = item.Surname;
                selectedItem.AFM = item.AFM;
                selectedItem.Active = item.Active;

             }

            public List<Customer> GetAllItems()
            {
                return innerList;
            }

            public Customer GetById(int id)
            {
                return innerList.FirstOrDefault(item => item.Id == id);
            }

            public void RemoveItem(int id)
            {
                var selectedItem = GetById(id);
                if (selectedItem == null)
                    throw new Exception(string.Format("Customer with id '{0}' was not found.", id));

                innerList.Remove(selectedItem);
            }
        }
}
