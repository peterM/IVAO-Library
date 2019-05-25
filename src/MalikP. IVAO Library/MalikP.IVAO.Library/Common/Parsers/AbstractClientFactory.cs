using System;

using MalikP.IVAO.Library.Common.Enums;
using MalikP.IVAO.Library.Common.Indexes;
using MalikP.IVAO.Library.Common.Parsers.DataExtractors.Client;
using MalikP.IVAO.Library.Models.Clients;
using MalikP.IVAO.Library.Models.Other;

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

            return builder
                .WithCallsign(rowData[ClientIndex.All.Callsign])
                .WithVID(rowData[ClientIndex.All.VID])
                .WithName(rowData[ClientIndex.All.Name])
                .WithClientType(TargetClientType)
                .WithLocation(location)
                .WithServer(rowData[ClientIndex.All.Server])
                .WithProtocol(rowData[ClientIndex.All.Protocol])
                .WithConnectionTime(_ivaoStringService.IVAO_GetDateTime(rowData[ClientIndex.All.ConnectionTime]) ?? DateTime.MinValue)
                .WithSoftwareName(rowData[ClientIndex.All.SoftwareName])
                .WithSoftwareVersion(rowData[ClientIndex.All.SoftwareVersion])
                .WithAdministrativeVersion((AdministrativeRating)_ivaoStringService.IVAO_GetInt(rowData[ClientIndex.All.AdministrativeVersion]))
                .WithClientRating(_ivaoStringService.IVAO_GetInt(rowData[ClientIndex.All.ClientRating]));
        }
    }
}