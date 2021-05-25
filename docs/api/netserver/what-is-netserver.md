---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.
uid: what_is_netserver
title: What is Netserver
description: What is NetServer
author: AnthonyYates
so.date: 07.28.2006
keywords:
so.topic: article
so.envir: cloud
so.client: online
---

# What is NetServer

This article is an overview of the NetServer API, as well as dive into the different aspects of NetServers service offerings.

## Birds-eye view

In a nutshell, NetServer is a layered, factory-driven library that enables developers to conduct Create, Read, Update and Delete (CRUD) operations to the SuperOffice database, and more. Whether deploying a solution to a local SuperOffice database installation or operating in a distributed environment, NetServer exposes an array of application programming interface (API) approaches to facilitate a wide range of solution implementations. Although the terrain is vast and complex, and at first sight, be can somewhat intimidating, the NetServer API tailors to a wide variety of developers by layering the architecture in various intuitive abstractions. In this article, I will guide you through the various regions of NetServer, show you the attractions, as well as point out the areas to avoid.

When programming with the NetServer API, other than calling the web services directly, every solution needs a SuperOffice-specific section group in your application configuration file. This means adding a SuperOffice-specific section group to an *app.config* file for Windows Forms applications, or the *web.config* file for an ASP.NET web application. The SuperOffice section group contains configuration options relevant NetServer operations, such as logging, document handling, security, database options, and so forth. Everything you need to know about the SuperOffice configuration options is well-defined in the [NetServer Configuration documentation][1].

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

