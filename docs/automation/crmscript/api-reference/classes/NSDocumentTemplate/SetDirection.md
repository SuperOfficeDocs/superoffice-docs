---
uid: crmscript_class_nsdocumenttemplate_setdirection
title: SetDirection()
description: CRMScript method in the NSDocumentTemplate class that sets the direction of a document template
intellisense: NSDocumentTemplate.SetDirection
keywords: NSDocumentTemplate, GetDirection, SetDirection(NSDocTmplDirection direction), SetDirection(NSDocTmplDirection)
so.topic: reference
---

# SetDirection()

## Parameters

| Parameter | Type | Description |
|---|---|---|
| direction | NSDocTmplDirection | The direction of documents from this template |

### Directions

| Enum | Direction | Description |
|---|---|---|
| 0 | Unknown | The direction of documents from this template is unknown/undecided |
| 1 | Incoming | Document template for incoming documents |
| 2 | Outgoing | Document template is used for outgoing documents |
| 3 | SaintAll | All choice for Saint. This is NOT an acceptable value for a task definition, but is used by the Saint system for indexing all directions |

See EAppntDirection

## Examples

```crmscript
NSDocumentTemplate thing;
NSDocTmplDirection direction;
thing.SetDirection(direction);
```
