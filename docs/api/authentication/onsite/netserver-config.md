---
title: Configuration
uid: auth_onsite_config
description: Application configuration for NetServer integrations that use SuperOffice assemblies
author: AnthonyYates
so.date: 05.08.2018
keywords: authentication, config
so.topic: concept
so.envir: onsite
# so.client:
---

# NetServer configuration

All NetServer integrations **that use SuperOffice assemblies** require settings in an application's configuration file, *app.config* or *web.config*. This is not the case for custom web service proxies or REST. This applies only when an application makes a file reference to *SOCore.dll*, *SoDatabase.dll*, and other required SuperOffice DLLs.

Below is a configuration file with only the bare essential SuperOffice sections defined:

[!code-xml[XML](includes/web-config.xml)]

> [!NOTE]
> The **Data element** contains the session, database, and explicit sections. Often, the cause of connectivity problems lays here.

## Session

`Session` determines how the authenticated session will exist at runtime. There are 3 options by default: Process, Context, and Thread. Each session option determines where in memory the authenticated session will be available from.

| Session option | Availability of authenticated SoSession |
|---|---|
| Process | to all synchronization contexts and threads |
| Context | only to routines passed to the same synchronization context |
| Thread  | only on that thread - if another non-authenticated thread tried to use the SuperOffice API to get data, NetServer would throw an exception. |

## Database

The `Database` section is used to define your database-specific details and will look slightly different than the example if you are targeting DB2 or Oracle. More information about the database section can be found in the [NetServer configuration reference][5].

## Explicit

The `Explicit` section allows an application to determine what type of users are authorized to use this application, as well as must set the database credentials, which map to both a database server user and a SuperOffice system user.

<!-- Referenced links -->
[5]: ../../netserver/config/data.md

<!-- Referenced images -->
