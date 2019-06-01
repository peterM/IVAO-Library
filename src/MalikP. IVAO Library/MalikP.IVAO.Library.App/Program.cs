﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;

using MalikP.IVAO.Library.Common;
using MalikP.IVAO.Library.Common.Enhancers;
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
        const string fileName = "whazzup.txt.gz";
        //const string fileName = "whazzup.txt";

        public static void Main(string[] args)
        {
            string path = GetPath();
            IGZipCompression compression = new GZipCompression();

            IIVAOWhazzupDataSource nonCachedWebDataSource = new WebIVAOWhazzupDataSource("http://api.ivao.aero/getdata/whazzup/whazzup.txt");
            IIVAOWhazzupDataSource nonCachedWebGZippedDataSource = new WebGZippedIVAOWhazzupDataSource("http://api.ivao.aero/getdata/whazzup/whazzup.txt.gz", compression);

            IIVAOWhazzupDataSource nonCachedLocalDataSource = new LocalIVAOWhazzupDataSource(path);
            IIVAOWhazzupDataSource nonCachedLocalGZippedDataSource = new LocalGZippedIVAOWhazzupDataSource(path, compression);

            ICachedIVAOWhazzupDataSource dataSource = new CachedIVAOWhazzupDataSource(nonCachedLocalGZippedDataSource);

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

            IAirTrafficControllerServerEnhancer atcServerEnhancer = new AirTrafficControllerServerEnhancer(serversDataProvider);
            IPilotServerEnhancer pilotServerEnhancer = new PilotServerEnhancer(serversDataProvider);
            IFollowMeServerEnhancer followMeServerEnhancer = new FollowMeServerEnhancer(serversDataProvider);

            atcDataModels = atcDataModels.Select(atcServerEnhancer.Enhance).Cast<Client>().ToList();
            pilotDataModels = pilotDataModels.Select(pilotServerEnhancer.Enhance).Cast<Client>().ToList();
            followMeDataModels = followMeDataModels.Select(followMeServerEnhancer.Enhance).Cast<Client>().ToList();

            Client item = pilotDataModels.First();

            IModelCloner modelCloner = new ModelCloner();
            Client m = modelCloner.Clone(pilotDataModels[0]);
        }

        private static string GetPath()
        {
            string path = Assembly.GetExecutingAssembly().Location;
            path = Path.GetDirectoryName(path);
            return Path.Combine(path, fileName);
        }
    }
}
