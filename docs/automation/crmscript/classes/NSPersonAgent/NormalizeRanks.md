---
title: Bool NormalizeRanks(Integer contactId)
path: /EJScript/Classes/NSPersonAgent/Member functions/Bool NormalizeRanks(Integer p_0)
intellisense: 1
classref: 1
keywords: NormalizeRanks(Integer)
---


Nomralize the ranks for all persons that belong to a contact. This means that the persons will be sorted according to their current rank values, and the ranks will be made monotonically increasing from 1.



* **contactId:** Id of contact whose persons are to be rank normalized
* **Returns:** The reutrn value is true if the operation suceeded, either because all persons were already normalized, or because normalization was done. It is false if Sentry blocks any required changes.


