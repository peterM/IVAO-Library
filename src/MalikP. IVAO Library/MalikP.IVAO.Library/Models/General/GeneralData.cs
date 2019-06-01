// MIT License
//
// Copyright (c) 2019 Peter Malik. (MalikP.)
// 
// File: GeneralData.cs 
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

namespace MalikP.IVAO.Library.Models.General
{
    [DataContract]
    public sealed class GeneralData : AbstractIvaoModel
    {
        public GeneralData(
            int version,
            int reload,
            DateTime update,
            int connectedClients,
            int connectedServers,
            int connectedAirports)
        {
            Version = version;
            Reload = reload;
            Update = update;
            ConnectedClients = connectedClients;
            ConnectedServers = connectedServers;
            ConnectedAirports = connectedAirports;
        }

        private GeneralData()
        {
        }

        [DataMember]
        public int Version { get; private set; }

        [DataMember]
        public int Reload { get; private set; }

        [DataMember]
        public DateTime Update { get; private set; }

        [DataMember]
        public int ConnectedClients { get; private set; }

        [DataMember]
        public int ConnectedServers { get; private set; }

        [DataMember]
        public int ConnectedAirports { get; private set; }

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

            GeneralData casted = obj as GeneralData;
            if (casted == null)
            {
                return false;
            }

            return base.Equals(obj)
                && Equals(casted.Version, Version)
                && Equals(casted.Reload, Reload)
                && Equals(casted.Update, Update)
                && Equals(casted.ConnectedClients, ConnectedClients)
                && Equals(casted.ConnectedServers, ConnectedServers)
                && Equals(casted.ConnectedAirports, ConnectedAirports);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return base.GetHashCode()
                    + (Version.GetHashCode() * 3)
                    + (Reload.GetHashCode() * 3)
                    + (Update.GetHashCode() * 3)
                    + (ConnectedClients.GetHashCode() * 3)
                    + (ConnectedServers.GetHashCode() * 3)
                    + ConnectedAirports.GetHashCode() * 3 * 17;
            }
        }
    }
}