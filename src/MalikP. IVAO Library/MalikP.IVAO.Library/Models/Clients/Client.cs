// MIT License
//
// Copyright (c) 2019 Peter Malik. (MalikP.)
// 
// File: Client.cs 
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
    public abstract class Client : IIvaoModel
    {
        public Client(
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
            int clientRating)
        {
            Callsign = callsign;
            VID = vid;
            Name = name;
            ClientType = clientType;
            Location = location;
            Server = server;
            Protocol = protocol;
            ConnectionTime = connectionTime;
            SoftwareName = softwareName;

            // TODO: Possible to use 'Version' type
            SoftwareVersion = softwareVersion;
            AdministrativeVersion = administrativeVersion;
            ClientRating = clientRating;
        }

        public string Callsign { get; }

        public string VID { get; }

        public string Name { get; }

        public ClientType ClientType { get; }

        [Unit("N/A")]
        public GPS Location { get; }

        public string Server { get; }

        public string Protocol { get; }

        public DateTime ConnectionTime { get; }

        public string SoftwareName { get; }

        public string SoftwareVersion { get; }

        public AdministrativeRating AdministrativeVersion { get; }

        public int ClientRating { get; }
    }
}
