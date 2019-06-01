using MalikP.IVAO.Library.Common.Selector;
using MalikP.IVAO.Library.Data.Source;
using MalikP.IVAO.Library.Providers;
using MalikP.IVAO.Library.Test.Common;
using MalikP.IVAO.Library.Tests.Abstracts;

using NUnit.Framework;

namespace MalikP.IVAO.Library.Tests.Providers
{
    [Category(Categories.ClientsDataProvider)]
    public abstract class AbstractClientsDataProviderTest : AbstractProviderTest
    {
        protected IClientsProvider _testee;

        [OneTimeSetUp]
        protected virtual void Setup()
        {
            IClientsSelector generalSelector = new ClientsSelector();

            _testee = new ClientsDataProvider(_datasource, _parserFactory, generalSelector);
        }

        protected override IIVAOWhazzupDataSource GetDataSource(string path)
        {
            return new LocalIVAOWhazzupDataSource(path);
        }
    }
}