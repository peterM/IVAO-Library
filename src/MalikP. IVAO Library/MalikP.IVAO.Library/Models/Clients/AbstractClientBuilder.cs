// MIT License
//
// Copyright (c) 2019 Peter Malik. (MalikP.)
// 
// File: AbstractClientBuilder.cs 
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
using MalikP.IVAO.Library.Models.Other;

namespace MalikP.IVAO.Library.Models.Clients
{
    public abstract class AbstractClientBuilder<TBuilder>
    {
        protected string callsign;
        protected string vid;
        protected string name;
        protected ClientType clientType;
        protected GPS location;
        protected string server;
        protected string protocol;
        protected DateTime connectionTime;
        protected string softwareName;
        protected string softwareVersion;
        protected AdministrativeRating administrativeVersion;
        protected int clientRating;

        public TBuilder WithCallsign(string callsign)
        {
            this.callsign = callsign;
            return GetBuilder();
        }

        public TBuilder WithVID(string vid)
        {
            this.vid = vid;
            return GetBuilder();
        }

        public TBuilder WithName(string name)
        {
            this.name = name;
            return GetBuilder();
        }

        protected TBuilder WithClientType(ClientType clientType)
        {
            this.clientType = clientType;
            return GetBuilder();
        }

        public TBuilder WithLocation(GPS location)
        {
            this.location = location;
            return GetBuilder();
        }

        public TBuilder WithServer(string server)
        {
            this.server = server;
            return GetBuilder();
        }

        public TBuilder WithProtocol(string protocol)
        {
            this.protocol = protocol;
            return GetBuilder();
        }

        public TBuilder WithConnectionTime(DateTime connectionTime)
        {
            this.connectionTime = connectionTime;
            return GetBuilder();
        }

        public TBuilder WithSoftwareName(string softwareName)
        {
            this.softwareName = softwareName;
            return GetBuilder();
        }

        public TBuilder WithSoftwareVersion(string softwareVersion)
        {
            this.softwareVersion = softwareVersion;
            return GetBuilder();
        }

        public TBuilder WithAdministrativeVersion(AdministrativeRating administrativeVersion)
        {
            this.administrativeVersion = administrativeVersion;
            return GetBuilder();
        }

        public TBuilder WithClientRating(int clientRating)
        {
            this.clientRating = clientRating;
            return GetBuilder();
        }

        protected abstract TBuilder GetBuilder();
    }
}
