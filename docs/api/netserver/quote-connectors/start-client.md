---
title: Start the client
uid: quote_connectors_start
description: How to start the quote connector client
author: {github-id}
so.date:
keywords: quote
so.topic: howto
---

# Start the client

Connections are initialized on demand.

The SuperOffice windows client calls `InitializeConnection` during startup using the values saved from the **Create** connection dialog in the Admin client and then checks the return value to see if the ERP system is available.

If the connection initialized OK, then SuperOffice will mark the connection as available for use.

If the `InitializeConnection` returned NOT OK then the connection is marked as unavailable – and the connection will not be used for the remainder of the session. This means that any quotes created using this connection cannot be edited, and the **OPEN** button will be disabled.

![06][img1]

If a connection fails to initialize then the result is cached, so that the client can get the initialize result later (for tooltips and the like).

## Int CRMConnectionId

The ID of this connection in the CRM system.

## PluginResponseInfo InitializeConnection( QuoteConnectionInfo connectionData, Dictionary <string, string> configurationFields, IProductRegisterCache productRegister)

Set up the connection to the ERP system. Will be called as part of SuperOffice client startup for each installed connection.

Configuration data comes from the config dialog shown in the Admin client. See `IQuoteConnectorSetup.GetConfigurationFields` in [the setup][1].

The key in the Dictionary is the `FieldKey`, and must match the key in the `FieldMetadataInfo`. The value is the user's input during setup.

**Return value IsOk:**

False means the connection is not available, and quotes based on this connection cannot be edited. `IsOk`is set to false if the connector can’t provide service (no network). Text will explain this to the user.

## Dictionary < string, PluginResponseInfo > GetCapabilities()

Returns a set of capability name-status pairs that tell the system what capabilities this connector provides.

Using the `PluginResponseInfo` gives the connector the possibility to disable a capability, with a reason string that might be shown to the user.

## QuoteVersionResponseInfo OnBeforeCreateQuote ( QuoteContextInfo context )

Called when a user is creating a quote. Returns an updated context.

The Quote does not exist in database at this time. Any changes in the returned `QuoteContextInfo` will be saved and the GUI updated.

The following parts of the QuoteContextInfo can be updated by this method:

* Quote
* QuoteVersion
* QuoteAlternative

Changes to other parts of the `QuoteContextInfo` will be ignored.

## void OnAfterSaveQuote( QuoteContextInfo context )

Called after a sale containing a quote is saved: after quote is created, and after quote dialog is closed.

> [!NOTE]
> New items have now gotten their ids in the CRM system.

Changes to the QuoteContextInfo are ignored.

## void OnBeforeDeleteQuote( QuoteInfo quote, ISaleInfo sale )

Called before a sale containing a quote is deleted. Clean up in the ERP system, if needed.

<!-- Referenced links -->
[1]: set-up.md

<!-- Referenced images -->
[img1]: media/image006.jpg
