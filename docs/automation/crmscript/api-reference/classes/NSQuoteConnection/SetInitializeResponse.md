---
uid: crmscript_ref_NSQuoteConnection_SetInitializeResponse
title: SetInitializeResponse(NSPluginResponse initializeResponse)
intellisense: NSQuoteConnection.SetInitializeResponse
keywords: NSQuoteConnection, GetInitializeResponse
so.topic: reference
---

# SetInitializeResponse(NSPluginResponse initializeResponse)

Status and Error message when the system called the connector Initialize method. Null if the connector has not been initialized yet.

**Parameter:** 
 - **initializeResponse** NSPluginResponse

```crmscript
NSQuoteConnection thing;
NSPluginResponse initializeResponse;
thing.SetInitializeResponse(initializeResponse);
```

