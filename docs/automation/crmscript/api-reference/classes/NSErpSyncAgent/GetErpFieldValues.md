---
uid: crmscript_ref_NSErpSyncAgent_GetErpFieldValues
title: String[] GetErpFieldValues(Integer erpConnectionId, Integer crmActorType, Integer entityId, String[] fieldKeys)
intellisense: NSErpSyncAgent.GetErpFieldValues
keywords: NSErpSyncAgent, GetErpFieldValues
so.topic: reference
---

# String[] GetErpFieldValues(Integer erpConnectionId, Integer crmActorType, Integer entityId, String[] fieldKeys)

Get the values for the specified fields from the ERP connection

**Parameters:**
 - **erpConnectionId** The id of the connection
 - **crmActorType** The type of the CRM entity
     - Enum: 0 = Unknown 
     - Enum: 1 = Contact 
     - Enum: 2 = Person 
     - Enum: 3 = Project 
     - Enum: 4 = Sale 
 - **entityId** The id of the entity
 - **fieldKeys** The fields for which you want to get the values

**Returns:** String[]

```crmscript
NSErpSyncAgent agent;
Integer erpConnectionId;
Integer crmActorType;
Integer entityId;
String[] fieldKeys;
String[] res = agent.GetErpFieldValues(erpConnectionId, crmActorType, entityId, fieldKeys);
```

