// MIT License
//
// Copyright (c) 2019 Peter Malik. (MalikP.)
// 
// File: AirTrafficController.cs 
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
using System.Runtime.Serialization;

using MalikP.IVAO.Library.Common.Annotation;
using MalikP.IVAO.Library.Common.Enums;
using MalikP.IVAO.Library.Models.Other;

namespace MalikP.IVAO.Library.Models.Clients
{
    [DataContract]
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
            Frequency = frequency ?? string.Empty;
            FacilityType = facilityType;
            VisualRange = visualRange;
            ATIS = atis ?? string.Empty;
            ATISTime = atisTime;
        }

        private AirTrafficController()
        {
        }

        [DataMember]
        public string Frequency { get; private set; }

        public decimal Freq => decimal.Parse(Frequency);

        [DataMember]
        public FacilityType FacilityType { get; private set; }

        [Unit("NM")]
        [DataMember]
        public int VisualRange { get; private set; }

        // todo: create type ATIS
        [DataMember]
        public string ATIS { get; private set; }

        [DataMember]
        public DateTime? ATISTime { get; private set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, null))
            {
                return false;
            }

            if (ReferenceEquals(obj, this))
            {
                return true;
            }

            AirTrafficController casted = obj as AirTrafficController;
            if (casted == null)
            {
                return false;
            }

            return base.Equals(obj)
                && string.Equals(casted.Frequency, Frequency, StringComparison.InvariantCultureIgnoreCase)
                && Equals(casted.FacilityType, FacilityType)
                && Equals(casted.VisualRange, VisualRange)
                && string.Equals(casted.ATIS, ATIS, StringComparison.InvariantCultureIgnoreCase)
                && Equals(casted.ATISTime, ATISTime);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return base.GetHashCode()
                    + (Frequency.ToUpper().GetHashCode() * 3)
                    + (FacilityType.GetHashCode() * 3)
                    + (VisualRange.GetHashCode() * 3)
                    + (ATIS.ToUpper().GetHashCode() * 3)
                    + (ATISTime.GetHashCode() * 3) * 17;
            }
        }
    }
}
