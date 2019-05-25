// MIT License
//
// Copyright (c) 2019 Peter Malik. (MalikP.)
// 
// File: AbstractProvider.cs 
// Company: MalikP.
//
// Repository: https://github.com/peterM/IVAO-Net
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

using MalikP.IVAO.Library.Common.Parsers;
using MalikP.IVAO.Library.Common.Selector;
using MalikP.IVAO.Library.Models;
using MalikP.IVAO.Library.Models.DataHolders;

namespace MalikP.IVAO.Library.Providers
{
    public abstract class AbstractProvider<TResult, TSelector> : IProvider<TResult>
        where TResult : class, IIvaoModel
        where TSelector : ISelector
    {
        protected AbstractProvider(
            IParserFactory parserFactory,
            TSelector selector)
        {
            ParserFactory = parserFactory;
            Selector = selector;
        }

        protected IParserFactory ParserFactory { get; }

        protected TSelector Selector { get; }

        public IEnumerable<TResult> GetData(IWhazzup whazzupData)
        {
            ISelectedData selectedData = Selector.SelectData(whazzupData);

            IParser parser = ParserFactory.CreateParser(Selector);
            object resultData = parser.Parse(selectedData);

            return GetResult(resultData);
        }

        protected virtual IEnumerable<TResult> GetResult(object data)
        {
            if (data is IEnumerable<TResult> castedData)
            {
                return castedData;
            }

            return Enumerable.Empty<TResult>();
        }
    }
}
