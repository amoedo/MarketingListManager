using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketingListManager.Code
{
    public class MarketingListItem
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        public string Query { get; set; }
        public long Count { get; set; }
        public int Type { get; set; }
        public bool Dynamic { get; set; }
        public Entity FullRecord { get; set; }


        public static List<MarketingListItem> LoadFromEntityCollection(EntityCollection collection)
        {
            if (collection.Entities == null) return null;

            List<MarketingListItem> result = new List<MarketingListItem>(collection.Entities.Count);

            foreach (var item in collection.Entities)
            {
                var newList = new MarketingListItem() { 
                    Id = (Guid)item["listid"],                     
                    Name = (string)item["listname"],                    
                    Dynamic = (bool)item["type"],
                    Type = (int)item["membertype"],
                    FullRecord = item
                };
                
                if (item.Contains("membercount")) newList.Count = (int)item["membercount"];
                if (item.Contains("query")) newList.Query = (string)item["query"];

                result.Add(newList);
            }

            return result;
        }

    }
}
