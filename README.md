# IVAO Library

## How to download andprocess IVAO `WHAZZUP` data

### Create datasource


#### Local based

In case you want to load data from local computer.

```csharp
string path = @"C:\Data\whazzup.txt";
IIVAOWhazzupDataSource nonCachedLocalDataSource = new LocalIVAOWhazzupDataSource(path);
```

#### Web based

In case you want to load data from web.

```csharp
string url = "http://api.ivao.aero/getdata/whazzup/whazzup.txt";
IIVAOWhazzupDataSource nonCachedWebDataSource = new WebIVAOWhazzupDataSource(url);
```

#### Cached

Once you have data source created you can use it or you can create `Cached` datasource.

```csharp
ICachedIVAOWhazzupDataSource dataSource = new CachedIVAOWhazzupDataSource(nonCachedWebDataSource);
``` 

##### To delete cache

> **_Note:_** In case you use cached provider, this provider will always return the same data until cache is deleted manually.

```csharp
datasource.DeleteCache();
```

### Create parser factory

You need to create also factory to create parsers for specific data types / sections.

```csharp
IParserFactory parserFactory = new ParserFactory();
```


### Create section selectors

You need to create also section selectors to create extract/select correct section data and pass them to correct parsers.

```csharp
IGeneralSelector generalSelector = new GeneralSelector();
IClientsSelector clientsSelector = new ClientsSelector();
IServersSelector serverSelector = new ServersSelector();
IAirportsSelector airportsSelector = new AirportsSelector();
```

### Create providers

Once you have created all supporting instances, you need to create provider depending on what kind of data you are interested in.

```csharp
// in case you want !GENERAL data
IGeneralDataProvider generalDataProvider = new GeneralDataProvider(dataSource, parserFactory, generalSelector);

// in case you want !CLIENTS data (ATC, PILOT, FOLME)
IClientsProvider clientsDataProvider = new ClientsDataProvider(dataSource, parserFactory, clientsSelector);

// in case you want !CLIENTS specific data -> ATC
IClientsProvider atcClientsDataProvider = new AirTrafficControllersDataProvider(dataSource, parserFactory, clientsSelector);

// in case you want !CLIENTS specific data -> PILOT
IClientsProvider pilotClientsDataProvider = new PilotsDataProvider(dataSource, parserFactory, clientsSelector);

// in case you want !CLIENTS specific data -> FOLME
IClientsProvider followMeClientsDataProvider = new FollowMesDataProvider(dataSource, parserFactory, clientsSelector);

// in case you want !SERVERS data
IServersProvider serversDataProvider = new ServersDataProvider(dataSource, parserFactory, serverSelector);

// in case you want !AIRPORTS data
IAirportsProvider airportsDataProvider = new AirportsDataProvider(dataSource, parserFactory, airportsSelector);
```

Once you have provider instance you just need to call it to get data.

```csharp
var data = yourProvider.GetData().ToList();
```