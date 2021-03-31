---
title: crmscript_ref_NSSelectionAgent_ExportSelectionMembersWithOrderBy
description: ByteArray ExportSelectionMembersWithOrderBy(Integer selectionId, String templateName, Bool useContacts, String orderBy)
intellisense: NSSelectionAgent.ExportSelectionMembersWithOrderBy
keywords: NSSelectionAgent,ExportSelectionMembersWithOrderBy
so.topic: reference
---

ExportSelectionMembers will generate a string that is the result of substituting the template variables with values from selectionmembers.

**Parameters:**
 - **selectionId** The id of the selection to generate the exported file.
 - **templateName** The templateName parameter is the relative path of a .sxf file template. The .sxf files can be found in \template or in the user folder of the so archive.
 - **useContacts** If the selection contains other members than contacts, setting this to true will export the contact archive of the selection.
 - **orderBy** OrderBy. <Column,OrderBySortType>

**Returns:** Returns a unicode byte array with the file to export to the user.

```crmscript
NSSelectionAgent agent;
Integer selectionId;
String templateName;
Bool useContacts;
String orderBy;
ByteArray res = agent.ExportSelectionMembersWithOrderBy(selectionId, templateName, useContacts, orderBy);
```

