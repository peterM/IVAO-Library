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
using System.Runtime.Serialization;

using MalikP.IVAO.Library.Common.Annotation;
using MalikP.IVAO.Library.Common.Enums;
using MalikP.IVAO.Library.Models.Other;

namespace MalikP.IVAO.Library.Models.Clients
{
    [DataContract]
    public abstract class Client : AbstractIvaoModel
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
            Callsign = callsign ?? string.Empty;
            VID = vid ?? string.Empty;
            Name = name ?? string.Empty;
            ClientType = clientType;
            Location = location;
            Server = server ?? string.Empty;
            Protocol = protocol ?? string.Empty;
            ConnectionTime = connectionTime;
            SoftwareName = softwareName ?? string.Empty;

            // TODO: Possible to use 'Version' type
            SoftwareVersion = softwareVersion ?? string.Empty;
            AdministrativeVersion = administrativeVersion;
            ClientRating = clientRating;
        }

        protected Client()
        {
        }

        [DataMember]
        public string Callsign { get; private set; }

        [DataMember]
        public string VID { get; private set; }

        [DataMember]
        public string Name { get; private set; }

        [DataMember]
        public ClientType ClientType { get; private set; }

        [Unit("N/A")]
        [DataMember]
        public GPS Location { get; private set; }

        [DataMember]
        public string Server { get; private set; }

        [DataMember]
        public string Protocol { get; private set; }

        [DataMember]
        public DateTime ConnectionTime { get; private set; }

        [DataMember]
        public string SoftwareName { get; private set; }

        [DataMember]
        public string SoftwareVersion { get; private set; }

        [DataMember]
        public AdministrativeRating AdministrativeVersion { get; private set; }

        [DataMember]
        public int ClientRating { get; private set; }

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

            Client casted = obj as Client;
            if (casted == null)
            {
                return false;
            }

            return base.Equals(obj)
                && string.Equals(casted.Callsign, Callsign, StringComparison.InvariantCultureIgnoreCase)
                && string.Equals(casted.VID, VID, StringComparison.InvariantCultureIgnoreCase)
                && string.Equals(casted.Name, Name, StringComparison.InvariantCultureIgnoreCase)
                && Equals(casted.ClientType, ClientType)
                && Equals(casted.Location, Location)
                && string.Equals(casted.Server, Server, StringComparison.InvariantCultureIgnoreCase)
                && string.Equals(casted.Protocol, Protocol, StringComparison.InvariantCultureIgnoreCase)
                && Equals(casted.ConnectionTime, ConnectionTime)
                && string.Equals(casted.SoftwareName, SoftwareName, StringComparison.InvariantCultureIgnoreCase)
                && string.Equals(casted.SoftwareVersion, SoftwareVersion, StringComparison.InvariantCultureIgnoreCase)
                && Equals(casted.AdministrativeVersion, AdministrativeVersion)
                && Equals(casted.ClientRating, ClientRating);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return base.GetHashCode()
                    + (Callsign.ToUpper().GetHashCode() * 3)
                    + (VID.ToUpper().GetHashCode() * 3)
                    + (Name.ToUpper().GetHashCode() * 3)
                    + (ClientType.GetHashCode() * 3)
                    + (Location.GetHashCode() * 3)
                    + (Server.ToUpper().GetHashCode() * 3)
                    + (Protocol.ToUpper().GetHashCode() * 3)
                    + (ConnectionTime.GetHashCode() * 3)
                    + (SoftwareName.ToUpper().GetHashCode() * 3)
                    + (SoftwareVersion.ToUpper().GetHashCode() * 3)
                    + (AdministrativeVersion.GetHashCode() * 3)
                    + (ClientRating.GetHashCode() * 3) * 17;
            }
        }
    }
}