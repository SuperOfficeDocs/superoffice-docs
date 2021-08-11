---
uid: crmscript_ref_NSReplyTemplate_SetFolderId
title: SetFolderId(Integer folderId)
intellisense: NSReplyTemplate.SetFolderId
keywords: NSReplyTemplate, GetFolderId
so.topic: reference
---

# SetFolderId(Integer folderId)

The id of the folder in which this reply template is located. NULL or -1 if this is a toplevel reply template.

**Parameter:** 
 - **folderId** Integer

```crmscript
NSReplyTemplate thing;
Integer folderId;
thing.SetFolderId(folderId);
```

