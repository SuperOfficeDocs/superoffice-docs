---
uid: crmscript_ref_NSErpSyncAgent_MoveErpFieldItem
title: Void MoveErpFieldItem(Integer erpFieldId, Integer direction, Integer erpConnectionId, Integer erpActorType)
intellisense: NSErpSyncAgent.MoveErpFieldItem
keywords: NSErpSyncAgent, MoveErpFieldItem
so.topic: reference
---

# Void MoveErpFieldItem(Integer erpFieldId, Integer direction, Integer erpConnectionId, Integer erpActorType)

Moves the rank of the erp field up or down

**Parameters:**
 - **erpFieldId** The id of the erp field to move
 - **direction** Positive value to increase rank, negative to decrease.
 - **erpConnectionId** The id of the connection
 - **erpActorType** The actor type for which we want to rank fields
     - Enum: 0 = Unknown 
     - Enum: 1 = Customer 
     - Enum: 2 = Supplier 
     - Enum: 3 = Partner 
     - Enum: 4 = Person 
     - Enum: 5 = Project 
     - Enum: 6 = Employee 
     - Enum: 7 = Sale 
