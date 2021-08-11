---
uid: crmscript_ref_NSFindAgent_GetDefaultDesiredColumnsFromRestrictions2
title: NSArchiveColumnInfo[] GetDefaultDesiredColumnsFromRestrictions2(String providerName, String restrictions)
intellisense: NSFindAgent.GetDefaultDesiredColumnsFromRestrictions2
keywords: NSFindAgent, GetDefaultDesiredColumnsFromRestrictions2
so.topic: reference
---

# NSArchiveColumnInfo[] GetDefaultDesiredColumnsFromRestrictions2(String providerName, String restrictions)

Calculate the default desired columns, i.e., the result columns for a given search. The search is defined by a provider name and a set of restrictions. This is the algorithm that is used by the Find service method.

**Parameters:**
 - **providerName** Name of the provider to calculate default desired columns for
 - **restrictions** Restriction to use in the calculation of default desired columns

**Returns:** NSArchiveColumnInfo[]

```crmscript
NSFindAgent agent;
String providerName;
String restrictions;
NSArchiveColumnInfo[] res = agent.GetDefaultDesiredColumnsFromRestrictions2(providerName, restrictions);
```

