---
title: crmscript_ref_NSFindAgent_GetDefaultDesiredColumns_String_p_0_String_p_1_String_p_2
description: NSFindAgent.GetDefaultDesiredColumns(String p_0, String p_1, String p_2)
intellisense: NSFindAgent.GetDefaultDesiredColumns
sortOrder: 3653
keywords: GetDefaultDesiredColumns(String,String,String)
so.topic: reference
---


Calculate the default desired columns, i.e., the result columns for a given search. The search is defined by a storage type, provider name and storage key, which are used to fetch the corresponding restrictions from the database (in the same way as Find does). If you want to specify the restriction directly, use the GetDefaultDesiredColumnsFromRestrictions method instead. This is the algorithm that is used by the Find service method.



* **storageType:** Restriction storage type specification, either 'Criteria' or 'Reporter' (or possible extensions)
* **providerName:** Name of the provider to calculate default desired columns for
* **storageKey:** Storage key to be interpreted by the restriction storage provider, when it fetches criteria for the search
* **Returns:** Column information for the default desired columns, fully populated. Percentage-specified column widths sum to exactly 100.


