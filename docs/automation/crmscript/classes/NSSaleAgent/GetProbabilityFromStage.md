---
title: crmscript_ref_NSSaleAgent_GetProbabilityFromStage
description: Integer GetProbabilityFromStage(Integer stageId)
intellisense: NSSaleAgent.GetProbabilityFromStage
keywords: NSSaleAgent,GetProbabilityFromStage
so.topic: reference
---

Get the probability percentage for a given sale stage

**Parameters:**
 - **stageId** Probability list id

**Returns:** Probability percentage

```crmscript
NSSaleAgent agent;
Integer stageId;
Integer res = agent.GetProbabilityFromStage(stageId);
```

