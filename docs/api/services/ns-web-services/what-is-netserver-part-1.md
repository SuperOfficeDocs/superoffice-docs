---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: what_is_netserver_part_1       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: What is NetServer, part 1 # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: Tony Yates             # Your GitHub alias.
so.date: 07.28.2006
keywords:
so.topic: article             # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# What is NetServer, part 1

This article, the first of a planned two-part series, will cover the basic overview of NetServer API, as well as dive into the different aspects of NetServers service offerings.

## Birds-eye view

In a nutshell, NetServer is a layered, factory-driven library that enables developers to conduct Create, Read, Update and Delete (CRUD) operations to the SuperOffice database, and more. Whether deploying a solution to a local SuperOffice database installation or operating in a distributed environment, NetServer exposes an array of application programming interface (API) approaches to facilitate a wide range of solution implementations. Although the terrain is vast and complex, and at first sight, be can somewhat intimidating, the NetServer API tailors to a wide variety of developers by layering the architecture in various intuitive abstractions. In this article, I will guide you through the various regions of NetServer, show you the attractions, as well as point out the areas to avoid.

When programming with the NetServer API, other than calling the web services directly, every solution needs a SuperOffice-specific section group in your application configuration file. This means adding a SuperOffice-specific section group to an *app.config* file for Windows Forms applications, or the *web.config* file for an ASP.NET web application. The SuperOffice section group contains configuration options relevant NetServer operations, such as logging, document handling, security, database options, and so forth. Everything you need to know about the SuperOffice configuration options is well-defined in the [Hitchhikers Guide to the NetServer Configuration File][1].

The layered aspect of NetServer invites developers to tap into the database from several facets. In the following sections, each layer is simply defined with accompanying code samples.

### Services layer

At the highest level, encapsulated in the SuperOffice.Services namespace, is an agent pattern derived API that is, in terms of deployment, quite flexible. Access and modification to data in the database, using service objects, will always be coded the same, whether the application and database are located on the same server, or operating in a distributed environment. This flexibility does come at a performance price though, as I'll discuss more in the Services section.

![x][img1]

In **Figure One**, the SuperOffice.Services layer should not be confused with the web services available in the installation directory: InstallBase\\WebServices. SuperOffice.Services, is a consumer of these web services, whereas the web services are hosted in IIS.

As pictured in **Figure Two**, the SuperOffice.Services layer is a client proxy to the NetServer web services and greatly simplifies what is required to call them.

![x][img2]

### Relational Database Layer

The Relational Database (RDB) layer, conceptually the business logic layer, is encapsulated within the SuperOffice.Entities namespace. Relational database objects, such as Contact, ContactCollection, Person, and PersonCollection, are all found here. These objects abstract away the complexities required to access and present information from the database. Relational database objects expose the data as neat and logical objects commonly referred to as entities. As seen above, entities represent real-world objects, such as companies and people. This layer is great for creating and saving new entities, such as creating a new Contact or Sale, but is not as efficient as one of the lower layers when retrieving information. I'll discuss this further in a later section.

### High-Level Database Layer

The High-Level Database (HDB) layer, found under the SuperOffice.Rows namespace, is a table-object view of the database. This layer exposes database tables and the information they contain as row objects, such as ContactRow and ContactRows. Unlike RDB object properties, which are full-blown entities themselves (for example Contact.Associate corresponds to an Associate object with populated properties), HDB object properties contain identity values that represent identity field values in a corresponding table. In this case, the ContactRow associate property, which is called AssociateId, is an integer value that correlates to a row in the associate table where the ContactRow.AssociateId value equals the associate\_id field value.

### SuperOffice Database Interface Layer

At the lowest levels of the framework is a database-independent objectified SQL library I'll refer to as OSQL (Objectified Structured Query Language). OSQL encompasses all common SQL elements, such as SELECT, JOIN, WHERE, AND, OR, and so forth. OSQL exposes all of these elements as class objects, to be constructed and leveraged in an object-orientated manner **debatable**.

## Service Layer

