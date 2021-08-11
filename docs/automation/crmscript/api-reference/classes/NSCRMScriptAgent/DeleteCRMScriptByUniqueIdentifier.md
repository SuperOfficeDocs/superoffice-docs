---
uid: crmscript_ref_NSCRMScriptAgent_DeleteCRMScriptByUniqueIdentifier
title: Void DeleteCRMScriptByUniqueIdentifier(String uniqueIdentifier)
intellisense: NSCRMScriptAgent.DeleteCRMScriptByUniqueIdentifier
keywords: NSCRMScriptAgent, DeleteCRMScriptByUniqueIdentifier
so.topic: reference
---

# Void DeleteCRMScriptByUniqueIdentifier(String uniqueIdentifier)

Delete the CRMScript

**Parameters:**
 - **uniqueIdentifier** Global unique reference to script (independent of installation)

```crmscript
NSCRMScriptAgent agent;
String uniqueIdentifier;
agent.DeleteCRMScriptByUniqueIdentifier(uniqueIdentifier);
```

