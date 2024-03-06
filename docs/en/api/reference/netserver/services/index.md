---
uid: netserver_services_api
---

# NetServer Services API

The [SuperOffice.NetServer.Service][23] proxy client is provided to give access to the following types of [web service endpoints][15]

Using this NetServer Services API, you must use an application configuration file. Read more about configuration requirements and options in the [NetServer configuration documentation][12].

* **SOAP**: WCF-based IIS application

SuperOffice publishes [web service proxies][16] that can be used by clients to access the service endpoints.

An important aspect of NetServer web service development is its **deployment flexibility**. It's capable of being embedded in a domain-centric client, or used by a web application across the internet.

[!INCLUDE [dependency-injection](../includes/dependency-injection.md)]

[!code-csharp[CS](../includes/netserver-services-startup.cs)]

## Session Mode

SuperOffice requires a context provider to be specified when configuring the NetServer Core API. The context provider is responsible for providing the principal context for the current user. There are several default implementations of ISoContextProvider located in SoCore.

* ThreadContextProvider
* ContextContextProvider
* ProcessContextProvider

Another is HttpContextProvider, located in SuperOffice.DCFWeb, used be the SuperOffice web client.

## Bootstrap the application

The `Startup` class is then used to bootstrap the application. The `Startup` class is a convention used in ASP.NET Core applications. However, this explanation will not make any assumptions about the type of application you are building and will instead explicitly add an IStartup interface for demonstration purposes.

Read more about authentication options in the [SuperOffice authentication documentation][13].

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

        startup.Configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(config)
            .Build();
        
        var services = new ServiceCollection();
        services.AddSingleton<IContextInitializer, ExampleContextInitializer>();
        startup.Configure(services);
        var serviceProvider = services.BuildServiceProvider(true);
        startup.ConfigureServices(serviceProvider);

        Console.WriteLine("SuperOffice NetServer Core Example");

        // See the authentication section for more authentication options.
        // https://docs.superoffice.com/en/authentication/onsite/sosession/index.html

        using (SoSession.Authenticate("username", "password"))
        {
           using(ContactAgent contactAgent = new ContactAgent())
           {
                //Create a new contact Entity with default values set to its properties
                ContactEntity myContact = contactAgent.CreateDefaultContactEntity();

                //Assign values to properties of basic data types
                myContact.Name = "FooBar Inc.";
                myContact.Department = "Headquarters";
                myContact.NoMailing = true;

                //Create an array of EntityElement and assign it to the Phones property
                EntityElement[] myPhones = new EntityElement[2];
                myPhones[0] = new EntityElement();
                myPhones[1] = new EntityElement();
                myPhones[0].Value = "0112732006";
                myPhones[1].Value = "0713243288";
                
                myContact.Phones = myPhones;

                // Set the new contact’s  our-contact to associate 2
                using(AssociateAgent associateAgent = new AssociateAgent())
                {
                    Associate myAssociate = associateAgent.GetAssociate(2);
                    myContact.Associate = myAssociate;
                }

                //Save the Contact Entity and the new person through the ContactAgent
                // the returned entity has the contact ID filled in
                myContact = contactAgent.SaveContactEntity(myContact);

                Console.WriteLine($"New Company {myContact.Name} created with ID {myContact.ContactId}");
            }
        }
    }
}
```

## Using the NetServer Services API

[Read more about SOAP web services.][1]

<!-- Referenced links -->
[1]: ../../../web-services/endpoints/soap/index.md
[12]: ../../../config/index.md
[13]: ../../../authentication/overview.md
[15]: ../../../web-services/endpoints/index.md
[16]: ../../../web-services/proxies/index.md
[18]: ../../../plugins/sentry/index.md
[23]: https://www.nuget.org/packages/superoffice.netserver.services
