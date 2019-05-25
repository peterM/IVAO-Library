using System;

using MalikP.IVAO.Library.Common.Indexes;
using MalikP.IVAO.Library.Common.Selector;
using MalikP.IVAO.Library.Models.Servers;

namespace MalikP.IVAO.Library.Common.Parsers
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
                .WithHostname(dataItems[ServerIndex.Hostname])
                .WithIP(dataItems[ServerIndex.IP])
                .WithLocation(dataItems[ServerIndex.Location])
                .WithName(dataItems[ServerIndex.Name])
                .WithConnectionsAllowed(Convert.ToBoolean(Convert.ToInt16(dataItems[ServerIndex.ConnectionsAllowed])))
                .WithMaximumConnections(int.Parse(dataItems[ServerIndex.MaximumConnections]))
                .Build();
        }
    }
}
