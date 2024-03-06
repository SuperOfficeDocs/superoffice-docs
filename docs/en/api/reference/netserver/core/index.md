---
uid: netserver_core_api
---

# NetServer Core API

The NetServer Core API is the lowest level of the NetServer API layers. It is the most efficient and the fastest way to access the SuperOffice database. The [NetServer Core package][22] contains a number of .NET assemblies that provides a direct interface to the SuperOffice database.

The NetServer Core API is used by clients or an application server in an onsite domain environment. It does the heavy lifting and is responsible for serializing all model-based instructions into SQL.

[!INCLUDE [dependency-injection](../includes/dependency-injection.md)]

[!code-csharp[CS](../includes/netserver-core-startup.cs)]

You are also required to specify your own implementation of ISoContextInitializer, and is used to defined the database connection parameters to NetServer.

```csharp
using SuperOffice.Configuration;
using SuperOffice.Security.Principal;

public class  ExampleContextInitializer : IContextInitializer
{
    public void InitializeContext(string contextIdentifier)
    {
        /*
        * Different options for setting the context depend on the target database
        * See the following link for more information:
        * https://docs.superoffice.com/en/api/netserver/config/data.html
        */
        
        var db = new DatabaseInstance();
        db.DatabaseMajor = "MSSQL";
        db.DatabaseMinor = "15";
        db.MachineName = "SERVER_NAME";
        db.DatabaseName = "DATABASE_NAME";
        db.TablePrefix = "crm7";
        db.DatabaseUsername = "DATABASE_USER";
        db.DatabasePassword = "DATABASE_USER_PASSWORD";
        db.ConnectionString = $"Data Source={db.MachineName};Initial Catalog={db.DatabaseName};User ID={db.DatabaseUsername};Password={db.DatabasePassword};Application Name=NETSERVER_TEST";

        Apply(db);
    }

    private static void Apply(DatabaseInstance databaseInstance)
    {

        // Database: Utility class used to access the SuperOffice.Data.Database entry in the config-file.
        ConfigFile.Data.Database.DatabaseMajor           = databaseInstance.DatabaseMajor;
        ConfigFile.Data.Database.DatabaseMinor           = databaseInstance.DatabaseMinor;
        ConfigFile.Data.Database.Server                  = databaseInstance.MachineName;
        ConfigFile.Data.Database.DatabaseName            = databaseInstance.DatabaseName;
        ConfigFile.Data.Database.TablePrefix             = databaseInstance.TablePrefix;
        ConfigFile.Data.Database.ConnectionString        = databaseInstance.ConnectionString;
        ConfigFile.Data.Database.CommandTimeout          = 300;
        ConfigFile.Data.Database.ImpersonateDatabaseUser = false;

        // Explicit: Utility class used to access the SuperOffice.Data.AssociateAuthenticated entry in the Config file. This is general user authentication Issues.
        ConfigFile.Data.Explicit.DBUser                  = databaseInstance.DatabaseUsername;
        ConfigFile.Data.Explicit.DBPassword              = databaseInstance.DatabasePassword;
        ConfigFile.Data.Explicit.SystemAllowed           = true;
        ConfigFile.Data.Explicit.AnonymousAllowed        = true;
    }
}
```

### Bootstrap the application

The `Startup` class is then used to bootstrap the application. The `Startup` class is a convention used in ASP.NET Core applications. However, this explanation will not make any assumptions about the type of application you are building and will instead explicitly add an IStartup interface for demonstration purposes.

```csharp

public class Program
{
    public static void Main(string[] args)
    {
        var startup = new Startup();

        var config = new Dictionary<string, string>
        {
            {"Logging:LogLevel:Default", nameof(Microsoft.Extensions.Logging.LogLevel.Warning)},
            {"Logging:LogLevel:SuperOffice", nameof(Microsoft.Extensions.Logging.LogLevel.Warning)},
            {"Logging:LogLevel:Test", nameof(Microsoft.Extensions.Logging.LogLevel.Information)}
        };

        startup.Configuration = new ConfigurationBuilder().AddInMemoryCollection(config);
        
        var services = new ServiceCollection();
        services.AddSingleton<IContextInitializer, ExampleContextInitializer>();
        startup.Configure(services);
        var serviceProvider = services.BuildServiceProvider(true);
        startup.ConfigureServices(serviceProvider);

        Console.WriteLine("SuperOffice NetServer Core Example");

        using (SoSession.Authenticate("username", "password"))
        {
            var c = ContactRow.GetFromIdxContactId(2);
            Console.WriteLine("Loaded {0} from db - db access is ok!", c.Name);
        }
    }
}
```

## Using the NetServer Core API

### Search

[Archive providers][4] are similar to database views and simplify **searching and retrieving** collections of related data efficiently. They let you execute complex queries while masking the join logic and handling the security.

Each provider describes a set of related **columns** from the database and supports a set of methods for finding out what columns are available.

[Read more about archive providers.][4]

### Relational database layer (entities)

The relational database (RDB) layer, conceptually the **business logic** layer, is encapsulated within the [**SuperOffice.CRM.Entities namespace**][20]. Relational database objects, such as `Contact`, `ContactCollection`, `Person`, and `PersonCollection`, are all found here. These objects abstract away all of the complexities required to aggregate related data from the multiple tables in the database.

RDB objects expose the data as neat and logical classes commonly referred to as [entities][3]. Entities **represent real-world objects**, such as companies and contacts.

> [!TIP]
> This layer is great for **creating and saving** new entities, such as creating a new `Contact` or `Sale`, but may not be as performant as more lower layers when retrieving many entities at one time.

[Read more about Entities.][3]

### High-level database layer (rows)

The high-level database (HDB) classes, found under the [**SuperOffice.CRM.Rows namespace**][21], is a table-object view of the database. This layer exposes **database tables** and the information they contain as row objects, such as `ContactRow` and `ContactRows`.

Unlike RDB object properties, which are full-blown entities themselves, HDB object properties contain **ID values** that represent ID field values in a corresponding table.

> [!NOTE]
> The Row objects **do not contain any business logic**, so here you need to maintain the relationship between rows yourself.

[Read more about Row and Rows.][2]

### Objectified SQL (OSQL)

At the lowest levels of the framework are the Objectified-SQL (OSQL) classes.

[OSQL][1] encompasses all **common SQL elements**, such as SELECT, JOIN, WHERE, AND, OR, and more. It exposes all of these elements as **classes**, to be used in an "object-orientated" manner.

OSQL has the **best performance** of all NetServer API layers. When using OSQL, the code will be more responsive and efficient than when using the Services, RDB, or the HDB layers.

[Read more about OSQL.][1]

<!-- Referenced links -->
[1]: ../../../osql/index.md
[2]: ../../../rows/index.md
[3]: ../../../entities/index.md
[4]: ../../../archive-providers/index.md
[5]: ../../../web-services/index.md
[9]: ../../../../automation/webhook/index.md
[12]: ../../../config/index.md
[13]: ../../../authentication/overview.md
[14]: ../../../plugins/document/soarc-document-plugin.md
[15]: ../../../web-services/endpoints/index.md
[16]: ../../../web-services/proxies/index.md
[17]: ../../../mdo-providers/reference/index.md
[18]: ../../../plugins/sentry/index.md
[20]: <xref:SuperOffice.CRM.Entities>
[21]: <xref:SuperOffice.CRM.Rows>
[22]: https://www.nuget.org/packages/superoffice.netserver.core
[23]: https://www.nuget.org/packages/superoffice.netserver.services
[24]: https://www.nuget.org/packages/superoffice.webapi
[25]: https://www.npmjs.com/package/@superoffice/webapi
