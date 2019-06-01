// MIT License
//
// Copyright (c) 2019 Peter Malik. (MalikP.)
// 
// File: GeneralParser.cs 
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
using System.Globalization;

using MalikP.IVAO.Library.Common.Parsers.DataExtractors.General;
using MalikP.IVAO.Library.Common.Selector;
using MalikP.IVAO.Library.Models.DataHolders;
using MalikP.IVAO.Library.Models.General;

namespace MalikP.IVAO.Library.Common.Parsers
{
    public sealed class GeneralParser : AbstractParser<GeneralData, IGeneralSelector>
    {
        private readonly IIVAOStringService _ivaoStringService;

        public GeneralParser(IGeneralSelector selector)
            : base(selector)
        {
            _ivaoStringService = new IVAOStringService();
        }

        public override object Parse(ISelectedData selectedData)
        {
            string[] data = RemoveSelector(selectedData.Data);

            if (data.Length == 0)
            {
                return null;
            }

            return GeneralDataBuilder.Create()
                .WithVersion(_ivaoStringService.IVAO_GetInt(new VersionExtractor().ExtractValue(data)))
                .WithReload(_ivaoStringService.IVAO_GetInt(new ReloadExtractor().ExtractValue(data)))
                .WithUpdate(_ivaoStringService.IVAO_GetDateTime(new UpdateExtractor().ExtractValue(data)) ?? DateTime.MinValue)
                .WithConnectedClients(_ivaoStringService.IVAO_GetInt(new ConnectedClientsExtractor().ExtractValue(data)))
                .WithConnectedServers(_ivaoStringService.IVAO_GetInt(new ConnectedServersExtractor().ExtractValue(data)))
                .WithConnectedAirports(_ivaoStringService.IVAO_GetInt(new ConnectedAirportsExtractor().ExtractValue(data)))
                .Build();
        }
    }
}
