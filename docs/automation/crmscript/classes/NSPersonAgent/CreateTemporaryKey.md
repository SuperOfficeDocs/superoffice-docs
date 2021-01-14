---
title: String CreateTemporaryKey(Integer domain, Integer targetId, Integer personId, DateTime expires)
path: /EJScript/Classes/NSPersonAgent/Member functions/String CreateTemporaryKey(Integer p_0, Integer p_1, Integer p_2, DateTime p_3)
intellisense: 1
classref: 1
sortOrder: 4957
keywords: CreateTemporaryKey(Integer,Integer,Integer,DateTime)
---


Create a temporary key in the database from the given parameters and return the key string. Used for temporary keys for accessing customer centric functionality, such as UpdateSubscriptions.



* **domain:** The domain this key is for
* **targetId:** The primary key of the entity this is for. Depends on domain.
* **personId:** The person this key is for. May be null.
* **expires:** When the key will expire (servers local time)
* **Returns:** The key as base64, ready to be used e.g. in a URL


