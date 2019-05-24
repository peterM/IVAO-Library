using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using MalikP.IvaoLibrary.Common.Parsers;
using MalikP.IvaoLibrary.Common.Selector;
using MalikP.IvaoLibrary.Models.Airports;
using MalikP.IvaoLibrary.Models.Clients;
using MalikP.IvaoLibrary.Models.DataHolders;
using MalikP.IvaoLibrary.Models.General;
using MalikP.IvaoLibrary.Models.Servers;
using MalikP.IvaoLibrary.Providers;

namespace MalikP.IvaoLibrary.App
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string path = @"C:\Sources\Tfs\IvaoLibrary\src\MalikP. IvaoLibrary\MalikP.IvaoLibrary.App\testData.txt";
            string[] data = await File.ReadAllLinesAsync(path);
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

            List<GeneralData> generalDataModels = generalDataProvider.GetData(whazzupData).ToList();
            List<Client> clientDataModels = clientsDataProvider.GetData(whazzupData).ToList();
            List<Server> serversDataModels = serversDataProvider.GetData(whazzupData).ToList();
            List<Airport> airportsDataModels = airportsDataProvider.GetData(whazzupData).ToList();
        }
    }
}
