---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: mirroring_getting_started       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Getting started with database mirroring # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: Tony Yates             # Your GitHub alias.
so.date: 20 Apr 2016
keywords:
so.topic: article             # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Getting started with database mirroring

On-line database mirroring for off-line data processing.

Using NetServer web services, online application have virtually unlimited access to customer databases for reading and writing data. However, when intensive, or extensive, data processing is needed, such as reporting, pattern recognition or trend processing, it's always best to have a local copy of a database. For just such a need, when **real-time data is not the most important consideration**, SuperOffice has added Database Mirroring as another integration surface to its' online integration offering.

## Conceptual Overview

Imagine you are an on-line application vendor who has creating the worlds best trending software. You have created an application that can scan a database, mine it for patterns and display trend reports. It would be nearly impossible to do this effectively with only web services.

![x][img1]

SuperOffice Database Mirroring provides a way for online partners to have access to a tenants database. Partners do not get an exact copy of a tenant database, but a subset that contains more than enough data for what partner applications need for offline processing.

A lot of data in the database is irrelevant and would not make sense to replicate. Data, such as last know window positions, criteria information and things of that nature are not relevant for processing customer data. User credentials and sensitive information is also removed, and as a result **you will not be able to connect to the mirror database using any SuperOffice client or APIs**.

It's important to note that Database Mirroring is not itself an application. Similar to how a window is a property of a house, Database Mirroring is a property of an application. It's an option that can be enabled or disabled for any online application. The primary components that make up Database Mirroring are:

1. The registered application inside SuperOffice Operations Center (OC).
2. The Mirroring Task, which is a background service in OC
3. A web service that implements both the IMirrorClientService and IMirrorAdmin interfaces.

The [registered application][1] contains all of the information provided by the partner about the application; description, contact information, technical contact, etc. It also contains the application id and application token, which was generated when the partner registered the application, as well as whether Database Mirroring is enabled or not. When enabled, the application definition must also contain the Mirroring URL; which is where the Mirroring Task will send the data.

The Mirroring Task is the responsibility of SuperOffice. It represents the background process that transfers data from a tenant database to a partner's registered application. It resides inside OC, and is responsible for provisioning the change tracking in customer database as necessary.

![x][img2]

Partners must create and host the web service that receive the data. Their web service must implement the IMirroringClient interface. The IMirrorClientService interface is responsible for establishing a trusted connection, receiving the data and performing the actual mirroring, such as provisioning of tables and performing schema updates.

Implementation Overview

SuperOffice starts the process by sending the partner web service a security token that contains a tenants context identifier and timestamp. It's up to the IMirroringClientService Authenticate method to validate the security token, and respond with it's ApplicationToken and timestamp. SuperOffice in turn validates the partners response to establish a two-way trust.

![x][img3]

There is no user or session concept in the Mirroring Client, so no session token is ever issued. The Mirroring Task will only proceed if it gets a valid response from the Client. The **Mirroring Task sends the SuperOffice signed token with every call so that the Client can validate each call independently**.

OC handles the scheduling of the Mirroring Task, running it periodically for each customer and application instance.

On each customer tenant there are a number of tasks running in sequence. The mirroring task is scheduled to run every 10 minutes, but times may vary if there is another long running customer tasks that is not yet finished. As of April 2019 we also stop the task completely between 23.00 to 06:00 every night.

For each cycle, the following operations are performed:

1. Authenticate with the registered service. SuperOffice sends a token that contains a signed context id + timestamp. The receiver validates it, and then responds with its ApplicationToken + timestamp, signed with a private key. See the section System User Authentication in the [Online Authentication in Detail article][2] for the correct formatting. The NuGet package provided by SuperOffice includes methods to facilitate these functions.  

2. For each table to be synchronized
    1. Check that change tracking is enabled for the table. If not, enable it
    2. Read the physical schema, and send it to the client
    3. The client responds with the Log Sequence Number (a 64-bit integer assigned by SQL Server) it has data for, for that table; and also updates its physical schema (including creating the table from scratch) as needed.
    4. Read the `<chunksize>` oldest changes from the table. If change tracking was not installed previously, or the client did not have the table, all rows are considered changed
    5. Transmit the changes to the client, each row includes its Log Sequence Number.
    6. The client writes the data to the mirror, and returns the Log Sequence Number of the last successfully written row.
    7. Repeat 2.4 - 2.6 until no more changes are found

