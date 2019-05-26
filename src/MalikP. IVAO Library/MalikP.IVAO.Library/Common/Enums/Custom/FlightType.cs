// MIT License
//
// Copyright (c) 2019 Peter Malik. (MalikP.)
// 
// File: FlightType.cs 
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

using System.Runtime.Serialization;

using MalikP.IVAO.Library.Common.Annotation;

namespace MalikP.IVAO.Library.Common.Enums.Custom
{
    /// <summary>
    /// Enumeration to define flight types
    /// </summary>
    /// <remarks>
    /// Enumeration represents after converting
    /// <code>
    /// <summary>
    /// NotDefinedOrNull -> if not set or if flight plan is null
    /// ScheduledServices = S
    /// NonScheduledServices = N
    /// GeneralAviation = G
    /// Military = M
    /// Other = X
    /// </code>
    /// </remarks>
    [DataContract(Name = nameof(FlightType))]
    public enum FlightType
    {
        /// <summary>
        /// If not set flight type
        /// </summary>
        [Map("NOTDEFINED")]
        [ItemDescription("Was not defined or fpl is null")]
        [EnumMember]
        NotDefinedOrNull,

        /// <summary>
        /// Scheduled flight type
        /// </summary>
        [Map("S")]
        [ItemDescription("Scheduled flight type")]
        [EnumMember]
        ScheduledServices,

        /// <summary>
        /// Non-Scheduled flight type
        /// </summary>
        [Map("N")]
        [ItemDescription("Non-Scheduled flight")]
        [EnumMember]
        NonScheduledServices,

        /// <summary>
        /// General aviation flight type
        /// </summary>
        [Map("G")]
        [ItemDescription("General aviation flight")]
        [EnumMember]
        GeneralAviation,

        /// <summary>
        /// Military flight type
        /// </summary>
        [Map("M")]
        [ItemDescription("Military flight")]
        [EnumMember]
        Military,

        /// <summary>
        /// Other type as flight
        /// </summary>
        [Map("X")]
        [ItemDescription("Other type of flight")]
        [EnumMember]
        Other,
    }
}
