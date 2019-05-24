using MalikP.IvaoLibrary.Models.DataHolders;

namespace MalikP.IvaoLibrary.Common.Selector
{
    public interface ISelector
    {
        string Value { get; }

        ISelectedData SelectData(IWhazzup whazzupData);
    }
}
