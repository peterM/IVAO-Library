// MIT License
//
// Copyright (c) 2019 Peter Malik. (MalikP.)
// 
// File: Aerodrome.cs 
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

namespace MalikP.IVAO.Library.Models.Other
{
    [DataContract]
    public class Aerodrome : IModel, ICloneable
    {
        public Aerodrome(string icao)
        {
            ICAO = icao ?? string.Empty;
        }

        private Aerodrome()
        {
        }

        [DataMember]
        public string ICAO { get; private set; }

        public bool IsValid => !string.IsNullOrEmpty(ICAO) && ICAO.Length == 4;

        public object Clone()
        {
            return new Aerodrome(ICAO);
        }

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

            Aerodrome casted = obj as Aerodrome;
            if (casted == null)
            {
                return false;
            }

            return string.Equals(casted.ICAO, ICAO, StringComparison.InvariantCultureIgnoreCase);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ICAO.ToUpper().GetHashCode() * 3 * 17;
            }
        }

        public static bool operator !=(Aerodrome instance1, Aerodrome instance2)
        {
            return !Equals(instance1, instance2);
        }

        public static bool operator ==(Aerodrome instance1, Aerodrome instance2)
        {
            return Equals(instance1, instance2);
        }
    }
}
