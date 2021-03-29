---
title: crmscript_ref_NSFindAgent_GetDefaultDesiredColumnsFromRestrictions_String_p_0_NSArchiveRestrictionInfo__p_1
description: NSFindAgent.GetDefaultDesiredColumnsFromRestrictions(String p_0, NSArchiveRestrictionInfo[] p_1)
intellisense: NSFindAgent.GetDefaultDesiredColumnsFromRestrictions
sortOrder: 3654
keywords: GetDefaultDesiredColumnsFromRestrictions(String,NSArchiveRestrictionInfo[])
so.topic: reference
---


Calculate the default desired columns, i.e., the result columns for a given search. The search is defined by a provider name and a set of restrictions. This is the algorithm that is used by the Find service method.



* **providerName:** Name of the provider to calculate default desired columns for
* **restrictions:** Restriction to use in the calculation of default desired columns
* **Returns:** Column information for the default desired columns, fully populated. Percentage-specified column widths sum to exactly 100.


