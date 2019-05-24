using System;

using MalikP.IvaoLibrary.Common.Indexes;
using MalikP.IvaoLibrary.Common.Selector;
using MalikP.IvaoLibrary.Models.Servers;

namespace MalikP.IvaoLibrary.Common.Parsers
{
    public sealed class ServerParser : AbstractParser<Server, IServersSelector>
    {
        public ServerParser(IServersSelector selector)
            : base(selector)
        {
        }

        protected override Server CreateItem(string data)
        {
            string[] dataItems = Split(data);

            return ServerBuilder.Create()
                .WithHostname(dataItems[(int)ServerIndex.Hostname])
                .WithIP(dataItems[(int)ServerIndex.IP])
                .WithLocation(dataItems[(int)ServerIndex.Location])
                .WithName(dataItems[(int)ServerIndex.Name])
                .WithConnectionsAllowed(Convert.ToBoolean(Convert.ToInt16(dataItems[(int)ServerIndex.ConnectionsAllowed])))
                .WithMaximumConnections(int.Parse(dataItems[(int)ServerIndex.MaximumConnections]))
                .Build();
        }
    }
}
