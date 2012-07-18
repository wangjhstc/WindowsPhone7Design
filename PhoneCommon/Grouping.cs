using System.Collections.ObjectModel;
using System.Linq;

namespace PhoneCommon
{
    public class Grouping<T> : ObservableCollection<T>, IGrouping<string, T>
    {
        public Grouping(string key)
        {
            Key = key;
        }

        public string Key { get; private set; }
    }
}
