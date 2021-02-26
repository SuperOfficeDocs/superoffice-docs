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

The QuoteVersion, QuoteAlternative, and QuoteLine objects all have the same structure: a Status and a Reason field. The Status field is of type QuoteStatus, and can thus be "OK, OKWithInfo, Warning or Error". (See Enum QuoteStatus for details). When setting the fields you should set the state for the level you are in (version, alternative, or line), and SuperOffice will concatenate and present the problems to the user in the user interface.

If, when calculating a quoteline, you find a problem with the quoteline (typically the product is discontinued and the stock is empty), you should set the Status field and put a user-friendly explanation in the Reason field.

If, when calculating the version, you have a problem connecting to some back-office system (perhaps the user is offline) that you must have access to be able to calculate, then you should set the QuoteVersion.Status to error and explain the problem in the QuoteVersion.Reason field.

And so on.

## Reason fields

The reason fields will be shown to the user, and should thus be translated to the language of the user.

If you deliver the text in the following format, SuperOffice will select the right language for you:

"US:\\" A problem occured\\";NO:\\" Et problem oppstod\\";SW:\\"Ett problem uppstod\\";GE:\\" Ein Problem ist aufgetreten\\";FR:\\" Un problème est survenu\\""

And my apologies for the translations, I used translate.google.com.

A text is multi-language if it follows the layout:

LL:"text";...

LL is a language code of two letters, same as the one used for loading the language resource DLL

The colon is literal.

The text is the text for this language, inside double quotes (no quotes inside the text please).

The semicolon is literal.

Please note that the format is quite strict; if the text does not follow these conventions, it is not parsed at all, so do test the errors too.

Some of the functions also return a PluginResponseInfo. See PluginResponseInfo for more info.
