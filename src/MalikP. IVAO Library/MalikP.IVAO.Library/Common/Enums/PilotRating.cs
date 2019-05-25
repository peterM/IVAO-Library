// MIT License
//
// Copyright (c) 2019 Peter Malik. (MalikP.)
// 
// File: PilotRating.cs 
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
    public enum PilotRating
    {
        //[ItemShortcutDescription("None")]
        None = 0,

        //[ItemShortcutDescription("OBS")]
        Observer = 1,

        //[ItemShortcutDescription("FS1")]
        BasicFlightStudent = 2,

        //[ItemShortcutDescription("FS2")]
        FlightStudent = 3,

        //[ItemShortcutDescription("FS3")]
        AdvancedFlightStudent = 4,

        //[ItemShortcutDescription("PP")]
        PrivatePilot = 5,

        //[ItemShortcutDescription("SPP")]
        SeniorPrivatePilot = 6,

        //[ItemShortcutDescription("CP")]
        CommercialPilot = 7,

        //[ItemShortcutDescription("ATP")]
        AirlineTransportPilot = 8,

        //[ItemShortcutDescription("SFI")]
        SeniorFlightInstructor = 9,

        //[ItemShortcutDescription("CFI")]
        ChiefFlightInstructor = 10,
    }
}
