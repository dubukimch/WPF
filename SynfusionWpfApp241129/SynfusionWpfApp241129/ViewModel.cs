using System.Collections.ObjectModel;

namespace SyncfusionMapExample
{
    public class CountryInfo
    {
        public string ADM0_A3_US { get; set; } // 국가 코드
        public string SOVEREIGNT { get; set; } // 국가 이름
    }

    public class ViewModel
    {
        public ObservableCollection<CountryInfo> CountryData { get; set; }

        public ViewModel()
        {
            CountryData = new ObservableCollection<CountryInfo>
            {
                new CountryInfo { ADM0_A3_US = "IDN", SOVEREIGNT = "Indonesia" },
                new CountryInfo { ADM0_A3_US = "MYS", SOVEREIGNT = "Malaysia" },
                new CountryInfo { ADM0_A3_US = "CHL", SOVEREIGNT = "Chile" },
                new CountryInfo { ADM0_A3_US = "BOL", SOVEREIGNT = "Bolivia" },
                new CountryInfo { ADM0_A3_US = "PER", SOVEREIGNT = "Peru" }
            };
        }
    }
}
