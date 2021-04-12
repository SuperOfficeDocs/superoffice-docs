---
title: quoteconnectorextender
description: ERP Quote Connector Interface class QuoteConnectorExtender
author: {github-id}
so.date:
keywords: quote
so.topic: reference
---

# QuoteConnectorExtender

This class is made to make it easier to make some installation-specific changes to a connector without changing the connector itself.

Just inherit `QuoteConnectorExtender`, override the function (-s) you need to change (or extend the functionality), and make SuperOffice connect to the new extender connector instead of the ERP connector (`dynamicload` section in the *SuperOffcie.config* file).

Fundamentally, this new connector puts itself between the ERPConnector and SuperOffice

## QuoteConnectorExtender implementation

The `QuoteConnectorExtender` implements the `IQuoteConnector` API by wrapping another connector and delegating all calls to the wrapped connector.

To use the extender, you sub-class the `QuoteConnectorExtender`, and pass the name of the connector you would like to extend as part of the constructor call.

You then override any API calls that you want to change and leave the rest to the base implementation – which just forwards the calls to the wrapped connector.

![43][img1]

Here we extend the SuperOffice quote connector, but we override the default implementation of `OnQuoteLineChanged` with our own custom logic.

`MyQuoteConnector` tells the extender to wrap the SuperOffice quote connector by passing the name to the base constructor.

Because the `QuoteConnectorExtender` class lives in the Plugins DLL, the `MyQuoteConnector` avoids taking direct dependency on the SoCore and SoDatabase DLLs, so it won’t be affected when a version change updates the SoCore assembly.

<!-- Referenced images -->
[img1]: media/image043.png
