// MIT License
//
// Copyright (c) 2019 Peter Malik. (MalikP.)
// 
// File: GeneralParser.cs 
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
using System;
using System.Globalization;

using MalikP.IVAO.Library.Common.Parsers.DataExtractors.General;
using MalikP.IVAO.Library.Common.Selector;
using MalikP.IVAO.Library.Models.DataHolders;
using MalikP.IVAO.Library.Models.General;

namespace MalikP.IVAO.Library.Common.Parsers
{
    public sealed class GeneralParser : AbstractParser<GeneralData, IGeneralSelector>
    {
        private const string dateTimeFormat = "yyyyMMddHHmmss";

        public GeneralParser(IGeneralSelector selector)
            : base(selector)
        {
        }

        public override object Parse(ISelectedData selectedData)
        {
            string[] data = RemoveSelector(selectedData.Data);

            return GeneralDataBuilder.Create()
                .WithVersion(int.Parse(new VersionExtractor().ExtractValue(data)))
                .WithReload(int.Parse(new ReloadExtractor().ExtractValue(data)))
                .WithUpdate(DateTime.ParseExact(new UpdateExtractor().ExtractValue(data), dateTimeFormat, CultureInfo.InvariantCulture))
                .WithConnectedClients(int.Parse(new ConnectedClientsExtractor().ExtractValue(data)))
                .WithConnectedServers(int.Parse(new ConnectedServersExtractor().ExtractValue(data)))
                .WithConnectedAirports(int.Parse(new ConnectedAirportsExtractor().ExtractValue(data)))
                .Build();
        }
    }
}