So, what does all of this look like in code? **Figure Three** shows: creating a session with the [SOAP proxies](https://www.nuget.org/packages/SuperOffice.NetServer.Services) to create ContactAgent - to communicate with the Contact web service, using the ContactAgent to create and save a new ContactEntity.

using (SuperOffice.SoSession session = SuperOffice.SoSession.Authenticate("user", "password"))

```csharp
using (SuperOffice.SoSession session = SuperOffice.SoSession.Authenticate("user", "password"))
{
    SuperOffice.Services.ContactAgent contactAgent = new SuperOffice.Services.ContactAgent();
    ContactEntity contactEntity = contactAgent.CreateDefaultContactEntity();
    contactEntity.Name = "Supra Inc.";
// ... populate contact properties
    contactAgent.SaveContactEntity(contactEntity);
}
```

Whether targeting a local or remote database, an SoSession is the object that maintains a user's principal. In the case of remote calls, the SoSession.SoPrincipal.SoIdentity property is used to construct an SoCredentialsHeader object, which gets serialized and passed in the SOAP header for authentication and authorization in the remote web service. See the [Authentication](../authentication/overview.md) section for more information about authentication.

All action operations are facilitated through that Agent derived type.

### Alternative .NET Solutions

There are two immediate alternatives to using the SuperOffice.Services.dll for .Net developers. The first, and easiest, is to simply add a Service Reference to the specific web service and make calls through that proxy. The second alternative is to use Microsoft's SVCUTIL tool to generate a client proxy for each web service your interesting in, such as Appointment.svc or Contact.svc.

Both alternatives generate method stubs to make asynchronous calls, however, there are still system limitations imposed when making more than two simultaneous calls. To remedy that you'll need to look further into how the .Net framework manages connections. The following configuration snippet allows you to configure your application to allow more than two, the default, simultaneous connections. Otherwise, when there are more than two, they are queued and executed synchronously.

**Example connectionManagement section:**

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

Regarding NetServer services authentication, probably the most important thing to do first is to determine how you intend to leverage the web services provided by NetServer. Will you decide to use the [SOAP proxies](https://www.nuget.org/packages/SuperOffice.NetServer.Services) in your project, create your own client proxy or use the [REST](../api-reference/restful/index.md) endpoints and implement all of the functionality yourself? Either way, the service-oriented aspects of NetServer web services provide many means to an end.

## Relational Database Layer

As I discussed in the previous article, Entities is the layer at which all database entities are exposed. Conceptually, these are the NetServer business objects, such as Contact, Address, and Appointment. When you need to work with people models, for example, you get or create a Person entity. When you need to work with projects, you get or create a Project entity.

Entities are objects that may contain property values that are fetched by more than just the primary object table. In the case of a Person entity, the primary object table being the Person table. A Person.Contact property is a class object that is structured and populated in such a way that take into account settings from more tables than just the Person table.

There are three types of entity types: one entity, entity collections, and entity lists.

Entity are logical real-world objects that make up the business models, such as Contact, Person, Appointment, and so forth. Entity collections are simply collections of the business models, such as ContactCollection, PersonCollection, and AppointmentCollection. Entity lists are similar to entity models, but instead of collections or row objects as properties, list items contain real data values for each property.

The following code demonstrates one way to iterate over the appointments of a person. The Person class is first instantiated by using the inner index searcher class, IdxPersonId. This inner index class is the equivalent of a pseudo method, Person.GetPersonById(...). Every entity object contains at least one inner Idx fetcher class. Each Idx fetcher is also exposed as a static **GetFromIdx** method, i.e. Person.GetFromIdxPersonId.

In the iteration, for every appointment in the Person.Appointments collection, if the appointment type equals type inDiary, meaning the appointment is in the persons diary (calendar), then we will write out some details of the appointment to the console window.

```csharp
using (SoSession session = SoSession.Authenticate("JR", ""))
{
    Person person = new Person.IdxPersonId(7);

    foreach (Appointment apt in person.Appointments)
    {
        //Show Diary Appointments
        if (apt.Type == AppointmentType.inDiary)
        {
            Console.WriteLine(string.Format("ID: {0}\tTask Name: {1}\tStatus: {2}\tDue Date: {3}",
               apt.AppointmentId, apt.Task.Name, apt.Status.ToString(),
               apt.DoBy.ToString()));
         }
    }
}
```

Notice how easy it is to access all of the appointments and appointment information belonging to a person. There is no need to write complex SQL queries that join multiple other tables and establishing criteria, to gain access all of the details pertaining to the appointment. All complex properties of the appointment are easily accessible.

Its also important to note that the value of many entity properties are retrieved from the database when the property is accessed, not when the object itself is initialized. This is sometimes referred to as lazy fetching.

The following code demonstrates again how to leverage an entities inner Index class to fetch the business object - in this case a Contact. Notice how easy it is to logically drill down into the entity and intuitively access the data it contains. Once again, no complex SQL query is required to access the properties of the Contact object.

```csharp
Contact contact = new Contact.IdxContactId(7);

PersonCollection people = contact.Persons;

foreach (Person person in people)
{
    Debug.Assert(person.Contact.Name == contact.Name);
}
```

## Entity Property Types

Whether programming with system data types, or class object data types, properties are just data types. In this section though, I think it is important to note the property data types you are likely to encounter from NetServer Entities. Many of the business object properties bridge the divide between Entity objects and Row objects, and share the same properties.

In many cases, entity properties are intrinsic data types, such as integers and strings. This is the case when working with Entity lists. Other entity properties are entity collections, such as the Contact.Persons property which is of type PersonCollection.

Another common type found in entity properties is of type Row. For example, the Contact.Business property is actually a Row object, of type BusinessRow. Entity properties of type XRow, where X is the name of the property, are similar to that of ADO.NET DataRows. These data types are discussed more in the Row Layer section below.

Each entity object also has a Row property, and this is a direct link to the corresponding HDB Row object. The type is explained in detail in the following section.

The final entity property type you will encounter, which is also categorically in the Rows layer, is a TableInfo type. Every entity type has a TableInfo property that describes the schema of the base entity object. TableInfo discussed more in the Row Layer section.

![x][img4]

## High-Level Database Layer (Rows)

HDB rows are very similar to that of ADO.NET DataTable and DataRow objects. The NetServer DataTable equivalent is a rows collection, such as PersonRows, whereas the DataRow equivalent is a single row object, such as PersonRow.

Rows can represent one or more rows from a database table. Additionally, for every table in a SuperOffice database, there is a corresponding Row and Rows object.

Unlike entity models, where an entity property may contain data fetched from other tables, Row types only contain foriegn key ID values that point to the data details in another table.

Each row contains a TableInfo property. TableInfo types are a schema type that contains all of the information pertaining to the schema of the table field layout.

The TableInfo property contains properties for the table name and definition, the database name, and a useful method to lookup fields by field name, called FindField. The TableInfo object is similar to an ADO.NET DataTable.Columns property, in that it exposes all of the columns as FieldInfo objects through the TableInfo.All property. TableInfo.All returns an array of FieldInfo objects, one for each column in the table. For example, with the PersonRow object, the PersonRow.TableInfo.All property details all of the columns available in the Person table. The result of running the following code would write out all 42 column names to the debug window. With each FieldInfo object, there are properties for the fields data type, the parent table, and many useful Argument methods, such as Between, GreaterThan, LessThan, and Like, to test the value of the field in the current row.

**Accesssing all columns of a PersonRow object:**

```csharp
PersonRow person = new PersonRow.IdxPersonId(7);

FieldInfo [] fields = person.TableInfo.All;

foreach (FieldInfo fld in fields)
{
    Debug.WriteLine(fld.Name);
}
```

In contrast to the limited number of inner index fetcher classes for a single Row object, the Rows object expose many Idx fields to conduct useful queries.

**Code demonstrating available inner index classes of the PersonRows class:**

![x][img5]

Below, we see again how easy it is to use the inner index classes as fetcher objects. The code demonstrates how to use the inner IdxContactId class to establish the criteria for the records returned in the result set. In this example, we see that passing in a value of 3 will limit the number of PersonRow objects in the PersonRows object to only the records in the database where the contact\_id field is the value 3.

**How the inner index class IdxContactId fetches a collection of PersonRow, PersonRows:**

```csharp
PersonRows people = new PersonRows.IdxContactId(3);

foreach (PersonRow personRow in people)

{
    Debug.Assert(personRow.ContactId == 3);
}
```

As seen in Entities, each inner Idx fetcher class has a cooresponding static helper method, i.e. PersonRows.GetFromIdxName.

### Custom Search Queries

Both entity and row types contain an inner class called CustomSearch. CustomSearch queries allow you to go above and beyond that of index queries, as seen in Figures One and Two. NetServer provides the ability to append additional criteria to a given object or collection search by setting the Restriction property. Even greater query capability is available by including other TableInfo objects for join selections on the JoinRestriction property.

For example, Figure Four demonstrates a simple custom search. The results of the custom search are predicable; the people object will be a PersonCollection containing all of the people in the Person table. This means that for each row in the Person table, there will be one Person in the PersonCollection.

**Simple Custom Search:**

```csharp
PersonCollection.CustomSearch peopleSearch = new PersonCollection.CustomSearch();

PersonCollection people = peopleSearch.ToPersonCollection();
```

What if you wanted to see all Person entities who were born after January 1, 1970. The following code demonstrates a custom search to implement such a query.

**Custom search to return all person rows with a birthday greater than January 1, 1970:**

```csharp
PersonCollection.CustomSearch peopleSearch = new PersonCollection.CustomSearch();

peopleSearch.Restriction = peopleSearch.TableInfo.DayOfBirth.GreaterThan(S.Parameter(newDateTime(1970, 1, 1)));

PersonCollection people = peopleSearch.ToPersonCollection();
```

Notice that the Restriction property accepts an Argument object as a type. Ok, so this is not explicitly shown by looking at the above code, but that is what implicitly gets set in the Restriction. Encapsulated in the architecture, Restriction inherits from the type QueryElement, as does Argument. Other types, such as GreaterThan, LessThan, Equal, Like, ultimately end up inheriting from QueryElement. Internally, custom search functionality is handled using the Visitor pattern, but that is far beyond the scope of this article and will not be discussed here. Luckily, we as developers using NetServer do not need to know exactly how this is implemented. All we need to know is that, in order for us to define our desired results, all we need to do is stick to using the properties exposed by the custom search object TableInfo property to establish criteria.

Lets take the custom search one step further and set the criteria to return only the people from the contact with a contact\_id value of 3, and those who were born after January 1, 1970.

**Custom search for people who are a member of a Contact where contact\_id is 3, and those who were born after January 1, 1970:**

```csharp
PersonCollection.CustomSearch peopleSearch = new PersonCollection.CustomSearch();

peopleSearch.Restriction =
                    peopleSearch.TableInfo.ContactId.Equal(S.Parameter(3)).And(
                    peopleSearch.TableInfo.DayOfBirth.GreaterThan(S.Parameter(newDateTime(1970, 1, 1))));

PersonCollection people = peopleSearch.ToPersonCollection();
```

Notice how the Argument can contain more than one type of Argument to send to the underlying query. In this case, it leverages the Restriction And method to append a new Argument to the search query. Restriction also contains an Or method, to append OR statements to the query criteria.

## Entities / rows performance

The following figure displays a summary of performance using the different objects available to extract data from the database using Entities and Rows. The test database was a small one, with only 39 contacts. Using performance counters, the test included retrieving all contacts as a ContactCollection, ContactList, and ContactRows. ContactRows, being the lowest layer used, clearly out performed the other two queries with an average of 9.1 milliseconds. The ContactCollection query finished a little while later, at an average of 25.8 milliseconds. The ContactList trailed far behind the other two, with an average search time of 212.4 milliseconds.

**Performance testing:**

![x][img6]

## Objectified SQL

OSQL is the lowest layer of the NetServer API that provides a programmatic query language for reading and writing data to and from a SuperOffice database. It’s the objectified equivalent to writing database Structured Query Language (SQL) and is the most performing of all NetServer API layers. You can think of it as the SuperOffice Database Interface (SODBIF).

Read more about OSQL on the [Objectified SQL](osql/index.md) page.

## Conclusion

This has been a high-level view of NetServer. As you can see, there is a vast difference between the different approaches. Be aware though that, just because one layer took longer to complete than the other, it does not any one layer should be ignored. Each query type has its place in the development world when used judiciously.

<!-- Referenced links -->
[1]: config/index.md
[2]: https://msdn.microsoft.com/en-us/library/aa347733(v=vs.110).aspx
[3]: http://java.sun.com/developer/technicalArticles/J2EE/j2ee_ws/index.html#use

<!-- Referenced images -->
[img1]: media/netserverhilevelview.png
[img2]: media/sm-serviceinterfaces.png
[img3]: media/servicedatapath-sm.png

<!-- Referenced images -->
[img4]: media/persontableinfo.gif
[img5]: media/personrowsobject.gif
[img6]: media/contactchart.png