3. After the last table has been synchronized, call the ReplicationCompleted method to indicate that mirroring is complete for this customer. The call can be used to generate indexes or perform other relevant tasks.

This process will automatically set up change tracking on the Online side, and create and update the schema of tables on the client-side. It will regenerate the mirror if it is thrown away or an older version is restored from backup.

If an older original is restored from backup, then the mirror should be thrown away; this is a very rare occurrence. Also note that Mirroring does not run during “maintenance” states, such as Online version upgrades, so backup/restore cycles during a failed upgrade does not trigger a mirror wipe.

![x][[img4]]

## Schemas and Change Tracking

The NuGet supplied API of the Client and the Mirror Admin use SQL syntax, Sql Server dialect for database column data types. SuperOffice Online is at present SQL Server only, and the SuperOffice implementation of the Mirroring Client Service in the NuGet package is also targeted to SQL Server. This avoids the need to instantiate a NetServer instance for database independence, and reduces the complexity of the overall system. It also reduces storage requirements and processing load, by using the schema and change tracking mechanisms already built-in in SQL Server.

### Schema

Sql Server physical schemas are used on both the Online and Partner ends. This makes the mirroring independent of various functional complexities, such as the several dictionaries (CRM, CS extratables) that exist.

The tables to be mirrored are – at least initially – a fixed set. If there is a great need for it then the table list can be made part of the App information; but this adds complexity and is probably not required. Simply put, all tables **except** a blacklist will be mirrored. [Blacklisted tables][3] are either irrelevant (travelgeneratedtransaction), not useful (traveltransactionlog, countervalue), or confidential (credentials).

The client maintains **one table** in the target database to store the minimum metadata needed: a schema hash, and Log Sequence Number, for each named table. The table is named `<context identifier>_mirroring`, such as `Cust10195_mirroring`. It is automatically created when the first mirroring occurs.

On each mirroring cycle, the physical schema is retrieved and transmitted. The client will hash the schema and look up in the metadata; if the hashes match then the mirror already has the correct schema. If not, then the local schema is retrieved (a missing table is simply an edge case here), and the schema is adjusted as needed.

Since the physical schema is used, there is no distinction between “dictionary” and “normal” tables; neither is there any distinction between tables belonging to Sales, Service, extra-tables in Service, or any Partner-defined tables that might appear in the future. All tables are mirrored equally, except those on the blacklist.

Mirroring of schema changes can fail. One such scenario occurs if a customer creates an Extra Table through CS, containing a character field. A mirroring cycle is run and the table is created and populated in the mirror. Later, the customer drops the table, and re-creates it with the same name… and this time adds a datetime field with the same name as the old character field. Farfetched, but possible.

The mirroring system will only see that the schema has changed with one column changing data type. This change will fail; the client code supplied by SuperOffice will react by dropping the table in the mirror database, creating it with the new schema, and request a full repopulation.

Mirroring only deals with a **simplified table schema**. In particular, this means that foreign key constraints, indexes as well as collating sequence are **not mirrored**. Primary key, data type, NULL / NOT NULL and default value are mirrored – and of course the table and column names. Schema/prefix is not mirrored; in the mirror, the default schema is always used. The connection string/login user can be used to influence the default schema.

Partners who need database indexes should create and maintain them before or after each replication cycle. In the NuGet implementation, partners can do this in one of the event handling methods in IMirrorAdmin, OnBeforeReplicateTable (called once for each table in each mirroring cycle) and OnReplicationCompleted (called once at the end of a complete cycle).

### Change Tracking

