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
