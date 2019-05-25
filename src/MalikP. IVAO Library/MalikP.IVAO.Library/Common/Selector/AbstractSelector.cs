// MIT License
//
// Copyright (c) 2019 Peter Malik. (MalikP.)
// 
// File: AbstractSelector.cs 
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

using MalikP.IVAO.Library.Models.DataHolders;

namespace MalikP.IVAO.Library.Common.Selector
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
            if (dataLines.Length == 0)
            {
                yield break;
            }

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
