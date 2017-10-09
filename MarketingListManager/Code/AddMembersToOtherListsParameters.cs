using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketingListManager.Code
{
    public class AddMembersToOtherListsParameters
    {
        public MarketingListItem SourceList { get; set; }
        public IList<MarketingListItem> DestinationLists { get; set; }
    }
}
