---
title: crmscript_ref_NSPersonAgent_NormalizeRanks_Integer_p_0
description: NSPersonAgent.NormalizeRanks(Integer p_0)
intellisense: NSPersonAgent.NormalizeRanks
keywords: NormalizeRanks(Integer)
so.topic: reference
---


Nomralize the ranks for all persons that belong to a contact. This means that the persons will be sorted according to their current rank values, and the ranks will be made monotonically increasing from 1.



* **contactId:** Id of contact whose persons are to be rank normalized
* **Returns:** The reutrn value is true if the operation suceeded, either because all persons were already normalized, or because normalization was done. It is false if Sentry blocks any required changes.


