using MalikP.IvaoLibrary.Common.Enums;
using MalikP.IvaoLibrary.Common.Indexes;
using MalikP.IvaoLibrary.Models.Clients;
using MalikP.IvaoLibrary.Models.Other;

namespace MalikP.IvaoLibrary.Common.Parsers
{
    public abstract class AbstractClientFactory<TClient> : ICLientFactory<TClient>
        where TClient : Client
    {
        protected AbstractClientFactory(ClientType clientType)
        {
            TargetClientType = clientType;
        }

        public ClientType TargetClientType { get; }

        public abstract TClient Create(string[] rowData);

        Client ICLientFactory.Create(string[] rowData)
        {
            return Create(rowData);
        }

        protected GPS GetLocation(string[] rowData)
        {
            return GPSBuilder.Create()
                .WithLatitude(double.Parse(GetValue(rowData[ClientIndex.All.GPS.Latitude])))
                .WithLongitude(double.Parse(GetValue(rowData[ClientIndex.All.GPS.Longitude])))
                .WithAltitude(int.Parse(GetValue(rowData[ClientIndex.All.GPS.Altitude])))
                .Build();
        }

        private string GetValue(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return "0";
            }

            return value;
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
                .WithConnectionTime(rowData[ClientIndex.All.ConnectionTime])
                .WithSoftwareName(rowData[ClientIndex.All.SoftwareName])
                .WithSoftwareVersion(rowData[ClientIndex.All.SoftwareVersion])
                .WithAdministrativeVersion(rowData[ClientIndex.All.AdministrativeVersion])
                .WithVersion(rowData[ClientIndex.All.AtcPilotVersion]);
        }
    }
}