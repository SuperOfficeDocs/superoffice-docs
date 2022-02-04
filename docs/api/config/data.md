---
title: NetServer Data element
uid: ns_config_data
description: The NetServer Data configuration section contains subsections for managing the database connection and session handling.
so.date: 12.09.2021
author: Bergfrid Dias
keywords: config, NetServer, web.config, Database, CommandTimeout, ConnectionString, DatabaseMajor, DatabaseMinor, DatabaseName, DefaultReadUncommitted, DisableSqlTrackingComments, DisableUserInSqlTrackingComments, DynamicLoadedConnectionType, DynamicLoadedDataBaseDriver, ImpersonateDatabaseUser, Server, TablePrefix, Explicit, PartnerAllowed, EmployeeAllowed, AnonymousAllowed, DBUser, DBPassword, CommonDBConnection, Session, Mode, ReauthenticateOnDeserialization, CacheCheckInterval, ForceCacheRefreshInterval, SystemAllowed
so.topic: reference
so.envir: onsite
---

# NetServer Data element

The data configuration section contains subsections for managing the database connection and session handling. Combined, these sections define which server and database the caller will connect as well as what state settings to use.

[!code-xml[the SuperOffice section group](includes/data-element.xml)]

## Database

Configuration values for database connectivity define the location and database-vendor-specific settings. Supported database servers include SQL Server and Oracle and the values will look slightly different depending on which vendor you use.

| Name | Description | Default |
|---|---|---|
| CacheCheckInterval | Number of seconds to check if caches are outdated and need to be refreshed. 0 will disable the timer. | |
| CommandTimeout | Timeout in seconds for the command to wait for a response from the database. | |
| ConnectionString | The formatted connection string template placeholders (`Server=[@Server];Database=[@Database];User ID=[@User];Password=[@Password]`). The number of parameters in the `ConnectionString` key will vary from one database vendor software to another, so will the names of the parameters. Vendor database software differences must be taken into consideration when setting this configuration key. The above example displays the configurations for an MSSQL database. | |
| DatabaseMajor | Major name of database provider. Options: MSSQL, Oracle, Sybase, and DB2 (legacy only). | |
| DatabaseMinor | Version number of database. | |
| DatabaseName | Name of the database. Also used for a distinct service name. | |
| DefaultReadUncommitted | Should SELECTs by default run in "ReadUncommitted" isolation level, lessening locking contention (especially on SQL Server)? | true |
| DisableSqlTrackingComments | If true, then comments that usually precede generated SQL to identify the operation and user will not be generated at all; may help performance on Oracle which thinks it has to re-parse everything if a comment changes. | false |
| DisableUserInSqlTrackingComments | If true, then comments that usually precede generated SQL to identify the operation will not contain associate information; may help performance on Oracle which thinks it has to re-parse everything if a comment changes. | false |
| ForceCacheRefreshInterval | Number of seconds before caches are force refreshed. 0 will disable the timer. | |
| ImpersonateDatabaseUser | Should the DbUser be logged in with windows and impersonated when connecting to the database to support database integrated authentication. | false |
| Server | The server name where the database is located. | |
| TablePrefix | The prefix of the SuperOffice CRM tables in the database. | |

**Sybase-specific settings:**

| Name | Description | Default |
|---|---|---|
| DynamicLoadedConnectionType | The type of connection to open. | |
| DynamicLoadedDataBaseDriver | The name of the ADO.NET driver to load. | |
| DynamicLoadedDataBaseDriverPolicy | The location of the policy file. | |

## Explicit

Configuration section for authentication behavior when users are explicitly authenticated, typically by calling `SoSession.Authenticate` or the corresponding WCF service. Relates to employee and partner access to the SuperOffice database.

The `Explicit` section allows an application to determine what type of users are authorized to use this application, as well as must set the database credentials, which map to both a database server user and a SuperOffice system user.

| Name | Description | Default |
|---|---|---|
| AnonymousAllowed | Is anonymous user access allowed? | false |
| CommonDBConnection | Use the same connection string for all users, applying the common User and Password from this section, vs. using the one provided elsewhere. | true |
| DBPassword | Database user password. | |
| DBUser | Database user when running on behalf of explicitly authenticated users | |
| EmployeeAllowed | Is employee access allowed? | true |
| ExternalPersonAllowed | Is an [external person][3] allowed access? |
| PartnerAllowed | Is partner access allowed? | |
| SystemAllowed | Is system user access allowed? | |

### CommonDBConnection

If this value is "True", DBUser and DBPassword are used in the database connection.

Otherwise, the credentials provided in the authentication (for example `SoSession` class) will be used.

**True** is the default for server applications (Web), and **False** is the default for client applications (Windows forms).

## ImplicitAnonymous (deprecated)

This section relates to anonymous access to the SuperOffice database. It is what you get when you don't explicitly authenticate as a user. Usually disabled in SO.web, which uses explicit users.

> [!NOTE]
> The ImplicitAnonymous section was removed in version 8.5.

| Name | Description |
|---|---|
| Allowed | Is anonymous access is permitted? |
| DBPassword | The password used to connect to the database. |
| DBUser | The database user (not the CRM5 user) used to connect to the database. |
| SoPassword | The SuperOffice CRM5 user password. |
| SoUser | The SuperOffice CRM5 username of the Anonymous user. |

## Session

 This section governs session handling: how the authenticated session will exist at runtime, the scope/storage of the session state. This relates to the lifetime of a NetServer communication session, such as the duration of a transaction, or group of transactions, and maintains the credentials defined in one of the following sections.

| Name | Description |
|---|---|
| Mode | The mode of the session: Thread, Context, HttpContext, Process.<br>Maps to a class name that provides session storage. |
| ReauthenticateOnDeserialization | A full re-authentication is carried out each time the session is de-serialized (such as from the session server). |

Each session option determines where in memory the authenticated session will be available from.

| Mode | Availability of authenticated SoSession |
|---|---|
| Process | to all synchronization contexts and threads |
| Context | only to routines passed to the same synchronization context |
| Thread  | only on that thread - if another non-authenticated thread tried to use the SuperOffice API to get data, NetServer would throw an exception. |

* **Thread:** Every session requires the [suspend][1] and continue methods to be called for each query task. Here, each thread executed in NetServer will have sessions that are stored in the implication of different threads and have different session values stored in them. If you want to suspend a session, you must call the suspend method which returns a string with the session values. Should you wish to continue that session, you must call the continue method and pass the string with session values in it as a parameter. The session is stored in a thread-static manner.  Each executing thread has a separate instance of the session. If the session is accessed on a different thread, it will contain a different value. For further reference, see `System.ThreadStaticAttribute`.

* **Context:** Your session requires only authentication and a closure. Here, once you authenticate a session, it will be for the lifetime of the session. It is not necessary to call continue and suspend methods. The session values for this configuration will be stored in a context-static manner. For further reference, see `System.ContextStaticAttribute`.

* **Process:** Session is stored in a process-static manner. This is the normal option for Windows applications.

* **HttpContext:** Recommended in ASP.NET applications. Added to prevent ASP.NET thread switches from changing identities in the middle of an ASP.net request.

See the [NetServer Core reference][2] for details about handling this programmatically.

<!-- Referenced links -->
[1]: ../../authentication/onsite/sosession/suspend.md
[2]: <xref:SuperOffice.Configuration.ConfigFile.Data>
[3]: ../../authentication/users-and-associates.md#external-users-type-4
