using MalikP.IVAO.Library.Common;
using MalikP.IVAO.Library.Common.Enhancers;
using MalikP.IVAO.Library.Common.Parsers;
using MalikP.IVAO.Library.Common.Selector;
using MalikP.IVAO.Library.Data.Source;
using MalikP.IVAO.Library.Models.Airports;
using MalikP.IVAO.Library.Models.Clients;
using MalikP.IVAO.Library.Models.General;
using MalikP.IVAO.Library.Models.Other;
using MalikP.IVAO.Library.Models.Servers;
using MalikP.IVAO.Library.Providers;

namespace MalikP.IoC
{
    public static class IvaoIocExtensions
    {
        public static IIoC RegisterIvaoDefaultWhazzupServices(this IIoC ioc)
        {
            ioc.Register<IParserFactory, ParserFactory>();

            ioc.Register<IGZipCompression, GZipCompression>();

            //ioc.Register<IIVAOWhazzupDataSource, WebIVAOWhazzupDataSource>();
            //ioc.Register<IIVAOWhazzupDataSource, WebGZippedIVAOWhazzupDataSource>();
            //ioc.Register<IIVAOWhazzupDataSource, LocalIVAOWhazzupDataSource>();
            //ioc.Register<IIVAOWhazzupDataSource, LocalGZippedIVAOWhazzupDataSource>();

            ioc.Register<IGeneralSelector, GeneralSelector>();
            ioc.Register<IClientsSelector, ClientsSelector>();
            ioc.Register<IServersSelector, ServersSelector>();
            ioc.Register<IAirportsSelector, AirportsSelector>();

            ioc.Register<IGeneralDataProvider, GeneralDataProvider>();
            ioc.Register<IClientsProvider, ClientsDataProvider>();
            ioc.Register<IServersProvider, ServersDataProvider>();
            ioc.Register<IAirportsProvider, AirportsDataProvider>();

            ioc.Register<IAirTrafficControllersProvider, AirTrafficControllersDataProvider>();
            ioc.Register<IPilotsProvider, PilotsDataProvider>();
            ioc.Register<IFollowMesProvider, FollowMesDataProvider>();

            ioc.Register<IClientsProvider, AirTrafficControllersDataProvider>();
            ioc.Register<IClientsProvider, PilotsDataProvider>();
            ioc.Register<IClientsProvider, FollowMesDataProvider>();

            ioc.Register<IAirTrafficControllerServerEnhancer, AirTrafficControllerServerEnhancer>();
            ioc.Register<IPilotServerEnhancer, PilotServerEnhancer>();
            ioc.Register<IFollowMeServerEnhancer, FollowMeServerEnhancer>();

            ioc.Register<IModelCloner, ModelCloner>();

            return ioc;
        }

        /// <summary>
        /// You have to register one <see cref="IIVAOWhazzupSpecificDataSource"/> service manually. 
        /// Possibilities: <see cref="WebIVAOWhazzupDataSource"/>, <see cref="WebGZippedIVAOWhazzupDataSource"/>,
        /// <see cref="LocalIVAOWhazzupDataSource"/>, <see cref="LocalGZippedIVAOWhazzupDataSource"/>
        /// </summary>
        /// <param name="ioc"><see cref="IIoC"/> container</param>
        /// <returns><see cref="IIoC"/> container</returns>
        public static IIoC RegisterIvaoCachedDataSource(this IIoC ioc)
        {
            ioc.Register<ICachedIVAOWhazzupDataSource, CachedIVAOWhazzupDataSource>()
                .Extend()
                .ToSingleton();

            ioc.Register<IIVAOWhazzupDataSource>(d => d.Resolve<ICachedIVAOWhazzupDataSource>());

            return ioc;
        }

        public static IIoC RegisterIvaoSpecificDataSource<TSpecific>(this IIoC ioc, TSpecific instance)
            where TSpecific : IIVAOWhazzupSpecificDataSource
        {
            ioc.Register<IIVAOWhazzupSpecificDataSource, TSpecific>(instance);

            return ioc;
        }

        public static IIoC RegisterIvaoModelBuilders(this IIoC ioc)
        {
            ioc.Register<AirportBuilder>(_ => AirportBuilder.Create());

            ioc.Register<AirTrafficControllerBuilder>(_ => AirTrafficControllerBuilder.Create());
            ioc.Register<FollowMeBuilder>(_ => FollowMeBuilder.Create());
            ioc.Register<PilotBuilder>(_ => PilotBuilder.Create());

            ioc.Register<GeneralDataBuilder>(_ => GeneralDataBuilder.Create());

            ioc.Register<FlightPlanBuilder>(_ => FlightPlanBuilder.Create());
            ioc.Register<GPSBuilder>(_ => GPSBuilder.Create());

            ioc.Register<ServerBuilder>(_ => ServerBuilder.Create());

            return ioc;
        }
    }
}