Global access to SuperOffice data is easy to achieve through leveraging the service-orientated aspects of NetServer. One way to communicate with NetServer web services is to use Microsoft's ServiceModel Metadata Utility Tool ([SVCUTIL.exe][2] to generate a client proxy class for a particular NetServer web service, for example Appointment.svc or Contact.svc. Another way is to create a Visual Studio Service Reference and communicate with the services through that proxy. The most complete way, however, is to reference the pre-packaged, all-in-one factory-driven proxy, SuperOffice.Services.dll.

There is flexibility in using SuperOffice proxies. Not only are all of the complexities involved with communicating with web services done for you, but also in the ability to code once and have your application work both local or remote simply by changing a single configuration setting - SuperOffice->Services->DefaultMode. Under the hood, however, there are significant differences between the different modes, Local, Remote, and Switch.

Within the services layer, most development will involve IAgent-derived types and Carrier types. Agents are used to execute actions, for example call methods, while Carrier objects, such as Person and PersonEntity are mere data containers. As your will soon come to realize, carrier entities better resemble Entity objects, where an entity property, such as the PersonEntity.Contact, is a populated object that contains all relational information pertaining to the corresponding contact - including name, address, contact ID, phone collection, and more. In contrast, carrier objects (not ending in Entity) such as Contact and Person, are more similar to Row objects. Carrier object properties represent identity values correlating to the identity field in the corresponding table. For example, the Person.ContactId property is of type integer and correlates to the contact\_id field in the Contact table.

### Service Communication Modes

When opted to operate in local mode, SuperOffice.Services.dll is not actually making web service calls. Instead, it uses Rows and OSQL to populate lite-serializable versions of intrinsic types, such as Appointment, Contact, and Person. These are the same objects returned by calling the web service, but in this case, do not require a round-trip across the internet. Smart, huh?

In remote mode, SuperOffice.Services.dll uses proxy classes that are, to some degree, similar versions of what you get when generating proxy classes with SVCUTIL.exe. These objects, however, are enhanced a magnitude greater to increase completeness and usability when submitting calls to and receiving data from NetServer web services. The URL of the remote web services is determined by the SuperOffice->Service-> RemoteBaseURL configuration setting.

Switch mode, when set, will attempt to communicate with the setting defined in Services-SwitchDefault. If unable to communicate successfully, NetServer will switch to the other setting option (Local or Remote) and attempt to communicate again.

### Data Paths

Below is a diagram that depicts the data path taken when communicating with the Services layer.

![x][img3]

The Client represents a .net application that has referenced SuperOffice.Services.dll. The lines below, depending on the Services->DefaultMode configuration setting, represent the data path to communicate with the database.

If the DefaultMode is "Local", which means that the application resides on the same server as the database, or within the same domain, then factory mechanisms in SuperOffice.Services.dll return interface implementations from SuperOffice.Services.Implementation.dll. This assembly leverages both Rows and OSQL layers to conduct transactions between the application and the database.

When DefaultMode is set to "Remote", a significantly different data path is used. When read from the configuration file by SuperOffice.Services.dll, the "Remote" indicates that the interfaces are implemented by SuperOffice.Services\[version\].Wcf.dll and related files. In this case, the data path originating from the client traverses SuperOffice.Services\[version\].Wcf.dll, across the internet to the web service endpoints, SuperOffice.Services.WcfService.dll, which then calls into a local copy of SuperOffice.Services.dll. At this point, the data path starts all over again as depicted in the Client Local mode, but local to the Remote location. Now on the remote server, SuperOffice.Services.Implementation.dll leverages both Row and OSQL layers to conduct transactions with the database. The implementation populates the lite-objects, returns them to the SuperOffice.Services.Wcf.dll, which then passes the data back to the client proxy.

### Code Example

So, what does all of this look like in code? **Figure Three** shows: creating a session for credentials, using the AgentFactory to create ContactAgent - to communicate with the Contact web service, using the ContactAgent to create and save a new ContactEntity.

using (SuperOffice.SoSession session = SuperOffice.SoSession.Authenticate("user", "password"))

