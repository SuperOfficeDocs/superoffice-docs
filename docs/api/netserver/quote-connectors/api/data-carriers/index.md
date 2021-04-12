---
title: quote_connectors_data_cariers
description: Data carriers for quote
author: {github-id}             # Your GitHub alias.
so.date:
keywords: quote
so.topic: concept
---

# Data carriers

The information the system exchanges between SuperOffice and the connectors is packed in what we like to call **carriers**. These are data-transfer-objects (DTOs). They have no methods/behavior.

The database schema is very similar to these data carriers, but it is not identical. For example, a price list in the database has a `PricelistId` field, which is not in the carrier because the carrier shall carry data from other systems as well. So the `PricelistId` field is put into the `ERPPricelistKey` field as a string by the SuperOffice connector.

All these carriers are defined in the *SuperOffice.Plugins.DLL*. They will not change after release, unlike the implementation classes stored in *SoDatabase.DLL.*

To keep these classes apart from the internal SuperOffice classes, we have suffixed the class names with "Info", like `QuoteAlternativeInfo`.
