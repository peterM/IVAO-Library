// MIT License
//
// Copyright (c) 2019 Peter Malik. (MalikP.)
// 
// File: FlightPlanExtractor.cs 
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

using MalikP.IVAO.Library.Common.Annotation;
using MalikP.IVAO.Library.Common.Enums.Custom;
using MalikP.IVAO.Library.Common.Indexes;
using MalikP.IVAO.Library.Models.Other;

namespace MalikP.IVAO.Library.Common.Parsers.DataExtractors.Client.Pilot
{
    public sealed class FlightPlanExtractor : IFlightPlanExtractor
    {
        private readonly IIVAOStringService _ivaoStringService;

        public FlightPlanExtractor()
        {
            _ivaoStringService = new IVAOStringService();
        }

        public FlightPlan ExtractValue(string[] data)
        {
            return FlightPlanBuilder.Create()
                 .WithAircraft(data[ClientIndex.Pilot.FPL.Aircraft])
                 .WithCruisingSpeed(data[ClientIndex.Pilot.FPL.CruisingSpeed])
                 .WithDepartureAerodrome(new Aerodrome(data[ClientIndex.Pilot.FPL.DepartureAerodrome]))
                 .WithCruisingLevel(data[ClientIndex.Pilot.FPL.CruisingLevel])
                 .WithDestinationAerodrome(new Aerodrome(data[ClientIndex.Pilot.FPL.DestinationAerodrome]))
                 .WithRevision(_ivaoStringService.IVAO_GetInt(data[ClientIndex.Pilot.FPL.Revision]))
                 .WithFlightRules(AnnotationExtensions.GetFromMap<FlightRules>(data[ClientIndex.Pilot.FPL.FlightRules]))
                 .WithDepartureTime(_ivaoStringService.IVAO_GetInt(data[ClientIndex.Pilot.FPL.DepartureTime]))
                 .WithActualDepartureTime(_ivaoStringService.IVAO_GetInt(data[ClientIndex.Pilot.FPL.ActualDepartureTime]))
                 .WithEETHours(_ivaoStringService.IVAO_GetInt(data[ClientIndex.Pilot.FPL.EET_Hours]))
                 .WithEETMinutes(_ivaoStringService.IVAO_GetInt(data[ClientIndex.Pilot.FPL.EET_Minutes]))
                 .WithEnduranceHours(_ivaoStringService.IVAO_GetInt(data[ClientIndex.Pilot.FPL.Endurance_Hours]))
                 .WithEnduranceMinutes(_ivaoStringService.IVAO_GetInt(data[ClientIndex.Pilot.FPL.Endurance_Minutes]))
                 .WithAlternateAerodrome(new Aerodrome(data[ClientIndex.Pilot.FPL.AlternateAerodrome]))
                 .WithOtherInfo(data[ClientIndex.Pilot.FPL.OtherInfo])
                 .WithRoute(data[ClientIndex.Pilot.FPL.Route])
                 .WithSecondAlternateAerodrome(new Aerodrome(data[ClientIndex.Pilot.FPL.SecondAlternateAerodrome]))
                 .WithTypeOfFlight(AnnotationExtensions.GetFromMap<FlightType>(data[ClientIndex.Pilot.FPL.TypeOfFlight]))
                 .WithPersonsOnBoard(_ivaoStringService.IVAO_GetInt(data[ClientIndex.Pilot.FPL.PersonsOnBoard]))
                 .Build();
        }
    }
}
