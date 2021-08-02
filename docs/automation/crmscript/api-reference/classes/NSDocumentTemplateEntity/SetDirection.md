---
uid: crmscript_class_nsdocumenttemplateentity_setdirection
title: SetDirection(NSDocTmplDirection direction)
description: CRMScript method in the NSDocumentTemplateEntity class that sets the direction of a document template
intellisense: NSDocumentTemplateEntity.SetDirection
keywords: NSDocumentTemplateEntity, GetDirection, SetDirection(NSDocTmplDirection direction), SetDirection(NSDocTmplDirection)
so.topic: reference
---

# SetDirection()

## Parameter

| Parameter | Type | Description |
|---|---|---|
| direction | NSDocTmplDirection |  The direction of documents from this template |

| Enum | Direction | Description |
|---|---|---|
| 0 | Unknown | The direction of documents from this template is unknown/undecided |
| 1 | Incoming | Document template for incoming documents |
| 2 | Outgoing | Document template is used for outgoing documents |
| 3 | SaintAll | All choice for Saint. This is NOT an acceptable value for a task definition, but is used by the Saint system for indexing all directions |

See EAppntDirection

## Examples

```crmscript
NSDocumentTemplateEntity thing;
NSDocTmplDirection direction;
thing.SetDirection(direction);
```