```csharp
using (SuperOffice.SoSession session = SuperOffice.SoSession.Authenticate("user", "password"))
{
    SuperOffice.Services.ContactAgent contactAgent = new SuperOffice.Services.ContactAgent();
    ContactEntity contactEntity = contactAgent.CreateDefaultContactEntity();

// ... populate contact properties
    contactAgent.SaveContactEntity(contactEntity);
}
```

Whether operating a local or remote database, an SoSession is the object that maintains a user's credentials. In the case of remote calls, the SoSession.SoPrincipal.SoIdentity property is users to construct an SoCredentialsHeader object, which gets serialized and passed in the SOAP header for authentication and authorization in the remote web service.

All action operations are facilitated through that Agent derived type.

**Limitations:**

There may be more limitations not mentioned here, but I'll note the top four limitations I noticed in the SuperOffice.Services layer.

Although nothing can be done about this one, a major limitation to the service layer is of course performance. Either way you go, local or remote, the data must traverse multiple wrappers. The only way around this one is to have a bigger network pipe.

One more obvious limitation of the SuperOffice.Services layer is the lack of asynchronous methods. Every call made to the web service is synchronous.

### Alternative .NET Solutions

There are two immediate alternatives to using the SuperOffice.Services.dll for .Net developers. The first, and easiest, is to simply add a Service Reference to the specific web service and make calls through that proxy. The second alternative is to use Microsoft's SVCUTIL tool to generate a client proxy for each web service your interesting in, such as Appointment.svc or Contact.svc.

Both alternatives generate method stubs to make asynchronous calls, however, there are still system limitations imposed when making more than two simultaneous calls. To remedy that you'll need to look further into how the .Net framework manages connections. The following configuration snippet allows you to configure your application to allow more than two, the default, simultaneous connections. Otherwise, when there are more than two, they are queued and executed synchronously.

**FExample connectionManagement section:**

```xml
<configuration>

    <system.net>

        <connectionManagement>

            <add address="http://www.mysrv.com/websvc/"maxconnection = "4" />

            <add address="*"maxconnection = "2" />

        </connectionManagement>

    </system.net>

</configuration>
```

### Alternative Java Solutions

For Java developers, although no thorough explanation that details how to create a proxy class for Java clients exists here. There is, however, an excellent section explaining just that on Sun's website, see [Creating Web Service Clients][3]. When it comes to authentication and authorization, each web request requires an SoCredentialsHeader element. In that element is a Ticket element. Because the ticket is a composite of data, it can be tricky to generate one correctly. When consuming .NET web services from other platforms, like Java and PHP, there is additional complexity as well. For example, the ticket ay needs to be prepacked with the UTF-8 Byte Order Mark (BOM).

## Service Layer Authentication

There are two scenarios when calling NetServer web services, and each demands a unique way to authenticate method calls. As implicitly explained above, the two scenarios are: calling NetServer web service through the SuperOffice.Services layer, and when calling the web services directly.

### SuperOffice.Services Layer Authentication

When using SuperOffice.Services.dll, authentication occurs exactly the same as when writing RDB and HDB routines - using the SoSession class. The following code snippet demonstrates how to authenticate using the SoSession class.

```csharp
SuperOffice.SoSession session = SuperOffice.SoSession.Authenticate("user", "password")

// ... Do Stuff ...

session.Dispose();

// ... or ...

using (SuperOffice.SoSession session = SuperOffice.SoSession.Authenticate("user", "password"))

{

// ... Do Stuff ...

}
```

SoSession exposes only static (VB Shared) methods to authenticate a user and has four overloads to facilitate multiple scenarios.

SoSession also has a very handy cache-type functionality. The following code shows how, once you have authenticated, you can suspend the current SoSession. Subsequent methods can begin by checking the MySession string for a value, and if not null or empty, submit the value in the continue method to begin more authenticated NetServer method calls.

**Using SoSession Suspend and Continue methods:**

