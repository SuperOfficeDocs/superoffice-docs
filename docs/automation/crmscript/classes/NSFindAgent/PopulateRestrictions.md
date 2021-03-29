---
title: crmscript_ref_NSFindAgent_PopulateRestrictions_String_p_0_NSArchiveRestrictionInfo__p_1
description: NSFindAgent.PopulateRestrictions(String p_0, NSArchiveRestrictionInfo[] p_1)
intellisense: NSFindAgent.PopulateRestrictions
sortOrder: 3662
keywords: PopulateRestrictions(String,NSArchiveRestrictionInfo[])
so.topic: reference
---


Take an incoming set of minimally populated restrictions (name + operator is required), and populate all the other parts of the ArchiveRestrictionInfo structure. This includes column information, display values (including list value lookup), and calculated/default values where the value hints specify read-only (R).



* **providerName:** Provider name to use for populating column information
* **restrictions:** Restrictions to populate. The Name and Operator fields have to have valid content, and Values should be set as appropriate. Other fields can be left blank or null. If a ColumnInfo is already set, it will not be overwritten.
* **Returns:** Fully populated restrictions in the same order as the incoming restrictions.


