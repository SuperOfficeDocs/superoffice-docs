---
uid: crmscript_ref_NSFindAgent_PopulateRestrictions
title: NSArchiveRestrictionInfo[] PopulateRestrictions(String providerName, NSArchiveRestrictionInfo[] restrictions)
intellisense: NSFindAgent.PopulateRestrictions
keywords: NSFindAgent, PopulateRestrictions
so.topic: reference
---

# NSArchiveRestrictionInfo[] PopulateRestrictions(String providerName, NSArchiveRestrictionInfo[] restrictions)

Take an incoming set of minimally populated restrictions (name + operator is required), and populate all the other parts of the NSArchiveRestrictionInfo structure. This includes column information, display values (including list value lookup), and calculated/default values where the value hints specify read-only (R).

**Parameters:**
 - **providerName** Provider name to use for populating column information
 - **restrictions** Restrictions to populate. The Name and Operator fields have to have valid content, and Values should be set as appropriate. Other fields can be left blank or null. If a ColumnInfo is already set, it will not be overwritten.

**Returns:** NSArchiveRestrictionInfo[]

```crmscript
NSFindAgent agent;
String providerName;
NSArchiveRestrictionInfo[] restrictions;
NSArchiveRestrictionInfo[] res = agent.PopulateRestrictions(providerName, restrictions);
```

