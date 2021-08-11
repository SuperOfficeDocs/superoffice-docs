---
uid: crmscript_class_nsassociateagent_getassociatelist
title: NSAssociate[] GetAssociateList()
description: CRMScript method in the NSAssociateAgent class that retrieves a list of associates
intellisense: NSAssociateAgent.GetAssociateList
keywords: NSAssociateAgent, GetAssociateList, GetAssociateList(Integer[])
so.topic: reference
---

# GetAssociateList()

Gets an array of Associate objects.

`NSAssociate[] GetAssociateList(Integer[] associateIds)`

## Parameters

| Parameter | Type | Description |
|---|---|---|
| associateIds | NSAssociate[] | The identifiers of the NSAssociate objects |

## Examples

```crmscript
Integer[] ids;
NSAssociateAgent agent;
agent.GetAssociateList(ids);
```
