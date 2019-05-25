﻿// MIT License
//
// Copyright (c) 2019 Peter Malik. (MalikP.)
// 
// File: AbstractGeneralDataValueExtractor.cs 
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

using System.Linq;

namespace MalikP.IVAO.Library.Common.Parsers.DataExtractors.General
{
    public abstract class AbstractGeneralDataValueExtractor : IGeneralDataExtractor
    {
        public AbstractGeneralDataValueExtractor(string selector)
        {
            Selector = selector;
        }

        public string Selector { get; }

        public string ExtractValue(string[] data)
        {
            return ExtractValue(data, Selector);
        }

        protected string ExtractValue(string[] data, string selector)
        {
            var selectedLine = data.FirstOrDefault(d => d.StartsWith(selector));
            if (string.IsNullOrEmpty(selectedLine))
            {
                return "-1";
            }

            return GetValue(selectedLine);
        }

        protected string GetValue(string data)
        {
            return data.Split(new char[] { '=' })[1].Trim();
        }
    }
}
