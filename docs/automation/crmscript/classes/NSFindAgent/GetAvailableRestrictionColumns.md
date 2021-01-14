---
title: String[] GetAvailableRestrictionColumns(String storageType, String providerName)
path: /EJScript/Classes/NSFindAgent/Member functions/String[] GetAvailableRestrictionColumns(String p_0, String p_1)
intellisense: 1
classref: 1
sortOrder: 3681
keywords: GetAvailableRestrictionColumns(String,String)
---


Get a list of the column names corresponding to available restrictions for a certain archive provider and restriction storage provider. Such columns have CanRestrict set to true, and are supported by the given restriction storage provider.



* **storageType:** Restriction storage type specification, either 'Criteria' or 'Reporter' (or possible extensions)
* **providerName:** Name of archive provider that is to execute the search and return the result columns/rows
* **Returns:** Array of column names, corresponding to support restrictions for the given archive and restriction storage providers.


