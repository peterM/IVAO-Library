using MalikP.IVAO.Library.Models.DataHolders;

namespace MalikP.IVAO.Library.Common.Selector
{
    public interface ISelector
    {
        string Value { get; }

        ISelectedData SelectData(IWhazzup whazzupData);
    }
}
