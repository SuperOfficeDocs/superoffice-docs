---
uid: crmscript_ref_NSQuoteAgent_SendQuoteVersion
title: NSPluginUrlResponse SendQuoteVersion(Integer quoteVersionId, DateTime expiryDate, DateTime followupDate, String followupText, String culture)
intellisense: NSQuoteAgent.SendQuoteVersion
keywords: NSQuoteAgent, SendQuoteVersion
so.topic: reference
---

# NSPluginUrlResponse SendQuoteVersion(Integer quoteVersionId, DateTime expiryDate, DateTime followupDate, String followupText, String culture)

Send the quote to the user's customer. More parameters to be added later...

**Parameters:**
 - **quoteVersionId** QuoteVersionId of the quoteversion to send
 - **expiryDate** Date the quote expires
 - **followupDate** Date for the followup task, to remind the sales rep about the quote
 - **followupText** The body text for the follwup appointment, resolved to the correct culture (no resources please)
 - **culture** Desired culture for email body and other culture-sensitive templates/content

**Returns:** NSPluginUrlResponse

```crmscript
NSQuoteAgent agent;
Integer quoteVersionId;
DateTime expiryDate;
DateTime followupDate;
String followupText;
String culture;
NSPluginUrlResponse res = agent.SendQuoteVersion(quoteVersionId, expiryDate, followupDate, followupText, culture);
```

