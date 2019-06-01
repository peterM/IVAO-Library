// MIT License
//
// Copyright (c) 2019 Peter Malik. (MalikP.)
// 
// File: AbstractParser.cs 
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