```csharp
SoSession session = null;

string username = "JR";

string password = "";

privatestring mySession = string.Empty;

public string MySession

{

    get { return mySession; }

    set { mySession = value; }

}

public void SetContactInfo()

{

    if (string.IsNullOrEmpty(MySession))

        session = SoSession.Authenticate(username, password);

    else

        session = SoSession.Continue(MySession);

    ContactAgent ca = new ContactAgent();

    ContactEntity ce = ca.GetContactEntity(3);

    // set properties on the ContactEntity

    ca.SaveContactEntity(ce);

    MySession = session.Suspend();

}
```

### Direct Web Service Authentication

When calling a NetServer web service directly, first instantiate a proxy object, for example, the service object itself (Contact, Appointment, or Project), then set the SoCredentials property. Finally, make calls against the service to save or retrieve data.

The following example demonstrates how to call the web service through a Visual Studio WebReference proxy object.

**Direct web service authentication:**

```csharp
public ContactEntity GetContact()

{

    Contact ws = new Contact();

    ws.SoCredentials = new SoCredentialsHeader();

 

    // Get the ticket from the principal web service.

    ws.SoCredentials.Secret = GetTicket("JR", "password");

 

    ContactEntity contactEntity = ws.GetContact(3);

    return contactEntity;    

}

 

public string GetTicket(string username, string password)

{

   SoPrincipalClient client = new SoPrincipalClient();

    SoTimeZone timezone;
    SoExtraInfo extraInfo;
    SoCredentials credentials;
    SOPrincipalCarrier principal;
    bool authSuccess = false;
    bool success = false;
    SoExceptionInfo exInfo = pc.AuthenticateUsernamePassword(
                "",
                username,
                password,
                out extraInfo,
                out success,
                out timezone,
                out principal,
                out credentials,
                out authSuccess
                );
 
            if (exInfo != null)
                throw new SoServiceException(exInfo);
    return credentials.Ticket;
```

The first thing is to instantiate a Contact proxy object. Next, before any methods are called, the SoCredentials proxy property is set to a new SoCredentialsHeader instance, and then set accordingly.

SoCredentials is an object representation of the SoCredentialsHeader element, which is an element in the SOAP message header. Each time a method is called against the web service, these credentials are sent along with it. This is mandatory the order to successfully authenticate against the web service. If any one of these values is wrong, the most likely result will be a SoapHeaderException, accompanied by the "Server unavailable, please try later " message.

**SOAP Message:**

```xml
<xml version="1.0" encoding="utf-8"?>

<soap:Envelope xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:soap="http://schemas.xmlsoap.org/soap/envelope/">

    <soap:Header>

      <SoCredentials xmlns="http://www.superoffice.net/ws/crm/2005/04/Netserver20">

          <Ticket>NHoZChzE8hxd4XkJOc8yAQ==<Ticket>

      </SoCredentials>

    <soap:Header>

    <soap:Body>
        <GetContact xmlns="http://www.superoffice.net/ws/crm/2005/04/Netserver20">

            <contactId>3</contactId>

        <GetContact>

    <soap:Body>

<soap:Envelope>
```

Regarding NetServer services authentication, probably the most important thing to do first is to determine how you intend to leverage the web services provided by NetServer. Will you decide to use what has already been created for you, and include the SuperOffice.Services.dll in your project, or will you use some other means to create your own client proxy and implement all of the functionality yourself? Either way, the service-oriented aspects of NetServer web services provide many means to an end.

## Conclusion

In this article, I have given a high-level view of NetServer as a whole, as well as a thorough introduction to the NetServer SuperOffice.Services offerings.

In subsequent articles, I will provide a thorough introduction into Entities and Rows, explaining what about each is unique, what about each is similar, and when it's best to use which. The final article of this series will provide a thorough introduction to OSQL, and talk about when and how objectified SQL is used best.

Read: [What is NetServer, part 2][4]

<!-- Referenced links -->
[1]: what-is-netserver-part-1.md
[2]: https://msdn.microsoft.com/en-us/library/aa347733(v=vs.110).aspx
[3]: http://java.sun.com/developer/technicalArticles/J2EE/j2ee_ws/index.html#use
[4]: what-is-netserver-part-2.md

<!-- Referenced images -->
[img1]: media/netserverhilevelview.png
[img2]: media/sm-serviceinterfaces.png
[img3]: media/servicedatapath-sm.png
