---
uid: crmscript_class_nserpsyncagent_createerpactorfromcrm
title: Bool CreateErpActorFromCrm()
description: CRMScript method in the NSErpSyncAgent class that creates an ErpActor from a CRM entity.
intellisense: NSErpSyncAgent.CreateErpActorFromCrm
keywords: NSErpSyncAgent, CreateErpActorFromCrm, CreateErpActorFromCrm(Integer,Integer,Integer,Integer,StringDictionary)
so.topic: reference
---

# CreateErpActorFromCrm()

Creates an ErpActor from a CRM entity.

Returns the created ERP actor with success.

`Bool CreateErpActorFromCrm(Integer connectionId, Integer crmEntityId, Integer erpActorType, Integer crmActorType, StringDictionary erpFieldKeyValues)`

## Parameters

| Parameter | Type | Description |
|---|---|---|
| connectionId | Integer | The connection ID |
| crmEntityId | Integer | The ID of the CRM entity to create an ERP actor from |
| erpActorType | Integer | The ERP actor type |
| crmActorType | Integer | The CRM actor type |
| erpFieldKeyValues | StringDictionary | A map of matching ERP field keys and values to set for the new entity |

### ERP actor type

| Enum | Type |
|---|---|
| 0 | Unknown |
| 1 | Customer |
| 2 | Supplier |
| 3 | Partner |
| 4 | Person |
| 5 | Project |
| 6 | Employee |
| 7 | Sale |

### CRM actor type

| Enum | Type |
|---|---|
| 0 | Unknown |
| 1 | Contact |
| 2 | Person |
| 3 | Project |
| 4 | Sale |

## Examples

```crmscript
NSErpSyncAgent agent;
Integer connectionId;
Integer crmEntityId;
Integer erpActorType;
Integer crmActorType;
StringDictionary erpFieldKeyValues;
Bool res = agent.CreateErpActorFromCrm(connectionId, crmEntityId, erpActorType, crmActorType, erpFieldKeyValues);
```
