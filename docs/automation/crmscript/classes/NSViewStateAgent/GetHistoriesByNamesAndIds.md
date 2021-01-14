---
title: NSHistory[] GetHistoriesByNamesAndIds(NSHistoryRequest[] requests)
path: /EJScript/Classes/NSViewStateAgent/Member functions/NSHistory[] GetHistoriesByNamesAndIds(NSHistoryRequest[] p_0)
intellisense: 1
classref: 1
sortOrder: 8737
keywords: GetHistoriesByNamesAndIds(NSHistoryRequest[])
---


Returns history data for the named entities and the given ids - which may not directly correspond to the current history records in the database.\<para/>Use this method if you know exactly which items you need, regardless of whether they are in the current history or not.\<para/>The history in the database is not changed or even looked at by this method.



* **requests:** Array of request objects that define what entities we are requesting history information for
* **Returns:** On history item for each history name/id pair specified, in exactly the same order as specified.\<para/>If a specified item cannot be found in the database, its Id will be 0 and its name will be blank in the return array.


