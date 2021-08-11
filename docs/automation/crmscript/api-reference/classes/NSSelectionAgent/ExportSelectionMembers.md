---
uid: crmscript_ref_NSSelectionAgent_ExportSelectionMembers
title: Byte[] ExportSelectionMembers(Integer selectionId, String templateName, Bool useContacts)
intellisense: NSSelectionAgent.ExportSelectionMembers
keywords: NSSelectionAgent, ExportSelectionMembers
so.topic: reference
---

# Byte[] ExportSelectionMembers(Integer selectionId, String templateName, Bool useContacts)

ExportSelectionMembers will generate a string that is the result of substituting the template variables with values from selectionmembers.

**Parameters:**
 - **selectionId** The id of the selection to generate the exported file.
 - **templateName** The templateName parameter is the relative path of a .sxf file template. The .sxf files can be found in \template or in the user folder of the so archive.
 - **useContacts** If the selection contains other members than contacts, setting this to true will export the contact archive of the selection.

**Returns:** Byte[]

```crmscript
NSSelectionAgent agent;
Integer selectionId;
String templateName;
Bool useContacts;
Byte[] res = agent.ExportSelectionMembers(selectionId, templateName, useContacts);
```

