---
title: NSSelectionEntity CreateSelectionFromSelection(Integer selectionId, String name, Integer targetSelectionType, Bool copyMembers)
path: /EJScript/Classes/NSSelectionAgent/Member functions/NSSelectionEntity CreateSelectionFromSelection(Integer p_0, String p_1, Integer p_2, Bool p_3)
intellisense: 1
classref: 1
keywords: CreateSelectionFromSelection(Integer,String,Integer,Bool)
---


Creates a new selection based on selection members from an existing selection.



* **selectionId:** The id of the selection to copy members from.
* **name:** The name of the new selection.
* **targetSelectionType:** The type of Selection to create. The type can be static or dynamic. If the original selection to copy from is static, the SelectionType can only be static. If the original selection is dynamic, both a static and dynamic selection can be created.
* **copyMembers:** If true, the members from the original selection will be added to the newly created selection.
* **Returns:** Returns the newly created SelectionEntity.


