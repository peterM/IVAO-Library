using System.Collections.Generic;

using MalikP.IVAO.Library.Models;
using MalikP.IVAO.Library.Models.DataHolders;

namespace MalikP.IVAO.Library.Providers
{
    public interface IProvider<TModel> : IProvider
        where TModel : class, IIvaoModel
    {
        IEnumerable<TModel> GetData(IWhazzup whazzupData);
    }
}
