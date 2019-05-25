using System.Collections.Generic;
using System.IO;
using System.Linq;

using MalikP.IVAO.Library.Common.Parsers;
using MalikP.IVAO.Library.Common.Selector;
using MalikP.IVAO.Library.Data.Source;
using MalikP.IVAO.Library.Models.Airports;
using MalikP.IVAO.Library.Models.Clients;
using MalikP.IVAO.Library.Models.DataHolders;
using MalikP.IVAO.Library.Models.General;
using MalikP.IVAO.Library.Models.Servers;
using MalikP.IVAO.Library.Providers;

namespace MalikP.IVAO.Library.App
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            string path = @"C:\Sources\Tfs\IvaoLibrary\src\MalikP. IvaoLibrary\MalikP.IVAO.Library.App\testData.txt";

            ILocalIVAOWhazzupDataSource localDataSource = new LocalIVAOWhazzupDataSource(path);
            ILocalCachedIVAOWhazzupDataSource dataSource = new LocalCachedIVAOWhazzupDataSource(localDataSource);

            string[] data = File.ReadAllLines(path);
            IWhazzup whazzupData = new Whazzup(data);

            IParserFactory parserFactory = new ParserFactory();
            IGeneralSelector generalSelector = new GeneralSelector();
            IClientsSelector clientsSelector = new ClientsSelector();
            IServersSelector serverSelector = new ServersSelector();
            IAirportsSelector airportsSelector = new AirportsSelector();

            IGeneralDataProvider generalDataProvider = new GeneralDataProvider(parserFactory, generalSelector);
            IClientsProvider clientsDataProvider = new ClientsDataProvider(parserFactory, clientsSelector);
            IServersProvider serversDataProvider = new ServersDataProvider(parserFactory, serverSelector);
            IAirportsProvider airportsDataProvider = new AirportsDataProvider(parserFactory, airportsSelector);

            IClientsProvider atcClientsDataProvider = new AirTrafficControllersDataProvider(parserFactory, clientsSelector);
            IClientsProvider pilotClientsDataProvider = new PilotsDataProvider(parserFactory, clientsSelector);
            IClientsProvider followMeClientsDataProvider = new FollowMesDataProvider(parserFactory, clientsSelector);

            List<GeneralData> generalDataModels = generalDataProvider.GetData(whazzupData).ToList();
            List<Client> clientDataModels = clientsDataProvider.GetData(whazzupData).ToList();
            List<Server> serversDataModels = serversDataProvider.GetData(whazzupData).ToList();
            List<Airport> airportsDataModels = airportsDataProvider.GetData(whazzupData).ToList();

            List<Client> atcDataModels = atcClientsDataProvider.GetData(whazzupData).ToList();
            List<Client> pilotDataModels = pilotClientsDataProvider.GetData(whazzupData).ToList();
            List<Client> followMeDataModels = followMeClientsDataProvider.GetData(whazzupData).ToList();
        }
    }
}
