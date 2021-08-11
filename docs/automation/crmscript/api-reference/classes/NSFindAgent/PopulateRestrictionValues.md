---
uid: crmscript_ref_NSFindAgent_PopulateRestrictionValues
title: NSArchiveRestrictionInfo[] PopulateRestrictionValues(NSArchiveRestrictionInfo[] restrictions)
intellisense: NSFindAgent.PopulateRestrictionValues
keywords: NSFindAgent, PopulateRestrictionValues
so.topic: reference
---

# NSArchiveRestrictionInfo[] PopulateRestrictionValues(NSArchiveRestrictionInfo[] restrictions)

Take an incoming set of Restrictions (name + operator + any user-entered values), and populate/expand all values as specified by the operator's ValueHints, taking into account any values already there. Used for dynamic date periods; perhaps others in the future

**Parameters:**
 - **restrictions** Restrictions to populate. The Name and Operator fields have to have valid content, and Values should be set as appropriate. Other fields can be left blank or null and will not be changed.

**Returns:** NSArchiveRestrictionInfo[]

```crmscript
NSFindAgent agent;
NSArchiveRestrictionInfo[] restrictions;
NSArchiveRestrictionInfo[] res = agent.PopulateRestrictionValues(restrictions);
```

