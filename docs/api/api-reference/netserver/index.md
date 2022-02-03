---
uid: netserver-api-reference
title: NetServer API reference
description: NetServer is a multi-tiered database access layer that bridges communication between clients and the SuperOffice database.
author: AnthonyYates
so.date: 02.02.2022
keywords: API, NetServer
so.topic: reference
so.envir: cloud, onsite
so.client: win, web
---

# NetServer API

NetServer is a multi-tiered data access library for the SuperOffice database. Whether deploying a solution to a local SuperOffice database installation or operating in a distributed environment, NetServer exposes an array of application programming interface (API) approaches to facilitate a wide range of solution implementations. Although the terrain is vast and complex, and at first sight, be can somewhat intimidating, the NetServer API tailors to a wide variety of developers by layering the architecture in various intuitive abstractions.

When writing code that executes on a PC within a local network or domain, use the [NetServer Core API](https://www.nuget.org/packages/SuperOffice.NetServer.Core) for optimal performance. If there is ever a change the application will need to operate in a distributing fashion, i.e. connect to SuperOffice NetServer web services, then use the [NetServer Services API](https://www.nuget.org/packages/SuperOffice.NetServer.Services) for optimal flexibility.
