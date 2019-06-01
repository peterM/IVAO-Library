// MIT License
//
// Copyright (c) 2019 Peter Malik. (MalikP.)
// 
// File: PilotRating.cs 
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
    [DataContract(Name = nameof(PilotRating))]
    public enum PilotRating
    {
        [Map("None")]
        [EnumMember]
        None = 0,

        [Map("OBS")]
        [EnumMember]
        Observer = 1,

        [Map("FS1")]
        [EnumMember]
        BasicFlightStudent = 2,

        [Map("FS2")]
        [EnumMember]
        FlightStudent = 3,

        [Map("FS3")]
        [EnumMember]
        AdvancedFlightStudent = 4,

        [Map("PP")]
        [EnumMember]
        PrivatePilot = 5,

        [Map("SPP")]
        [EnumMember]
        SeniorPrivatePilot = 6,

        [Map("CP")]
        [EnumMember]
        CommercialPilot = 7,

        [Map("ATP")]
        [EnumMember]
        AirlineTransportPilot = 8,

        [Map("SFI")]
        [EnumMember]
        SeniorFlightInstructor = 9,

        [Map("CFI")]
        [EnumMember]
        ChiefFlightInstructor = 10,
    }
}
