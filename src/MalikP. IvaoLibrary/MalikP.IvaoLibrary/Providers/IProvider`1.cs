using System.Collections.Generic;

using MalikP.IvaoLibrary.Models;
using MalikP.IvaoLibrary.Models.DataHolders;

namespace MalikP.IvaoLibrary.Providers
{
    public interface IProvider<TModel> : IProvider
        where TModel : class, IIvaoModel
    {
        IEnumerable<TModel> GetData(IWhazzup whazzupData);
    }
}
