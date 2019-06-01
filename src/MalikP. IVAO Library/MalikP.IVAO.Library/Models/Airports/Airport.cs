// MIT License
//
// Copyright (c) 2019 Peter Malik. (MalikP.)
// 
// File: Airport.cs 
// Company: MalikP.
//
// Repository: https://github.com/peterM/IVAO-Library
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

namespace MalikP.IVAO.Library.Models.Airports
{
    [DataContract]
    public sealed class Airport : AbstractIvaoModel
    {
        public Airport(
            string icao,
            string atis)
        {
            ICAO = icao ?? string.Empty;
            ATIS = atis ?? string.Empty;
        }

        [DataMember]
        public string ICAO { get; private set; }

        [DataMember]
        public string ATIS { get; private set; }

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

            Airport casted = obj as Airport;
            if (casted == null)
            {
                return false;
            }

            return base.Equals(obj)
                && string.Equals(casted.ICAO, ICAO, StringComparison.InvariantCultureIgnoreCase)
                && string.Equals(casted.ATIS, ATIS, StringComparison.InvariantCultureIgnoreCase);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return base.GetHashCode()
                    + (ICAO.ToUpper().GetHashCode() * 3
                    + ATIS.ToUpper().GetHashCode() * 3) * 17;
            }
        }

        public override object Clone()
        {
            return AirportBuilder.FromModel(this)
                .Build();
        }

        public static AirportBuilder Builder => AirportBuilder.Create();

        public static bool operator !=(Airport instance1, Airport instance2)
        {
            return !Equals(instance1, instance2);
        }

        public static bool operator ==(Airport instance1, Airport instance2)
        {
            return Equals(instance1, instance2);
        }
    }
}
