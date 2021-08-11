---
uid: crmscript_class_nsbatchtaskinfo_setparameterobject
title: SetParameterObject()
description: CRMScript method in the NSBatchTaskInfo class that serializes a StringDictionary to a binary blob and saves it in the BinaryObject table
intellisense: NSBatchTaskInfo.SetParameterObject
keywords: NSBatchTaskInfo, SetParameterObject, SetParameterObject(StringDictionary)
so.topic: reference
---

# SetParameterObject()

ParameterObject will be serialized to a binary blob and saved in the `BinaryObject` table. The link to the BinaryObject will be set using DetailsTable and DetailsRecord.

`SetParameterObject(StringDictionary parameterObject)`

## Parameter

| Parameter | Type | Description |
|---|---|---|
| parameterObject | StringDictionary | |

## Examples

```crmscript
NSBatchTaskInfo thing;
StringDictionary parameterObject;
thing.SetParameterObject(parameterObject);
```
