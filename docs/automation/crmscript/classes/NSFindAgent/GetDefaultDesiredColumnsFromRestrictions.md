---
title: crmscript_ref_NSFindAgent_GetDefaultDesiredColumnsFromRestrictions
description: ArchiveColumnInfoArray GetDefaultDesiredColumnsFromRestrictions(String providerName, ArchiveRestrictionInfoArray restrictions)
intellisense: NSFindAgent.GetDefaultDesiredColumnsFromRestrictions
keywords: NSFindAgent,GetDefaultDesiredColumnsFromRestrictions
so.topic: reference
---

Calculate the default desired columns, i.e., the result columns for a given search. The search is defined by a provider name and a set of restrictions. This is the algorithm that is used by the Find service method.

**Parameters:**
 - **providerName** Name of the provider to calculate default desired columns for
 - **restrictions** Restriction to use in the calculation of default desired columns

**Returns:** Column information for the default desired columns, fully populated. Percentage-specified column widths sum to exactly 100.

```crmscript
NSFindAgent agent;
String providerName;
ArchiveRestrictionInfoArray restrictions;
ArchiveColumnInfoArray res = agent.GetDefaultDesiredColumnsFromRestrictions(providerName, restrictions);
```

