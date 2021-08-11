---
uid: crmscript_class_nsreportagent_savereportlabellayoutentity
title: NSReportLabelLayoutEntity SaveReportLabelLayoutEntity()
description: CRMScript method in the NSReportAgent class that creates or updates an NSReportLabelLayoutEntity
intellisense: NSReportAgent.SaveReportLabelLayoutEntity
keywords: NSReportAgent, SaveReportLabelLayoutEntity, SaveReportLabelLayoutEntity(NSReportLabelLayoutEntity)
so.topic: reference
---

# SaveReportLabelLayoutEntity()

Updates the existing NSReportLabelLayoutEntity or creates a new NSReportLabelLayoutEntity if the ID parameter is 0.

Returns the new or updated NSReportLabelLayoutEntity.

`NSReportLabelLayoutEntity SaveReportLabelLayoutEntity(NSReportLabelLayoutEntity reportLabelLayoutEntity)`

## Parameters

| Parameter | Type | Description |
|---|---|---|
| reportLabelLayoutEntity | NSReportLabelLayoutEntity | The entity to save. |

## Example

```crmscript
NSReport  agent;
NSReportLabelLayoutEntity thing = agent.CreateDefaultReportLabelLayoutEntity();
thing = agent.SaveReportLabelLayoutEntity(thing);
```