SQL Server change tracking is used in the Online customer database to track changes in all tables that are subject to mirroring. No row- or column-level filtering is intended; tables are either mirrored or not. [https://msdn.microsoft.com/en-us/library/bb933875.aspx][4] is the root of Microsoft’s documentation.

The Sql Server change tracking is a lightweight mechanism, implemented directly in the Sql Server database engine. It uses a 64-bit integer **Log Sequence Number**, that increases in the database over time.

Using this method, rather than the internal TravelTransactionLog, avoids the complexity stemming from the fact that UDEF changes, or the effects of merging two companies are logged differently from other operations (and Service operations are not logged at all in TravelTransactionLog).

When change tracking for a table is OFF, it is automatically turned ON by the mirroring system; a **wipe** message is sent to the client, and all records in the table are considered “changed” and therefore transmitted.

Change tracking data is kept for 7 days. If a Mirroring Client Service is down for longer than this, then a subsequent mirroring will cause a complete, automatic repopulation of the mirror, since change data will be missing.

### Resynchronizing

As outlined above, the mirroring system is to a large extent self-bootstrapping. The following scenarios are handled:

| Operation | Online | Partner |
|---|---|---|
| New Customer | Change tracking enabled as each table is mirrored, all rows considered changed | Table created as each Schema is received. All rows populated |
| Mirror restored from backup | Ordinary mirroring | Log Sequence Number is part of the restored backup; any changed since then will be retransmitted automatically |
| Online restored from backup | Manual intervention needed, to wipe mirror. Can be by turning off change tracking in restored database | Mirror wiped and repopulated remotely |
| Writing to mirror fails for any reason | Ordinary mirroring next cycle | LSN updated only on successful commit; so changes since the last successful cycle will be transmitted |
| Mirroring service is down for more than 7 days | Mirror is automatically wiped and repopulated | Mirror is automatically wiped and repopulated |
| Incompatible schema change | Error returned from the client side causes retry with wipe/repopulate - not implemented in beta | Schema change fails for whatever reason; table is dropped and error returned - not implemented in beta |

Since no “how far have we come” mirroring state is kept in the Online customer databases, there is no GUI for it either. Only the mirror knows the LSN for each table; this is by design and avoids the possibility of the assumed state to diverge from the actual state.

## IMirrorClientService Interface

The NuGet implementation is a WCF service. All following uses of the term "implementation" refer to the NuGet package implementation supporting SQL Server only.

There are only five methods in the service. Common to all is that no state is carried over from one call to the next – each call is fully self-contained. **Any implementation is also required to be multi-tenant and fully reentrant – multiple calls may be active at the same time, for multiple customers and/or tables; the only guarantee is that there will not be multiple active calls for one given combination of customer and table and that each customer’s mirroring cycle will run in a linear fashion from start to end**

![x][img5]

### Authenticate

This method is called once per customer, at the beginning of a mirroring cycle. It is used to exchange and validate signed tokens both ways, to establish that the URL of the registered application actually belongs to someone who has the private key of the same application. No session or state on the Mirroring Client is established.  
Authenticate is called and must return the application token and a timestamped signed with the App’s private key. The formatting of this string is discussed in the [Online Authentication in Detail article][5], in the System User Authentication section.

### TableSchema

Called once before any data is sent, TableSchema arguments contain the physical schema from Online (original), and the LSN (Log Sequence Number) is passed back to the Mirroring Task, so it knows what data to send. The mirror database is the only place where the LSN from the last update is known. As part of the TableSchema implementation, the mirror’s physical schema for the table is updated if needed. If needed, such an update may be done by dropping the table and recreating it with the new schema; in that case an LSN of -1 should be returned to force a full repopulation.

In the implementation, the IMirrorAdmin.OnBeforeReplicateTable event method is called after any schema adjustments have been made, with parameters specifying table and whether the schema has changed.

The service method interface takes an array of table schemas, so that the communication is more efficient; tables not present are assumed to be deleted from the source database and should be deleted from the mirror. The processing of each table is individual and in principle independent of other tables – it can be parallelized if desired.

### RowData

Called once for each batch of data sent, RowData arguments contains one or more batches of row data. One call is equivalent to roughly up to one megabyte of data (the SuperOffice Online server will limit total call size by tracking content size); the number of rows will vary widely depending on the actual size of the rows. Each batch refers to one table, but one service call may reference multiple tables using multiple batches. Batches can in principle be processed in parallel, but doing so would probably saturate the IO channel of the target database server.

Each row is tagged with an operation, Insert, Update or Delete. If a row has changed multiple times between mirrorings, then only the final state is transmitted; if it has been inserted, then updated, the operation sent will be an Insert with the final state only. Only the final batch for a table will have a valid LSN since intermediate rows may or may not have LSNs registered (if tracking was recently turned on, all rows existing prior to that time will not have an LSN).

The implementation saves the data and updates the LSN stored in the mirror’s metadata table. Insert operations are accumulated and committed through the Bulk Copy mechanism for speed.

### Wipe

This method is called whenever the Mirroring Task has determined that a table needs to be fully repopulated; including during the initial population. The implementation performs a truncate table command that removes all data, but leaves all schema structures (indexes etc) in place. There is no separate call to drop tables, as that is handled by the absence of table from the TableSchema request.

In the implementation, the IMirrorAdmin.OnWipe is called after the truncate command has run, in case the partner implementation needs to adjust its data, remove indexes or perform other preparatory functions.

### ReplicationCompleted

Called once at the end of a successful mirroring cycle. The standard implementation does nothing, this call exists only to call IMirrorAdmin.OnReplicationCompleted with a summary of what has happened in the mirroring cycle: number of insert/update/delete rows for each table. Partner code can use this to create indexes, update derived data or whatever else is required.

## IMirrorAdmin Interface - Only Used in the NuGet Implementation

Even though most of the mirroring client service is written by SuperOffice (in the NuGet package), partners still are given the ultimate responsibility to**provision** the mirror database (as well as hosting the service). How this is done and where the database resides is solely the partner’s concern. In addition, a few events may be useful to handle on the partner side.

![x][img6]

The Mirroring Client Service obtains access to the database by submitting the **Context Id** of the customer (“cust1234”) which uniquely identifies the customer in the Online universe.

Whether provisioning of the mirror database happens when the App is bought/installed, or when the first call to ResolveConnection happens, is up to the partner. There is no separate method to indicate a new customer; calls simply start to come in. However, as part of the ordinary application provision sequence, the application does know when it is being installed in a new customer site.

The first mirroring run happens immediately after the customer approves the application; after that the Online master scheduler controls mirroring.

The purpose and time of call for each method is described above, in the IMirroringClientService Interface section.

## Where to Begin

Whether the sole purpose of an application is database processing or a myriad of services, partners must first [register an application][1] and specifiy Database Mirroring should be enabled. In addition to the application details, a partner must provide a URL where the web service implementing IMirrorClientService and IMirrorAdmin is located.

Because each synchronization cycle begins with an authentication phase, certificates are used to ensure a trusted connection, and partners must ensure their servers have [installed the public SuperOffice certificates][5] to successfully validate security tokens sent from SuperOffice. Partners must also have a private certificate with which to sign authentication responses sent back to SuperOffice. Finally, SuperOffice must have the public side of the partners certificate in order to successfully validate those responses. There is a great deal more information about certificates in the [Security and Authentication][6] section of this topic.

With an application successfully registered in OC, and certificates setup correctly, the rest is pretty straight forward using our NuGet package. As you will discover in the next section, .NET and SQL Server partners can have an implementation up and running in about 10 minutes or less.

Partners who prefer to implement the IMirrorClientServce interfaces using another technology can download the [WSDL files here][8]. We do not provide support for any other technologies than those discussed here in this article, i.e. SQL Server.

## Up and Running in 10 Minutes or Less using NuGet

Although you are free to implement the service to support any database you prefer, SuperOffice provides a complete implementation of the database mirroring interface as a NuGet package. The following walk through will guide you through creating a new WCF service from scratch using the [SuperOffice.Crm.Online.Mirroring package][9], and help you have a running service in just a few minutes. These steps are documented using Visual Studio 2015.

To begin, click on File, then New, and then Project. In the New Project dialog, expand the WCF section and select to create new WCF Service Application.

![x][img7]

When the new WCF services application is created, it will appear as the picture below.

![x][img8]

Delete the default IService1.cs file, as well as the corresponding Service1.svc and Service1.cs file.

Below is a picture of the clean Solution Explorer without those files.

![x][img9]

Now it's time to install the package. If you do not see the Package Manager Console in your Visual Studio environment, open it by clicking Tools, then NuGet Package Manager, and then Package Manager Console.

Install the package by typing in the Package Manager Colsole window **Install-Package SuperOffice.Crm.Online.Mirroring**.

![x][img10]

In the NuGet Package Manager Console window, you will begin to see a lot of data scroll by. This is the Package Manager  inspecting the package and attempting at downloading the dependencies and adding them to your project.

Red highlights in the picture below highlight the key points: the package name, the System.IdentityModel.Tokens.Jwt dependency, the SuperOffice.Crm.Online.Core dependency and finally a successfully installed message.

![x][img11]

If not already open, open the package.config file from the Solution Explorer and observe the added packages. You versions may be different, and that is OK.

![x][img12]

In the Solution Explorer, expanded the References node and observe the new assembly references. Also observe the new files added to the project: MirroringClientService.svc, MirroringClientService.cs and Private.txt file.

The MirroringClientService class file is the Database Mirroring web service that SuperOffice will call to synchronize databases. The class inherits from the MirroringClientImplementation class, which resides in the SuperOffice.Online.Mirroring assembly. The MirroringClientImplementation class contains a majority of the functionality required by a Database Mirroring service to support synchronizing online tenant database with a local sql server database server. What is lacks is the ability to resolve a tenants contenxt identifier to a particular database, create the database if necessary, discover and provide the services' ApplicationToken, as well as the private certificate key it must use to sign the token placed in the AuthenticationResponse message. These key pieces of information are up to the partner to provide. Luckily for you, that too is implemented for you in the MirroringClientService.cs file, however you still must provide those key pieces of information in the projects web.config file.

![x][img13]

The key pieces of information required to successfully conduct Database Mirroring are listed in the appSettings section of the web.config file.

SoAppId must be set to the Application Identifier issued by SuperOffice upon completing application registration.

ConnectionBase is the partial connection string used to connect your SQL SERVER machine. MirrorDatabaseName will be used as a template for accessing the specific database on that server based on the context identifier passed to this service from SuperOffice.

The PrivateFileKey setting specifies the filename that contains your private certificate key in the RSA XML `<RSAKeyPair>` and `<RSAKeyValue>` format. This part is critical to ensure the service gets passed the initial authentication call. This is generally provided to you for use in the [SOD environment][9] when registering an application, but you will need to provide your own certificate for the Stage and Production environments.

![x][img14]

A little further down in the config file you will see a new system.serviceModel settings. Now present is a binding **DbMirroring**, because synchronizing database requires a lot of data, and in the services section a new service entry for the mirroring service.

![x][img15]

In the solution folder you can right-click the MirroringClientServer.svc file, then click "View In Browser" to open the service in a browser. Assuming everything is correctly in place, you will see the default IIS or IISExpress web service page.

![x][img16]

Finally, you will want to expose this service to a public HTTPS url in order for the SuperOffice Mirroring Task to access it. **This will be the URL you must give SuperOffice when registering your application.** Remember to specify this URL as the Database Mirror URL, not the Redirect URL.

![x][img17]

## How to Initiate Synchronization

With a publicly available working service, and your application registered, it's time to signal SuperOffice that your application is ready to be called. The real-world way to begin invocations is by installing your application from the SuperOffice App Store, but how do you do this without your application being listed in the SuperOfficeApp Store, or just wanting to debug it?

As a developer working in SOD, the easiest way to mock a customer installing your application is by typing the following URL in a browser with your Application Identity.

`https://sod.superoffice.com/login/?app_id=YOUR_APPLICATION_ID`

If you have not already logged into your SOD tenant and approved the application, the SuperOffice Online login page is shown. Using the credentials provided to you for your partner tenant in SOD, login and approve your application.

If you defined a Redirect URL for your application, you will not be redirected to that URL. If you did not specify a redirect URL for your application you will instead be redirected to your SuperOffice online tenant installation.

Shortly thereafter, the Mirroring Task will initiate an authentication request. As long as that is successful it will begin to deliver periodic updates to your mirroring service.

There is not yet a well-defined interval that determines how often each Mirroring Task will be performed. The guarantee SuperOffice provides is that it will be done at least once a day. There are several variables that determine how often the task will run, including load and availability, on average it will likely occur at least every hour. It SOD it appears to cycle more often than that.

The first method where you should establish a breakpoint is in the GetApplicationIdentifier or GetPartnerKey method. If you remember from the earlier authentication sequence diagram, these two key pieces of information are required to successfully sign and send an AuthenticationResponse to the Mirroring Tasks' AuthenticationRequest. If this process fails for any reason, ResolveConnection will not be called and no data will be synchronized.

## Overriding Default Functionality

A Partner can choose to override any of the methods of the base class – for instance, to inspect the parameters in detail, call the base implementation, and perform other related functions. This is useful if the existing IMirrorAdmin interface events are not sufficient.

![x][img18]

### Testing in SuperOffice Online Development Environment

This mirroring service will provision mirror databases on one fixed SQL server; each database will be named `Mirror_<contextId>`.

Any test databases (tenants) that Authorize your application (after successfully signing in on SuperOffices' login page) will then receive a mirror, and the mirror will be kept up to date as long as it is authorized. This represents the beginning of testing.

Mirroring activities are registered in the Event Log for the customer in OC. There is one Information entry for each successful mirroring cycle, as well as Error events when something fails.

In principle, any change to any table should be mirrored. This includes Insert/Update/Delete, as well as additions of extra tables and fields in the Service product. Note that many GUI operations that look like a delete do not actually delete physical rows from the database, so when testing deletes make sure that a delete actually happened in the customer database.

Since there is no GUI to look at data in a mirror, Sql Server Management Studio must be used. Generally it should be possible to do `select * from <sometable>` in both the customer table and the mirror, and get the same result.

Backup/restore is a special case. If the sequence of events is mirror – backup – change – mirror – restore – mirror, then the system will detect that the mirror is “ahead” of the original and trigger a full repopulation. However, if the scenario is mirror – backup – change – mirror – restore – change – change – mirror then the sum of changes since the restore may be enough to camouflage that fact that a restore happened. In that case the mirror must be manually invalidated at the partner side, which can be done by setting the LSN of all tables to -1 in the mirror database’s `<context_id>_mirroring` table. Whether we need a way to force this from OC is something we’ll have to find out.

## Database Mirroring Restrictions

It does not make business sense to provide a complete database mirror to partner applications. Not only might this incur unnecessary stress between systems, we prevent access to sensitive customer data that simply doesn't belong in any other domain, such as area and travel tables, search criteria and operators, dbi agent information and windows positions. A complete list of tables both replicated and not replicated with reason are listed in the [Mirrored Tables document][3].

## Conclusion

Database Mirroring presents a new API capability for partners building online integrations. By mirroring a customers database, it gives partners a tremendous about of flexibility to perform deep analysis on customer data; all without having to relay on web services subjected to latency or throughput issues.

We believe there are many scenarios where this capability will be extremely beneficial to partner applications, and those customers who consume them. We also realize that this capability poses a potential problem where partners will try to create solutions that don't fit any of the ideal scenarios. In most of these cases, they will be filtered and vetted through the certification process, so perhaps in the future there will be more best-case scenario guidance for application vendors to follow.

If you believe you have a great case for an application, navigate to the [application registration page][1] (for existing partners) and get started today! If you are not yet an online application partner, get started today by filling our [developer registration form][10].

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/developer/create-apps/resources/application-registration/
[2]: https://community.superoffice.com/en/developer/create-apps/how-to/develop/sign-system-user-token/
[3]: https://community.superoffice.com/contentassets/8c09bc95f03841cd87771bc367849cf5/mirroredtables.docx
[4]: https://msdn.microsoft.com/en-us/library/bb933875.aspx
[5]: https://community.superoffice.com/en/developer/create-apps/how-to/set-up/configure-certificates/
[6]: https://community.superoffice.com/en/developer/create-apps/concepts/authentication/
[7]: https://community.superoffice.com/en/developer/create-apps/resources/downloads/
[8]: https://www.nuget.org/packages/SuperOffice.Crm.Online.Mirroring
[9]: https://community.superoffice.com/en/developer/create-apps/overview/application-environments/
[10]: https://community.superoffice.com/en/developer/create-apps/resources/developer-registration/

<!-- Referenced images -->
[img1]: media/trendsyapp.png
[img2]: media/trendsy.png
[img3]: media/authenticationsequencediagram.png
[img4]: media/mirroringprinciplessequencediagram.png
[img5]: https://community.superoffice.com/contentassets/8c09bc95f03841cd87771bc367849cf5/imirroringclientservice.png
[img6]: https://community.superoffice.com/contentassets/8c09bc95f03841cd87771bc367849cf5/imirroradmininterface.png
[img7]: media/createwcfservice.png
[img8]: media/wcfservicedefaultsolution.png
[img9]: media/wcfservicesolution.png
[img10]: media/installdatabasemirroring.png
[img11]: media/installpackagesuccess.png
[img12]: media/packageconfig.png
[img13]: media/solutionpostinstall.png
[img14]: media/webconfigpostinstall.png
[img15]: https://community.superoffice.com/contentassets/8c09bc95f03841cd87771bc367849cf5/dbmirroring-webconfig.png
[img16]: media/wcfserviceiniis.png
[img17]: media/wcfserviceiniis_https.png
[img16]: https://community.superoffice.com/contentassets/8c09bc95f03841cd87771bc367849cf5/interface-implementation-classview.png