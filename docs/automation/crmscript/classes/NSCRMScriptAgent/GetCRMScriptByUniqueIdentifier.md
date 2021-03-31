---
uid: crmscript_ref_NSCRMScriptAgent_GetCRMScriptByUniqueIdentifier
title: Script GetCRMScriptByUniqueIdentifier(String uniqueIdentifier)
intellisense: NSCRMScriptAgent.GetCRMScriptByUniqueIdentifier
keywords: NSCRMScriptAgent, GetCRMScriptByUniqueIdentifier
so.topic: reference
---

Get information about a script from a unique identifier

**Parameters:**
 - **uniqueIdentifier** Global unique reference to script (independent of installation)

**Returns:** Information about CRMScript

```crmscript
NSCRMScriptAgent agent;
String uniqueIdentifier;
Script res = agent.GetCRMScriptByUniqueIdentifier(uniqueIdentifier);
```

