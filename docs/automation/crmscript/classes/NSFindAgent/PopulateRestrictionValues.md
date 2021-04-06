---
uid: crmscript_ref_NSFindAgent_PopulateRestrictionValues
title: ArchiveRestrictionInfoArray PopulateRestrictionValues(ArchiveRestrictionInfoArray restrictions)
intellisense: NSFindAgent.PopulateRestrictionValues
keywords: NSFindAgent, PopulateRestrictionValues
so.topic: reference
---

Take an incoming set of Restrictions (name + operator + any user-entered values), and populate/expand all values as specified by the operator's ValueHints, taking into account any values already there. Used for dynamic date periods; perhaps others in the future

**Parameters:**
 - **restrictions** Restrictions to populate. The Name and Operator fields have to have valid content, and Values should be set as appropriate. Other fields can be left blank or null and will not be changed.

**Returns:** Restrictions in the same order as the incoming restrictions, with all values expanded.

```crmscript
NSFindAgent agent;
ArchiveRestrictionInfoArray restrictions;
ArchiveRestrictionInfoArray res = agent.PopulateRestrictionValues(restrictions);
```

