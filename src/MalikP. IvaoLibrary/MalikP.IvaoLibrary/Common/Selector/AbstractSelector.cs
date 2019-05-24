using System.Collections.Generic;
using System.Linq;

using MalikP.IvaoLibrary.Models.DataHolders;

namespace MalikP.IvaoLibrary.Common.Selector
{
    public abstract class AbstractSelector : ISelector
    {
        protected AbstractSelector(string selectorValue)
        {
            Value = selectorValue;
        }

        public string Value { get; }

        public ISelectedData SelectData(IWhazzup whazzupData)
        {
            IEnumerable<string> data = SelectDataInternal(whazzupData.Data);
            return new SelectedData(data.ToArray());
        }

        private IEnumerable<string> SelectDataInternal(string[] dataLines)
        {
            int startIndex = dataLines.ToList().IndexOf(Value);
            for (int i = startIndex; i < dataLines.Length; i++)
            {
                if (dataLines[i].StartsWith("!") && dataLines[i] != Value)
                {
                    yield break;
                }

                yield return dataLines[i];
            }
        }
    }
}
