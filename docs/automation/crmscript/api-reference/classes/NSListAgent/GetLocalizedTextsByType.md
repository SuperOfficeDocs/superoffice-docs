---
uid: crmscript_class_nslistagent_getlocalizedtextsbytype
title: NSLocalizedText[] GetLocalizedTextsByType()
description: CRMScript method in the NSListAgent class that gets localized text by their type
intellisense: NSListAgent.GetLocalizedTextsByType
keywords: NSListAgent, GetLocalizedTextsByType, GetLocalizedTextsByType(Integer[])
so.topic: reference
---

# GetLocalizedTextsByType()

Gets localized text by their type.

Returns an array of NSLocalizedText objects.

`NSLocalizedText[] GetLocalizedTextsByType(Integer[] textTypes)`

## Parameters

| Parameter | Type | Description |
|---|---|---|
| textTypes | Integer[] | Array of localized text types. If null, all texts are returned. |

### Types

| Enum | Type |
|---|---|
| 0 | Unknown |
| 1 | Label |
| 2 | Table |
| 3 | Column |
| 4 | ImportField |
| 5 | ImportObject |
| 6 | ImportGUICategory |
| 7 | StartupHints |
| 11 | FunctionRightLabel |
| 12 | FunctionRightDesc |
| 16 | StatusMonitorName |
| 19 | UdefContactLabel |
| 20 | UdefPersonLabel |
| 21 | UdefProjectLabel |
| 22 | UdefSaleLabel |
| 23 | UdefAppointmentLabel |
| 24 | UdefDocumentLabel |
| 41 | PushNotificationText |

## Examples

```crmscript
NSListAgent agent;
LocalizedTextType[] textTypes;
NSLocalizedText[] res = agent.GetLocalizedTextsByType(textTypes);
```
