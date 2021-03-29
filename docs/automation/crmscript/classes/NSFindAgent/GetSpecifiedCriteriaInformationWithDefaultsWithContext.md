---
title: crmscript_ref_NSFindAgent_GetSpecifiedCriteriaInformationWithDefaultsWithContext_String_p_0_String_p_1_String_p_2_String__p_3_String__p_4_String_p_5
description: NSFindAgent.GetSpecifiedCriteriaInformationWithDefaultsWithContext(String p_0, String p_1, String p_2, String[] p_3, String[] p_4, String p_5)
intellisense: NSFindAgent.GetSpecifiedCriteriaInformationWithDefaultsWithContext
sortOrder: 3666
keywords: GetSpecifiedCriteriaInformationWithDefaultsWithContext(String,String,String,String[],String[],String)
so.topic: reference
---


Get criteria information from a set of saved criteria, for a specific set of columns. The result contains the restrictions in two forms: fully populated ArchiveRestrictionInfo objects, used to display details and for saving changes; and as a list suitable for an Archive control. ALL columns specified in the call will be present in the results; those that do not have corresponding criteria set will have empty values and the default (first) operator, with the IsActive flag set to false.



* **storageType:** Restriction storage type specification, either 'Criteria' or 'Reporter' (or possible extensions)
* **providerName:** Name of archive provider that is the intended consumer of the restrictions
* **storageKey:** Storage key to be interpreted by the restriction storage provider, when it fetches criteria for the search
* **desiredColumnNames:** Optional array of restrictions that are to be EXCLUDED from the CriteriaArchiveRows part of the result. In the Find dialogs, that corresponds to the 'static' fields, to avoid duplicating them in the 'Match also' criteria list. This array can be null, indicating that all restrictions should be included in the criteria list.
* **staticColumns:** Optional array of restrictions that are to be EXCLUDED from the CriteriaArchiveRows part of the result. In the Find dialogs, that corresponds to the 'static' fields, to avoid duplicating them in the 'Match also' criteria list. This array can be null, indicating that all restrictions should be included in the criteria list.
* **context:** Optional context that can be used by FindProvider
* **Returns:** The result contains the restrictions in two forms: fully populated ArchiveRestrictionInfo objects, used to display details and for saving changes; and as a list suitable for an Archive control. ALL columns specified in the call will be present in the results; those that do not have corresponding criteria set will have empty values and the default (first) operator, with the IsActive flag set to false.


