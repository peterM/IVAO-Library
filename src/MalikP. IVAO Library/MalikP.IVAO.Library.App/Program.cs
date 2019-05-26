using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;

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
            IIVAOWhazzupDataSource nonCachedLocalDataSource = new LocalIVAOWhazzupDataSource(path);

            ICachedIVAOWhazzupDataSource dataSource = new CachedIVAOWhazzupDataSource(nonCachedLocalDataSource);

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

            Client item = pilotDataModels.First();

            TrySerialize(item);
        }

        private static void TrySerialize(Client item)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                DataContractSerializer ser = new DataContractSerializer(typeof(Pilot));
                ser.WriteObject(ms, item);

                byte[] d = ms.ToArray();
                string s = Encoding.UTF8.GetString(d);

                ms.Position = 0;

                XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(ms, new XmlDictionaryReaderQuotas());
                object deserializedPerson = ser.ReadObject(reader, true);
            }
        }

        private static string GetPath()
        {
            string path = Assembly.GetExecutingAssembly().Location;
            path = Path.GetDirectoryName(path);
            return Path.Combine(path, fileName);
        }
    }
}
