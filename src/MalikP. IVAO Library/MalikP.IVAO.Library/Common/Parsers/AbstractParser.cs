using System;
using System.Collections.Generic;
using System.Linq;

using MalikP.IVAO.Library.Common.Selector;
using MalikP.IVAO.Library.Models;
using MalikP.IVAO.Library.Models.DataHolders;

namespace MalikP.IVAO.Library.Common.Parsers
{
    public abstract class AbstractParser<TModel, TSelector> : IParser
        where TModel : IIvaoModel
        where TSelector : ISelector
    {
        public AbstractParser(TSelector selector)
        {
            Selector = selector;
        }

        protected TSelector Selector { get; }

        public virtual object Parse(ISelectedData selectedData)
        {
            string[] data = RemoveSelector(selectedData.Data);

            List<TModel> result = new List<TModel>();
            foreach (string row in data)
            {
                TModel item = CreateItem(row);

                if (item != null)
                {
                    result.Add(item);
                }
            }

            return result;
        }

        protected virtual TModel CreateItem(string row)
        {
            return default(TModel);
        }

        protected string[] RemoveSelector(string[] data)
        {
            return data.Where(d => d != Selector.Value).ToArray();
        }

        protected virtual string[] Split(string data)
        {
            return data.Split(new char[] { ':' }, StringSplitOptions.None);
        }
    }
}
