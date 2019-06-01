// MIT License
//
// Copyright (c) 2019 Peter Malik. (MalikP.)
// 
// File: AbstractFilteredClientsDataProvider.cs 
// Company: MalikP.
//
// Repository: https://github.com/peterM/IVAO-Library
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System.Collections.Generic;
using System.Linq;

using MalikP.IVAO.Library.Common.Annotation;
using MalikP.IVAO.Library.Common.Enums;
using MalikP.IVAO.Library.Common.Indexes;
using MalikP.IVAO.Library.Common.Parsers;
using MalikP.IVAO.Library.Common.Selector;
using MalikP.IVAO.Library.Data.Source;
using MalikP.IVAO.Library.Models.Clients;
using MalikP.IVAO.Library.Models.DataHolders;

namespace MalikP.IVAO.Library.Providers
{
    public abstract class AbstractFilteredClientsDataProvider<TModel> : AbstractClientsDataProvider<TModel>
         where TModel : Client
    {
        protected AbstractFilteredClientsDataProvider(
            IIVAOWhazzupDataSource dataSource,
            IParserFactory parserFactory,
            IClientsSelector selector,
            ClientType clientType)
            : base(dataSource,
                   parserFactory,
                   selector)
        {
            SelectedClientType = clientType;
        }

        protected ClientType SelectedClientType { get; }

        protected override ISelectedData FilterSelectedData(ISelectedData selectedData)
        {
            selectedData = base.FilterSelectedData(selectedData);

            List<string> data = new List<string>();
            var selectorData = selectedData.Data.FirstOrDefault(d => d == Selector.Value);

            if (!string.IsNullOrEmpty(selectorData))
            {
                data.Add(selectorData);
            }

            data.AddRange(selectedData.Data.Where(CheckItem));

            return new SelectedData(data.ToArray());
        }

        private bool CheckItem(string row)
        {
            string[] data = row.Split(new char[] { ':' });

            return data.Length >= 47 && AnnotationExtensions.GetFromMap<ClientType>(data[ClientIndex.All.ClientType]) == SelectedClientType;
        }

        protected override IEnumerable<TModel> GetResult(object data)
        {
            if (data is IEnumerable<object> castedData)
            {
                return castedData.OfType<TModel>().ToList();
            }

            return Enumerable.Empty<TModel>();
        }
    }
}
