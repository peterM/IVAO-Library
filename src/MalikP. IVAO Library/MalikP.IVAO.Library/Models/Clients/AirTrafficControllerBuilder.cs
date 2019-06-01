// MIT License
//
// Copyright (c) 2019 Peter Malik. (MalikP.)
// 
// File: AirTrafficControllerBuilder.cs 
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

using MalikP.IVAO.Library.Common.Enums;

namespace MalikP.IVAO.Library.Models.Clients
{
    public sealed class AirTrafficControllerBuilder : AbstractClientBuilder<AirTrafficControllerBuilder>
    {
        private string _frequency;
        private FacilityType _facilityType;
        private int _visualRange;
        private string _atis;
        private DateTime? _atisTime;

        private ATCRating _rating;

        private AirTrafficControllerBuilder()
        {
        }

        public static AirTrafficControllerBuilder Create()
        {
            return new AirTrafficControllerBuilder().WithClientType(ClientType.ATC);
        }

        public AirTrafficControllerBuilder WithFrequency(string frequency)
        {
            _frequency = frequency;
            return this;
        }

        public AirTrafficControllerBuilder WithFacilityType(FacilityType facilityType)
        {
            _facilityType = facilityType;
            return this;
        }

        public AirTrafficControllerBuilder WithVisualRange(int visualRange)
        {
            _visualRange = visualRange;
            return this;
        }

        public AirTrafficControllerBuilder WithATIS(string atis)
        {
            _atis = atis;
            return this;
        }

        public AirTrafficControllerBuilder WithATISTime(DateTime? atisTime)
        {
            _atisTime = atisTime;
            return this;
        }

        public AirTrafficControllerBuilder WithRating(ATCRating rating)
        {
            _rating = rating;
            return this;
        }

        public AirTrafficController Build()
        {
            return new AirTrafficController(
                callsign,
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
                _rating,
                _frequency,
                _facilityType,
                _visualRange,
                _atis,
                _atisTime);
        }

        protected override AirTrafficControllerBuilder GetBuilder()
        {
            return this;
        }
    }
}
