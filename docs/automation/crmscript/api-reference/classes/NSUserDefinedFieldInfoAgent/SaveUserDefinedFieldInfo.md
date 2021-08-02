---
uid: crmscript_ref_NSUserDefinedFieldInfoAgent_SaveUserDefinedFieldInfo
title: NSUserDefinedFieldInfo SaveUserDefinedFieldInfo(NSUserDefinedFieldInfo userDefinedFieldInfo);
intellisense: NSUserDefinedFieldInfoAgent.SaveUserDefinedFieldInfo
keywords: NSUserDefinedFieldInfoAgent, SaveUserDefinedFieldInfo
so.topic: reference
---
	  
Updates the existing NSUserDefinedFieldInfo or creates a new NSUserDefinedFieldInfo if the id parameter is 0
	  
**Parameters**:
 - **userDefinedFieldInfo** The NSUserDefinedFieldInfo to save.

**Returns:** NSUserDefinedFieldInfo

```crmscript
NSUserDefinedFieldInfo  agent;
NSUserDefinedFieldInfo thing = agent.CreateDefaultUserDefinedFieldInfo();
thing = agent.SaveUserDefinedFieldInfo(thing);
```

