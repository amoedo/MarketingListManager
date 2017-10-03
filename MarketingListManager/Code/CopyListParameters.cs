using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketingListManager.Code
{
    public class CopyListParameters
    {
        public MarketingListItem MarketingList { get; set; }
        public string NewName { get; set; }
        public Guid NewListId { get; set; }
        public Action<CopyListParameters> NextFunction {get;set; }
    }
}
