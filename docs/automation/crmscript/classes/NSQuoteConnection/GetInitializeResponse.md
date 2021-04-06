---
uid: crmscript_ref_NSQuoteConnection_GetInitializeResponse
title: PluginResponse GetInitializeResponse()
intellisense: NSQuoteConnection.GetInitializeResponse
keywords: NSQuoteConnection, GetInitializeResponse
so.topic: reference
---

Status and Error message when the system called the connector Initialize method. Null if the connector has not been initialized yet.

**Returns:** PluginResponse


```crmscript
NSQuoteConnection thing;
PluginResponse initializeResponse  = thing.GetInitializeResponse();
```


