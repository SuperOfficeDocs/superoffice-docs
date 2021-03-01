---
title: quote_connector_error_system
description: ERP Quote Connector Interface error system
author: {github-id}
so.date:
keywords: quote
so.topic: concept
---

# Error system

When something is wrong and the connector needs to make the user aware of the problem, there are a few ways to do this, based on what fails.

If the connector throws an exception, SuperOffice will catch it and present the Message to the user. This should be avoided, it could leave the system in a bad state.

The QuoteVersion, QuoteAlternative, and QuoteLine objects all have the same structure: a `Status` and a [Reason field][2]. The Status field is of type [QuoteStatus][1], and can thus be either:

* OK
* OKWithInfo
* Warning
* Error

When setting the fields you should set the state for the level you are in (version, alternative, or line), and SuperOffice will concatenate and present the problems to the user in the user interface.

If, when calculating a quoteline, you find a problem with the quoteline (typically the product is discontinued and the stock is empty), you should set the `Status` field and put a user-friendly explanation in the `Reason` field.

If, when calculating the version, you have a problem connecting to some back-office system (perhaps the user is offline) that you must have access to be able to calculate, then you should set the `QuoteVersion.Status` to error and explain the problem in the `QuoteVersion.Reason` field.

And so on.

<!-- Referenced links -->
[1]: api/enums/quotestatus.md
[2]: api/reason-fields.md
