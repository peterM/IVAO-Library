// MIT License
//
// Copyright (c) 2019 Peter Malik. (MalikP.)
// 
// File: GPS.cs 
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

using MalikP.IVAO.Library.Common.Annotation;

namespace MalikP.IVAO.Library.Models.Other
{
    [DataContract]
    public class GPS : IModel
    {
        public GPS(
            decimal latitude,
            decimal longitude,
            int altitude)
        {
            Latitude = latitude;
            Longitude = longitude;
            Altitude = altitude;
        }

        private GPS()
        {
        }

        [Unit("degree")]
        [DataMember]
        public decimal Latitude { get; private set; }

        [Unit("degree")]
        [DataMember]
        public decimal Longitude { get; private set; }

        [Unit("Feet")]
        [DataMember]
        public int Altitude { get; private set; }

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

            GPS casted = obj as GPS;
            if (casted == null)
            {
                return false;
            }

            return Equals(casted.Latitude, Latitude)
                && Equals(casted.Longitude, Longitude)
                && Equals(casted.Altitude, Altitude);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Latitude.GetHashCode() * 3)
                    + (Longitude.GetHashCode() * 3)
                    + (Altitude.GetHashCode() * 3) * 17;
            }
        }

        public static GPSBuilder Builder => GPSBuilder.Create();
    }
}
