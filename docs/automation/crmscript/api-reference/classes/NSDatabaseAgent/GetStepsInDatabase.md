---
uid: crmscript_ref_NSDatabaseAgent_GetStepsInDatabase
title: NSDictionaryStepInformation[] GetStepsInDatabase()
intellisense: NSDatabaseAgent.GetStepsInDatabase
keywords: NSDatabaseAgent, GetStepsInDatabase
so.topic: reference
---

Get information about the dictionary steps that are in the currently-loggedon database


**Returns:** Array of dictionary steps in the database, listing only the highest number for each step

```crmscript
NSDatabaseAgent agent;
NSDictionaryStepInformation[] res = agent.GetStepsInDatabase();
```

