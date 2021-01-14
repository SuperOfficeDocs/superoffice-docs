---
title: Byte[] ExportSelectionMembersWithOrderBy(Integer selectionId, String templateName, Bool useContacts, String orderBy)
path: /EJScript/Classes/NSSelectionAgent/Member functions/Byte[] ExportSelectionMembersWithOrderBy(Integer p_0, String p_1, Bool p_2, String p_3)
intellisense: 1
classref: 1
sortOrder: 7348
keywords: ExportSelectionMembersWithOrderBy(Integer,String,Bool,String)
---


ExportSelectionMembers will generate a string that is the result of substituting the template variables with values from selectionmembers.



* **selectionId:** The id of the selection to generate the exported file.
* **templateName:** The templateName parameter is the relative path of a .sxf file template. The .sxf files can be found in \template or in the user folder of the so archive.
* **useContacts:** If the selection contains other members than contacts, setting this to true will export the contact archive of the selection.
* **orderBy:** OrderBy. \<Column,OrderBySortType>
* **Returns:** Returns a unicode byte array with the file to export to the user.


