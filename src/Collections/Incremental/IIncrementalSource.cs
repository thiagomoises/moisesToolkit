using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Moises.Toolkit.Collections
{
    public interface IIncrementalSource<TSource>
    {
        Task<IEnumerable<TSource>> GetPagedItemsAsync(int pageIndex, int pageSize, CancellationToken cancellationToken, object[] args);

    }
}
