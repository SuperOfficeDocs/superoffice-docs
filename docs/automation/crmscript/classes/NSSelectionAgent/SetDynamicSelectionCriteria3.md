---
title: NSArchiveRestrictionInfo[] SetDynamicSelectionCriteria3(Integer selectionId, NSArchiveRestrictionInfo[] criteria, String filter)
path: /EJScript/Classes/NSSelectionAgent/Member functions/NSArchiveRestrictionInfo[] SetDynamicSelectionCriteria3(Integer p_0, NSArchiveRestrictionInfo[] p_1, String p_2)
intellisense: 1
classref: 1
sortOrder: 7361
keywords: SetDynamicSelectionCriteria3(Integer,NSArchiveRestrictionInfo[],String)
---


Update the criteria for this dynamic selection. Use criteria as either restriction objects or OData string format. Criteria are parsed from the OData filter form: ''name startswith 'foo' and category in (1,2,3)''



* **selectionId:** The id of the selection to add members
* **criteria:** Criteria defining the selection result. Pass NULL if using the filter string instead.
* **filter:** Criteria defining the selection result in OData filter form: `category in (1,2,3) and name = 'foo'`. Pass NULL or empty string '' if using the criteria objects.
* **Returns:** Criteria defining the selection result. NULL if this is not a dynamic selection.


