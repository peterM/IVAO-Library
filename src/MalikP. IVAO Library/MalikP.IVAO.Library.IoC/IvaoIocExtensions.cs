using MalikP.IVAO.Library.Common;
using MalikP.IVAO.Library.Common.Enhancers;
using MalikP.IVAO.Library.Common.Parsers;
using MalikP.IVAO.Library.Common.Selector;
using MalikP.IVAO.Library.Data.Source;
using MalikP.IVAO.Library.Providers;

namespace MalikP.IoC
{
    public static class IvaoIocExtensions
    {
        public static IIoC RegisterDefaultIvaoWhazzupServices(this IIoC ioc)
        {
            ioc.Register<IParserFactory, ParserFactory>();

            ioc.Register<IGZipCompression, GZipCompression>();

            //ioc.Register<IIVAOWhazzupDataSource, WebIVAOWhazzupDataSource>();
            //ioc.Register<IIVAOWhazzupDataSource, WebGZippedIVAOWhazzupDataSource>();
            //ioc.Register<IIVAOWhazzupDataSource, LocalIVAOWhazzupDataSource>();
            //ioc.Register<IIVAOWhazzupDataSource, LocalGZippedIVAOWhazzupDataSource>();

            ioc.Register<ICachedIVAOWhazzupDataSource, CachedIVAOWhazzupDataSource>();

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
    }
}
