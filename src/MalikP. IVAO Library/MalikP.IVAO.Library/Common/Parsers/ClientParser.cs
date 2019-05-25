// MIT License
//
// Copyright (c) 2019 Peter Malik. (MalikP.)
// 
// File: ClientParser.cs 
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

using System.Collections.Generic;

using MalikP.IVAO.Library.Common.Enums;
using MalikP.IVAO.Library.Common.Indexes;
using MalikP.IVAO.Library.Common.Selector;
using MalikP.IVAO.Library.Models.Clients;

namespace MalikP.IVAO.Library.Common.Parsers
{
    public sealed class ClientParser : AbstractParser<Client, IClientsSelector>
    {
        Dictionary<ClientType, ICLientFactory> _factories;

        public ClientParser(IClientsSelector selector)
            : base(selector)
        {
            _factories = new Dictionary<ClientType, ICLientFactory>
            {
                { ClientType.Pilot, new PilotFactory() },
                { ClientType.FollowMeCar, new FollowMeFactory() },
                { ClientType.ATC, new AirTrafficControllerFactory() },
                { ClientType.NotDefined, new NullClientFactory() }
            };
        }

        protected override Client CreateItem(string row)
        {
            string[] rowData = Split(row);

            ClientType clientType = Annotation.AnnotationExtensions.GetFromMap<ClientType>(rowData[ClientIndex.All.ClientType]);

            return _factories[clientType].Create(rowData);
        }
    }
}
