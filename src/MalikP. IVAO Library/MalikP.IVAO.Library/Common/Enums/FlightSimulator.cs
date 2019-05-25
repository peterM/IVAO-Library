// MIT License
//
// Copyright (c) 2019 Peter Malik. (MalikP.)
// 
// File: FlightSimulator.cs 
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

namespace MalikP.IVAO.Library.Common.Enums
{
    public enum FlightSimulator
    {
        Unknown = 0,
        MicrosoftFlightSimulator95 = 1,
        MicrosoftFlightSimulator98 = 2,
        MicrosoftCombatFlightSimulator = 3,
        MicrosoftFlightSimulator2000 = 4,
        MicrosoftCombatFlightSimulator2 = 5,
        MicrosoftFlightSimulator2002 = 6,
        MicrosoftCombatFlightSimulator3 = 7,
        MicrosoftFlightSimulator2004 = 8,
        MicrosoftFlightSimulatorX = 9,
        XPlaneUnknownVersion = 11,
        XPlaneSeries8 = 12,
        XPlaneSeries9 = 13,
        XPlaneSeries10 = 14,
        PS1 = 15,
        XPlaneSeries11 = 16,
        XPlaneSeries12 = 17,
        Fly = 20,
        Fly2 = 21,
        FlightGear = 25,
        Prepar3DSeries1 = 30
    }
}
