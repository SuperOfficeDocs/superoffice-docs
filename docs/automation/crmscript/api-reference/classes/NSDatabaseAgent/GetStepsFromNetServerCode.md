---
uid: crmscript_ref_NSDatabaseAgent_GetStepsFromNetServerCode
title: NSDictionaryStepInformation[] GetStepsFromNetServerCode()
intellisense: NSDatabaseAgent.GetStepsFromNetServerCode
keywords: NSDatabaseAgent, GetStepsFromNetServerCode
so.topic: reference
---

Get information about the dictionary steps that NetServer was generated for


**Returns:** Array of dictionary steps used when NetServer was generated, listing only the highest number for each step

```crmscript
NSDatabaseAgent agent;
NSDictionaryStepInformation[] res = agent.GetStepsFromNetServerCode();
```

