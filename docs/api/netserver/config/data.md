---
title: NetServer Data element
uid: ns_config_data
description: NetServer Data Element
so.date: 06.06.2018
author: {github-id}
keywords: config
so.topic: reference
so.envir: onsite
---

# NetServer Data element

The data configuration section contains four subsections for managing the database connection and session handling.

[!code-xml[the SuperOffice section group](includes/data-element.xml)]

## Database

Configuration values for database connectivity define the location and database-vendor-specific settings.

| Name | Description |
|---|---|
| DatabaseMajor | Major name of database provider. Options: MSSQL, Oracle, Sybase, and DB2 (legacy only). |
| DatabaseMinor | Version number of database. |
| Server | The server name where the database is located. |
| DatabaseName | Name of the database. Also used for a distinct service name. |
| TablePrefix | The prefix of the SuperOffice CRM tables in the database. |
| ConnectionString | The formatted connection string template placeholders (`Server=[@Server];Database=[@Database];User ID=[@User];Password=[@Password]`). The number of parameters in the `ConnectionString` key will vary from one database vendor software to another, so will the names of the parameters. Vendor database software differences must be taken into consideration when setting this configuration key. The above example displays the configurations for an MSSQL database. |
| CommandTimeout | Timeout in seconds for the command to wait for a response from the database. |
| DynamicLoadedDataBaseDriver | Returns the name of the ADO.NET driver to load. |
| DynamicLoadedConnectionType | Returns the type of connection to open. |
| DefaultReadUncommitted | Should SELECTs by default run in "ReadUncommitted" isolation level, lessening locking contention (especially on SQL Server)? <br>Default: true |
| ImpersonateDatabaseUser | Should the DbUser be logged in with windows and impersonated when connecting to the database to support database integrated authentication.<br>Default: false |
| DisableSqlTrackingComments | If true, then comments that usually precede generated SQL to identify the operation and user will not be generated at all; may help performance on Oracle which thinks it has to re-parse everything if a comment changes.<br>Default: false |
| DisableUserInSqlTrackingComments | If true, then comments that usually precede generated SQL to identify the operation will not contain associate information; may help performance on Oracle which thinks it has to re-parse everything if a comment changes.<br>Default: false |

## Explicit

Configuration section for authentication behavior when users are explicitly authenticated, typically by calling `SoSession.Authenticate` or the corresponding WCF service.

| Name | Description |
|---|---|
| PartnerAllowed | Is partner access allowed. |
| EmployeeAllowed | Is employee access allowed.<br>Default: true |
| AnonymousAllowed | Is anonymous user access allowed.<br>Default: false |
| DBUser | Database user when running on behalf of explicitly authenticated users |
| DBPassword | Database user password. |
| CommonDBConnection | Use the same connection string for all users, applying the common User and Password from this section, vs. using the one provided elsewhere.<br>Default: true |

## Session

 This section governs session handling - what is the scope/storage of the session state, and so on.

| Name | Description |
|---|---|
| Mode | The mode of the session: Thread, Context, HttpContext, Process.<br>Maps to a class name that provides session storage. |
| ReauthenticateOnDeserialization | A full re-authentication is carried out each time the session is de-serialized (e.g. from the session server). |

When in Mode **Thread**, every session requires the [suspend][1] and continue methods to be called for each query task. Here, each thread executed in NetServer will have sessions that are stored in the implication of different threads and have different session values stored in them. If you want to suspend a session, you must call the suspend method which returns a string with the session values. Should you wish to continue that session, you must call the continue method and pass the string with session values in it as a parameter.

When in Mode **Context**, your session only requires authentication and a closure. Here, once you authenticate a session it will be for the lifetime of the session. It is not necessary to call continue and suspend methods. The session values for this configuration will be stored in a context static manner.

<!-- Referenced links -->
[1]: ../../authentication/session-handling/suspend-session.md
