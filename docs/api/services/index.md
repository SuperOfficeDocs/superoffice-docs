---
title: services       
description: SuperOffice NetServer services
author: {github-id}             # Your GitHub alias.
so.date:
keywords:
so.topic: concept
---

# SuperOffice NetServer services

A service is primarily a method exposed by the NetServer to manipulate the data or enhance the presentation of the data in the SuperOffice database. In the NetServer the services infrastructure has been built using the [agent][1] and [carrier][2] software patterns. **The agent object presents the services and the carrier object represents the data passed back and forth to the server by the agent, depending on the configuration.**

All the services are called through an agent that is designed to handle a specific business area, for example, there will be a dedicated agent to handle the services intended for the sales area. All the agents live in the `SuperOffice.CRM.Services` namespace.

## Objective

The objective of the NetServer services is to provide a simple yet powerful API to access SuperOffice CRM functionality. The service API lets you work with the database without having to know the details of how data is stored inside the database. It presents a high-level API where all the hard work of language decoding, security checks, database selects, and joining tables are handled for you. A single service call will represent many database queries and contain business logic, user-preference checking, and default handling.

## SoSession

A session retrieves data regarding the currently logged-in user and keep them in the cache. Session Cache holds authentication information about the logged-in user, associate of the user, business ID of the company that the user belongs to, reference data, and many more. Each time a new user logs in a session is created.

* [Create session][3]
* [Suspend session][4]

<!-- Referenced links -->
[1]: agents/index.md
[2]: carriers/index.md
[3]: ../authentication/session-handling/create-session.md
[4]: ../authentication/session-handling/suspend-session.md
