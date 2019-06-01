﻿// MIT License
//
// Copyright (c) 2019 Peter Malik. (MalikP.)
// 
// File: FacilityType.cs 
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

using System.Runtime.Serialization;

using MalikP.IVAO.Library.Common.Annotation;

namespace MalikP.IVAO.Library.Common.Enums
{
    [DataContract(Name = nameof(FacilityType))]
    public enum FacilityType
    {
        [Map("OBS")]
        [EnumMember]
        Observer = 0,

        [Map("FI")]
        [EnumMember]
        FlightInformation = 1,

        [Map("DEL")]
        [EnumMember]
        Delivery = 2,

        [Map("GND")]
        [EnumMember]
        Ground = 3,

        [Map("TWR")]
        [EnumMember]
        Tower = 4,

        [Map("APP")]
        [EnumMember]
        Approach = 5,

        [Map("ACC")]
        [EnumMember]
        AreaControl = 6,

        [Map("DEP")]
        [EnumMember]
        Departure = 7
    }
}
