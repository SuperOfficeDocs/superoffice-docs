---
title: NSArchiveRestrictionInfo[] SetDynamicSelectionCriteria2(Integer selectionId, String filter)
path: /EJScript/Classes/NSSelectionAgent/Member functions/NSArchiveRestrictionInfo[] SetDynamicSelectionCriteria2(Integer p_0, String p_1)
intellisense: 1
classref: 1
sortOrder: 7360
keywords: SetDynamicSelectionCriteria2(Integer,String)
---


Update the criteria for this dynamic selection using string. Criteria are parsed from the OData filter form: ''name startswith 'foo' and category in (1,2,3)''



* **selectionId:** The id of the selection to add members
* **filter:** Criteria defining the selection result in OData filter form: `category in (1,2,3) and name = 'foo'`
* **Returns:** Criteria defining the selection result. NULL if this is not a dynamic selection.


