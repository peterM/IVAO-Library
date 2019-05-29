using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using MalikP.IVAO.Library.Common;
using MalikP.IVAO.Library.Common.Parsers;
using MalikP.IVAO.Library.Common.Selector;
using MalikP.IVAO.Library.Data.Source;
using MalikP.IVAO.Library.Models.Airports;
using MalikP.IVAO.Library.Models.Clients;
using MalikP.IVAO.Library.Models.General;
using MalikP.IVAO.Library.Models.Servers;
using MalikP.IVAO.Library.Providers;

namespace MalikP.IVAO.Library.App
{
    internal static class Program
    {
        const string fileName = "testData.txt";

        public static void Main(string[] args)
        {
            string path = GetPath();

            IIVAOWhazzupDataSource nonCachedWebDataSource = new WebIVAOWhazzupDataSource("http://api.ivao.aero/getdata/whazzup/whazzup.txt");
            IIVAOWhazzupDataSource nonCachedWebGzipedDataSource = new WebGZippedIVAOWhazzupDataSource("http://api.ivao.aero/getdata/whazzup/whazzup.txt.gz", new GZipCompression());
            IIVAOWhazzupDataSource nonCachedLocalDataSource = new LocalIVAOWhazzupDataSource(path);

            ICachedIVAOWhazzupDataSource dataSource = new CachedIVAOWhazzupDataSource(nonCachedWebGzipedDataSource);

            IParserFactory parserFactory = new ParserFactory();
            IGeneralSelector generalSelector = new GeneralSelector();
            IClientsSelector clientsSelector = new ClientsSelector();
            IServersSelector serverSelector = new ServersSelector();
            IAirportsSelector airportsSelector = new AirportsSelector();

            IGeneralDataProvider generalDataProvider = new GeneralDataProvider(dataSource, parserFactory, generalSelector);
            IClientsProvider clientsDataProvider = new ClientsDataProvider(dataSource, parserFactory, clientsSelector);
            IServersProvider serversDataProvider = new ServersDataProvider(dataSource, parserFactory, serverSelector);
            IAirportsProvider airportsDataProvider = new AirportsDataProvider(dataSource, parserFactory, airportsSelector);

            IClientsProvider atcClientsDataProvider = new AirTrafficControllersDataProvider(dataSource, parserFactory, clientsSelector);
            IClientsProvider pilotClientsDataProvider = new PilotsDataProvider(dataSource, parserFactory, clientsSelector);
            IClientsProvider followMeClientsDataProvider = new FollowMesDataProvider(dataSource, parserFactory, clientsSelector);

            List<GeneralData> generalDataModels = generalDataProvider.GetData().ToList();
            List<Client> clientDataModels = clientsDataProvider.GetData().ToList();
            List<Server> serversDataModels = serversDataProvider.GetData().ToList();
            List<Airport> airportsDataModels = airportsDataProvider.GetData().ToList();

            List<Client> atcDataModels = atcClientsDataProvider.GetData().ToList();
            List<Client> pilotDataModels = pilotClientsDataProvider.GetData().ToList();
            List<Client> followMeDataModels = followMeClientsDataProvider.GetData().ToList();
        }

        private static string GetPath()
        {
            string path = Assembly.GetExecutingAssembly().Location;
            path = Path.GetDirectoryName(path);
            return Path.Combine(path, fileName);
        }
    }
}
