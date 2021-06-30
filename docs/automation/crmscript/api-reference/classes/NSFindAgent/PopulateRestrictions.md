---
uid: crmscript_ref_NSFindAgent_PopulateRestrictions
title: ArchiveRestrictionInfo[] PopulateRestrictions(String providerName, ArchiveRestrictionInfo[] restrictions)
intellisense: NSFindAgent.PopulateRestrictions
keywords: NSFindAgent, PopulateRestrictions
so.topic: reference
---

Take an incoming set of minimally populated restrictions (name + operator is required), and populate all the other parts of the ArchiveRestrictionInfo structure. This includes column information, display values (including list value lookup), and calculated/default values where the value hints specify read-only (R).

**Parameters:**
 - **providerName** Provider name to use for populating column information
 - **restrictions** Restrictions to populate. The Name and Operator fields have to have valid content, and Values should be set as appropriate. Other fields can be left blank or null. If a ColumnInfo is already set, it will not be overwritten.

**Returns:** Fully populated restrictions in the same order as the incoming restrictions.

```crmscript
NSFindAgent agent;
String providerName;
ArchiveRestrictionInfo[] restrictions;
ArchiveRestrictionInfo[] res = agent.PopulateRestrictions(providerName, restrictions);
```

