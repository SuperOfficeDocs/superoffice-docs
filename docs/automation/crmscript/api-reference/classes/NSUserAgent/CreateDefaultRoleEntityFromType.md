---
uid: crmscript_ref_NSUserAgent_CreateDefaultRoleEntityFromType
title: NSRoleEntity CreateDefaultRoleEntityFromType(Integer type)
intellisense: NSUserAgent.CreateDefaultRoleEntityFromType
keywords: NSUserAgent, CreateDefaultRoleEntityFromType
so.topic: reference
---

# NSRoleEntity CreateDefaultRoleEntityFromType(Integer type)

Create a new role entity of the specified role type. The role type cannot be changed after the entity is created.

**Parameters:**
 - **type** Type of role (Employee/External/Anonymous/System)
     - Enum: 0 = Employee 
     - Enum: 1 = ExternalUser 
     - Enum: 2 = Anonymous 
     - Enum: 3 = System 

**Returns:** NSRoleEntity

```crmscript
NSUserAgent agent;
Integer type;
NSRoleEntity res = agent.CreateDefaultRoleEntityFromType(type);
```

