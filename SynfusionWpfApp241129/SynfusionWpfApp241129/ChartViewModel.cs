using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynfusionWpfApp241129
{
    public class ChartViewModel
    {
        public ObservableCollection<SalesInfo> SalesData { get; set; }

        public ChartViewModel ()
        {
            // 데모 데이터 추가
            SalesData = new ObservableCollection<SalesInfo>
            {
                new SalesInfo { Category = "Electronics", Sales = 15000 },
                new SalesInfo { Category = "Groceries", Sales = 12000 },
                new SalesInfo { Category = "Clothing", Sales = 8000 },
                new SalesInfo { Category = "Furniture", Sales = 10000 }
            };
        }
    }
    public class SalesInfo
    {
        public string Category { get; set; }
        public double Sales { get; set; }
    }
}
