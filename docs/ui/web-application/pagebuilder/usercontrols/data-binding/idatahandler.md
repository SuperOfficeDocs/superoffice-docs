---
title: idatahandler
description: IDataHandler
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: concept
so.client: web
so.envir: onsite
---

# IDataHandler

The IDataHandler interface is responsible for loading, saving, deleting, clearing, and creating new namespaces to the corresponding datasource. A new `IDataHandler` instance will be created from the configuration values in the XML base file by the PluggableHandler, and necessary information will also be passed to it during the instantiation so that it knows which datasource to connect to.

All implementations of this interface must provide a constructor taking an `IDictionary` argument which contains pairs of string type key-value pair to provide necessary information about the datasource. In theory, a single data handler could expose multiple objects, but in practice, each data handler tends to expose a single object via a single carrier name.

The interface is located in the *SuperOffice.CRM.Web.Data* namespace and includes methods such as:

* Load( string carrierId )
* Save()
* New()
* New(string carrierId)
* Delete()
* Clear()

We can take any `DataHandler` class from the namespace and inherit from the `DataHandlerBase` class. Mainly we are not going to override the methods in the base class. We override the `Initialize` method by calling the base class’s `initialize()` and then adding a data carrier to it.
