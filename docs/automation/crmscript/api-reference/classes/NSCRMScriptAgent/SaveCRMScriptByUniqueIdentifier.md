---
uid: crmscript_ref_NSCRMScriptAgent_SaveCRMScriptByUniqueIdentifier
title: Script SaveCRMScriptByUniqueIdentifier(String uniqueIdentifier, Script crmscript)
intellisense: NSCRMScriptAgent.SaveCRMScriptByUniqueIdentifier
keywords: NSCRMScriptAgent, SaveCRMScriptByUniqueIdentifier
so.topic: reference
---

# Script SaveCRMScriptByUniqueIdentifier(String uniqueIdentifier, Script crmscript)

Create or Update the CRMScript information

**Parameters:**
 - **uniqueIdentifier** Global unique reference to script (independent of installation)
 - **crmscript** Information about the CRMScript

**Returns:** Information about the CRMScript as saved in the database

```crmscript
NSCRMScriptAgent agent;
String uniqueIdentifier;
Script crmscript;
Script res = agent.SaveCRMScriptByUniqueIdentifier(uniqueIdentifier, crmscript);
```

