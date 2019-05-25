using System;
using MalikP.IVAO.Library.Common.Annotation;
using MalikP.IVAO.Library.Common.Enums;
using MalikP.IVAO.Library.Models.Other;

namespace MalikP.IVAO.Library.Models.Clients
{
    public sealed class AirTrafficController : ClientWithRating<ATCRating>
    {
        public AirTrafficController(
            string callsign,
            string vid,
            string name,
            ClientType clientType,
            GPS location,
            string server,
            string protocol,
            DateTime connectionTime,
            string softwareName,
            string softwareVersion,
            AdministrativeRating administrativeVersion,
            int clientRating,
            ATCRating rating,
            string frequency,
            FacilityType facilityType,
            int visualRange,
            string atis,
            DateTime? atisTime)
            : base(callsign,
                   vid,
                   name,
                   clientType,
                   location,
                   server,
                   protocol,
                   connectionTime,
                   softwareName,
                   softwareVersion,
                   administrativeVersion,
                   clientRating,
                   rating)
        {
            Frequency = frequency;
            FacilityType = facilityType;
            VisualRange = visualRange;
            ATIS = atis;
            ATISTime = atisTime;
        }

        public string Frequency { get; }

        public decimal Freq => decimal.Parse(Frequency);

        public FacilityType FacilityType { get; }

        [Unit("NM")]
        public int VisualRange { get; }

        // todo: create type ATIS
        public string ATIS { get; }

        public DateTime? ATISTime { get; }
    }
}
