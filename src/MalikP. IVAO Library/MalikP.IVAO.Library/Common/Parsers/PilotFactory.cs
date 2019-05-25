// MIT License
//
// Copyright (c) 2019 Peter Malik. (MalikP.)
// 
// File: PilotFactory.cs 
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

using MalikP.IVAO.Library.Common.Enums;
using MalikP.IVAO.Library.Common.Indexes;
using MalikP.IVAO.Library.Common.Parsers.DataExtractors.Client.Pilot;
using MalikP.IVAO.Library.Models.Clients;
using MalikP.IVAO.Library.Models.Other;

namespace MalikP.IVAO.Library.Common.Parsers
{
    public sealed class PilotFactory : AbstractClientFactory<Pilot>
    {
        private readonly IFlightPlanExtractor _flightPlanExtractor;
        public PilotFactory()
            : base(ClientType.Pilot)
        {
            _flightPlanExtractor = new FlightPlanExtractor();
        }

        public override Pilot Create(string[] rowData)
        {
            FlightPlan flightPlan = CreateFlightPlan(rowData);

            return AssignGeneralData(PilotBuilder.Create(), rowData)
                .WithRating((PilotRating)StringService.IVAO_GetInt(rowData[ClientIndex.Pilot.Version]))
                .WithGroundSpeed(StringService.IVAO_GetInt(rowData[ClientIndex.Pilot.Groundspeed]))
                .WithTransponderCode(rowData[ClientIndex.Pilot.TransponderCode])
                .WithHeading(StringService.IVAO_GetInt(rowData[ClientIndex.Pilot.Heading]))
                .WithIsOnGround(Convert.ToBoolean(Convert.ToInt16(rowData[ClientIndex.Pilot.IsOnGround])))
                .WithFlightSimulator((FlightSimulator)StringService.IVAO_GetInt(rowData[ClientIndex.Pilot.Simulator]))
                .WithPlaneMTL(rowData[ClientIndex.Pilot.PlaneMTL])
                .WithFlightPlan(flightPlan)
                .Build();
        }

        private FlightPlan CreateFlightPlan(string[] rowData)
        {
            return _flightPlanExtractor.ExtractValue(rowData);
        }
    }
}
