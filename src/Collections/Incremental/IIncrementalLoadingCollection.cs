using System.Collections;
using System.Threading.Tasks;

namespace Moises.Toolkit.Collections
{
    public interface IIncrementalLoadingCollection : IEnumerable
    {

        void SetArgs(object[] args);

        Task<uint> LoadMoreItemsAsync(long count = 1);
        Task RefreshAsync();
        void InsertItem(object o);
    }
}
