// MIT License
//
// Copyright (c) 2019 Peter Malik. (MalikP.)
// 
// File: AbstractClientFactory.cs 
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

using MalikP.IVAO.Library.Common.Enums;
using MalikP.IVAO.Library.Common.Indexes;
using MalikP.IVAO.Library.Common.Parsers.DataExtractors.Client;
using MalikP.IVAO.Library.Models.Clients;
using MalikP.IVAO.Library.Models.Other;
using MalikP.IVAO.Library.Models.Servers;

namespace MalikP.IVAO.Library.Common.Parsers
{
    public abstract class AbstractClientFactory<TClient> : ICLientFactory<TClient>
        where TClient : Client
    {
        private readonly ILocationExtractor _locationExtractor;
        private readonly IIVAOStringService _ivaoStringService;

        protected AbstractClientFactory(ClientType clientType)
        {
            _locationExtractor = new LocationExtractor();
            _ivaoStringService = new IVAOStringService();

            TargetClientType = clientType;
        }

        protected IIVAOStringService StringService => _ivaoStringService;

        public ClientType TargetClientType { get; }

        public abstract TClient Create(string[] rowData);

        Client ICLientFactory.Create(string[] rowData)
        {
            return Create(rowData);
        }

        protected GPS GetLocation(string[] rowData)
        {
            return _locationExtractor.ExtractValue(rowData);
        }

        protected TBuilder AssignGeneralData<TBuilder>(TBuilder builder, string[] rowData)
            where TBuilder : AbstractClientBuilder<TBuilder>
        {
            GPS location = GetLocation(rowData);
            Server server = GetServer(rowData);

            return builder
                .WithCallsign(rowData[ClientIndex.All.Callsign])
                .WithVID(rowData[ClientIndex.All.VID])
                .WithName(rowData[ClientIndex.All.Name])
                .WithLocation(location)
                .WithServer(server)
                .WithProtocol(rowData[ClientIndex.All.Protocol])
                .WithConnectionTime(_ivaoStringService.IVAO_GetDateTime(rowData[ClientIndex.All.ConnectionTime]) ?? DateTime.MinValue)
                .WithSoftwareName(rowData[ClientIndex.All.SoftwareName])
                .WithSoftwareVersion(rowData[ClientIndex.All.SoftwareVersion])
                .WithAdministrativeVersion((AdministrativeRating)_ivaoStringService.IVAO_GetInt(rowData[ClientIndex.All.AdministrativeVersion]))
                .WithClientRating(_ivaoStringService.IVAO_GetInt(rowData[ClientIndex.All.ClientRating]));
        }

        private Server GetServer(string[] rowData)
        {
            return ServerBuilder.Create()
                .WithHostname(rowData[ClientIndex.All.Server])
                .Build();
        }
    }
}