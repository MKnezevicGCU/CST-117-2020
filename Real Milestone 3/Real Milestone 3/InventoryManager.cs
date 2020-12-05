using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Milestone_3
{
    class InventoryManager
    {
        Dictionary<int, Product> inventoryList = new Dictionary<int, Product>();
        public void Add(Person person, Product product)
        {
            inventoryList.Add(person.Personid, product);

        }
        public void  Delete(int personID, int productID)
        {
            inventoryList[personID] = null;
        }

        public Product  Find(int personID, int ProductID)
        {
            return inventoryList[personID];
        }
    }
}
