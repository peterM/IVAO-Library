// MIT License
//
// Copyright (c) 2019 Peter Malik. (MalikP.)
// 
// File: AirportParser.cs 
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

using MalikP.IVAO.Library.Common.Indexes;
using MalikP.IVAO.Library.Common.Selector;
using MalikP.IVAO.Library.Models.Airports;

namespace MalikP.IVAO.Library.Common.Parsers
{
    public sealed class AirportParser : AbstractParser<Airport, IAirportsSelector>
    {
        public AirportParser(IAirportsSelector selector)
            : base(selector)
        {
        }

        protected override Airport CreateItem(string data)
        {
            if (string.IsNullOrWhiteSpace(data))
            {
                return null;
            }

            string[] dataItems = Split(data);

            return AirportBuilder.Create()
                .WithICAO(dataItems[(int)AirportIndex.ICAO])
                .WithATIS(dataItems[(int)AirportIndex.ATIS])
                .Build();
        }
    }
}
