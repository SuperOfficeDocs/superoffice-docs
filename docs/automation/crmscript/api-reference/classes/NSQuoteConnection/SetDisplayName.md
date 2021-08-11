---
uid: crmscript_ref_NSQuoteConnection_SetDisplayName
title: SetDisplayName(String displayName)
intellisense: NSQuoteConnection.SetDisplayName
keywords: NSQuoteConnection, GetDisplayName
so.topic: reference
---

# SetDisplayName(String displayName)

Connection name shown to user; multi-language support. The name of the connector to display in a list so that the users can choose between them. Typically the name of the client, with maybe the ERP system in parenthesis.

**Parameter:** 
 - **displayName** String

```crmscript
NSQuoteConnection thing;
String displayName;
thing.SetDisplayName(displayName);
```

