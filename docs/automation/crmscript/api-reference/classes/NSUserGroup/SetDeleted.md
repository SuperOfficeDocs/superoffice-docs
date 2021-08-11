---
uid: crmscript_class_nsusergroup_setdeleted
title: SetDeleted()
description: CRMScript method in the NSUserGroup class that marks a user group
intellisense: NSUserGroup.SetDeleted
keywords: NSUserGroup, GetDeleted, SetDeleted(Bool)
so.topic: reference
---

# SetDeleted()

Deleted equal to true means that this is a user group that no longer can be selected by the user. It is not permitted to delete a UserGroup.

`SetDeleted(Bool deleted)`

## Parameter

| Parameter | Type | Description |
|---|---|---|
| deleted | Bool | True when a user group is soft-deleted and no longer seen by users. Not permitted to permanently delete a UserGroup. |

## Examples

```crmscript
NSUserGroup thing;
Bool deleted;
thing.SetDeleted(deleted);
```
