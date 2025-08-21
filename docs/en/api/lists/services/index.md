---
title: Lists in web services
description: Discusses how to programmatically work with lists using web services.
date: 03.03.2022
redirect_from: /en/api/netserver/lists/services/index
---

# SuperOffice Lists

This section discusses and demonstrates how to programmatically work with SuperOffice lists using SuperOffice web services.

There are two distinct web service APIs, SOAP and REST, and several client proxy tools to access the services. Please see the [introduction to SuperOffice web services][1] for more information about these options.

There are two primary endpoints for accessing lists:

1. [Lists endpoint][2]
2. [MDO endpoint][3]

The ``Lists`` endpoint provides the means to manage and retrieve lists and list items. List that have enabled heading and grouping feature must access list items via the MDO endpoint.

While the SOAP and HTTP RPC Agent APIs have two endpoints for accessing both the LIST and MDO endpoints, the RESTful REST web service API blends these operations under the LIST endpoint. This point will be explored in more detail in the relevant sections under the List and MDO documentation.

To learn more about how to create and manage lists, click on the List link below.

To learn more about how to work with list `Headings` and list items visible for certain certain `UserGroups`, click on the MDO link below.

* [List Endpoint][2]
* [MDO Endpoint][3]

[1]: ../../web-services/index.md
[2]: listagent/index.md
[3]: mdoagent/index.md
