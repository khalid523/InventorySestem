using InventoryDataAccess.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryBusiness_Logic.specificRepository
{
   public interface IAttributesService
    {
        List<Attributes> LoadAll();
        List<VmAttribute> loadCount(int Id);
    }
}
