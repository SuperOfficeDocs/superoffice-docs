---
title: crmscript_ref_NSFindAgent_GetCriteriaInformationWithContext_String_p_0_String_p_1_String_p_2_String__p_3_String_p_4
description: NSFindAgent.GetCriteriaInformationWithContext(String p_0, String p_1, String p_2, String[] p_3, String p_4)
intellisense: NSFindAgent.GetCriteriaInformationWithContext
sortOrder: 3664
keywords: GetCriteriaInformationWithContext(String,String,String,String[],String)
so.topic: reference
---


Get criteria information from a set of saved criteria. The result contains the restrictions in two forms: fully populated ArchiveRestrictionInfo objects, used to display details and for saving changes; and as a list suitable for an Archive control



* **storageType:** Restriction storage type specification, either 'Criteria' or 'Reporter' (or possible extensions)
* **providerName:** Name of archive provider that is the intended consumer of the restrictions
* **storageKey:** Storage key to be interpreted by the restriction storage provider, when it fetches criteria for the search
* **staticColumns:** Optional array of restrictions that are to be EXCLUDED from the CriteriaArchiveRows part of the result. In the Find dialogs, that corresponds to the 'static' fields, to avoid duplicating them in the 'Match also' criteria list. This array can be null, indicating that all restrictions should be included in the criteria list.
* **context:** Optional context that can be used by FindProvider
* **Returns:** The result contains the restrictions in two forms: fully populated ArchiveRestrictionInfo objects, used to display details and for saving changes; and as a list suitable for an Archive control


