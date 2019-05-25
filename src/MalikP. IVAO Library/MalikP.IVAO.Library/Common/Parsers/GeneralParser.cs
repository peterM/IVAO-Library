using System;
using System.Globalization;

using MalikP.IVAO.Library.Common.Parsers.DataExtractors.General;
using MalikP.IVAO.Library.Common.Selector;
using MalikP.IVAO.Library.Models.DataHolders;
using MalikP.IVAO.Library.Models.General;

namespace MalikP.IVAO.Library.Common.Parsers
{
    public sealed class GeneralParser : AbstractParser<GeneralData, IGeneralSelector>
    {
        private const string dateTimeFormat = "yyyyMMddHHmmss";

        public GeneralParser(IGeneralSelector selector)
            : base(selector)
        {
        }

        public override object Parse(ISelectedData selectedData)
        {
            string[] data = RemoveSelector(selectedData.Data);

            return GeneralDataBuilder.Create()
                .WithVersion(int.Parse(new VersionExtractor().ExtractValue(data)))
                .WithReload(int.Parse(new ReloadExtractor().ExtractValue(data)))
                .WithUpdate(DateTime.ParseExact(new UpdateExtractor().ExtractValue(data), dateTimeFormat, CultureInfo.InvariantCulture))
                .WithConnectedClients(int.Parse(new ConnectedClientsExtractor().ExtractValue(data)))
                .WithConnectedServers(int.Parse(new ConnectedServersExtractor().ExtractValue(data)))
                .WithConnectedAirports(int.Parse(new ConnectedAirportsExtractor().ExtractValue(data)))
                .Build();
        }
    }
}
