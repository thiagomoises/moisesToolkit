using System.Threading.Tasks;

namespace Moises.Toolkit.Collections
{
    public interface IIncrementalLoadingCollection
    {
        Task<uint> LoadMoreItemsAsync(long count = 1);
        Task RefreshAsync();
    }
}
