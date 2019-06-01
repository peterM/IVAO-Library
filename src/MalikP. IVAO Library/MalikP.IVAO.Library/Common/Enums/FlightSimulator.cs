// MIT License
//
// Copyright (c) 2019 Peter Malik. (MalikP.)
// 
// File: FlightSimulator.cs 
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

namespace MalikP.IVAO.Library.Common.Enums
{
    [DataContract(Name = nameof(FlightSimulator))]
    public enum FlightSimulator
    {
        [EnumMember]
        Unknown = 0,

        [EnumMember]
        MicrosoftFlightSimulator95 = 1,

        [EnumMember]
        MicrosoftFlightSimulator98 = 2,

        [EnumMember]
        MicrosoftCombatFlightSimulator = 3,

        [EnumMember]
        MicrosoftFlightSimulator2000 = 4,

        [EnumMember]
        MicrosoftCombatFlightSimulator2 = 5,

        [EnumMember]
        MicrosoftFlightSimulator2002 = 6,

        [EnumMember]
        MicrosoftCombatFlightSimulator3 = 7,

        [EnumMember]
        MicrosoftFlightSimulator2004 = 8,

        [EnumMember]
        MicrosoftFlightSimulatorX = 9,

        [EnumMember]
        XPlaneUnknownVersion = 11,

        [EnumMember]
        XPlaneSeries8 = 12,

        [EnumMember]
        XPlaneSeries9 = 13,

        [EnumMember]
        XPlaneSeries10 = 14,

        [EnumMember]
        PS1 = 15,

        [EnumMember]
        XPlaneSeries11 = 16,

        [EnumMember]
        XPlaneSeries12 = 17,

        [EnumMember]
        Fly = 20,

        [EnumMember]
        Fly2 = 21,

        [EnumMember]
        FlightGear = 25,

        [EnumMember]
        Prepar3DSeries1 = 30
    }
}
